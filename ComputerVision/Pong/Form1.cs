using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.CV.Util;
using System.Drawing;

namespace Pong
{
    public partial class Form1 : Form
    {
        private VideoCapture videoCapture;
        private Mat currentFrame;
        private MCvScalar capturedColor;
        private Mat inRangeMat;

        private Mat lowerBound;
        private Mat upperBound;
        private Mat dilateErodeElement;
        private Mat heirarchy;

        private Bitmap gameMap;
        private Graphics gameGFX;

        private readonly Point defaultAnchor;
        private readonly MCvScalar defaultBorderValue;

        private const int ballSize = 16;
        private const int defaultBallVelocity = 8;
        private Rectangle ballBoundingBox;
        private Point ballVelocity;

        private const int paddleDistFromSide = 16;
        private const int rightPaddleMaxVelocity = 16;
        private readonly Size paddleSize;
        private Rectangle leftPaddleHitbox;
        private Rectangle rightPaddleHitbox;
        private int leftPaddleYVelocity;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Form1()
        {
            InitializeComponent();

            defaultAnchor = new Point(-1);
            defaultBorderValue = new MCvScalar(0, 0, 0);
            paddleSize = new Size(16, 128);
        }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        private void Form1_Load(object sender, EventArgs e)
        {
            videoCapture = new VideoCapture(0);

            KernelSizeTrackbar.Value = 3;
            IterationsTrackbar.Value = 1;

            currentFrame = new Mat();
            inRangeMat = new Mat();
            heirarchy = new Mat();
            UpdateDilateErode();

            gameMap = new Bitmap(GamePictureBox.Width, GamePictureBox.Height);

            gameGFX = Graphics.FromImage(gameMap);
            ballBoundingBox = new Rectangle(
                gameMap.Width / 2 - ballSize / 2,
                gameMap.Height / 2 - ballSize / 2,
                ballSize,
                ballSize);

            ballVelocity = new Point(defaultBallVelocity, defaultBallVelocity);

            leftPaddleHitbox = new Rectangle(
                new Point(
                    paddleDistFromSide,
                    gameMap.Height / 2 - paddleSize.Height / 2),
                paddleSize);

            rightPaddleHitbox = new Rectangle(
                new Point(
                    gameMap.Width - paddleDistFromSide - paddleSize.Width,
                    gameMap.Height / 2 - paddleSize.Height / 2),
                paddleSize);

            leftPaddleYVelocity = rightPaddleMaxVelocity;

            Application.Idle += UpdateAll!;
        }

        private void UpdateAll(object sender, EventArgs e)
        {
            UpdateCV();
            UpdateGame();
        }

        private void UpdateCV()
        {
            using Mat cameraFrame = videoCapture.QueryFrame();

            if (cameraFrame == null) return;

            cameraFrame.CopyTo(currentFrame);

            if (IsMirroredCheckbox.Checked)
            {
                CvInvoke.Flip(currentFrame, currentFrame, FlipType.Horizontal);
            }

            CvInvoke.InRange(currentFrame, lowerBound, upperBound, inRangeMat);
            InRangeImgBox.Image = inRangeMat;

            CvInvoke.Erode(inRangeMat, inRangeMat, dilateErodeElement, defaultAnchor, IterationsTrackbar.Value, BorderType.Reflect101, defaultBorderValue);
            CvInvoke.Dilate(inRangeMat, inRangeMat, dilateErodeElement, defaultAnchor, IterationsTrackbar.Value, BorderType.Reflect101, defaultBorderValue);
            DilateErodeImgBox.Image = inRangeMat;

            VectorOfVectorOfPoint contours = new();
            CvInvoke.FindContours(inRangeMat, contours, heirarchy, RetrType.External, ChainApproxMethod.ChainApproxNone);

            Mat currentFrameClone = currentFrame.Clone();

            CvInvoke.DrawContours(currentFrameClone, contours, -1, new MCvScalar(255, 255, 0), 5);
            CameraImgBox.Image = currentFrameClone;
        }
        private void UpdateGame()
        {
            leftPaddleHitbox.Y += leftPaddleYVelocity;

            if (leftPaddleHitbox.Y < 0 || leftPaddleHitbox.Y + leftPaddleHitbox.Height + leftPaddleYVelocity > gameMap.Height)
            {
                leftPaddleYVelocity *= -1;
            }



            ballBoundingBox.X += ballVelocity.X;
            ballBoundingBox.Y += ballVelocity.Y;

            if (ballBoundingBox.Bottom + ballVelocity.Y > gameMap.Height || ballBoundingBox.Y + ballVelocity.Y < 0)
            {
                ballVelocity.Y *= -1;
            }
            if (ballBoundingBox.Right + ballVelocity.X > gameMap.Width || ballBoundingBox.X + ballVelocity.X < 0)
            {
                ballVelocity.X *= -1;
            }

            if (ballBoundingBox.IntersectsWith(leftPaddleHitbox))
            {
                ballVelocity.X = defaultBallVelocity;
            }
            else if (ballBoundingBox.IntersectsWith(rightPaddleHitbox))
            {
                ballVelocity.X = -defaultBallVelocity;
            }

            gameGFX.Clear(Color.Black);

            gameGFX.FillRectangle(Brushes.White, leftPaddleHitbox);
            gameGFX.FillRectangle(Brushes.White, rightPaddleHitbox);
            gameGFX.FillEllipse(Brushes.White, ballBoundingBox);

            GamePictureBox.Image = gameMap;
        }

        private void CaptureButton_Click(object sender, EventArgs e)
        {
            capturedColor = CvInvoke.Mean(currentFrame.Clone());

            CaptureColorImgBox.Image = currentFrame;

            lowerBound = capturedColor - VarianceTrackbar.Value;
            upperBound = capturedColor + VarianceTrackbar.Value;
        }

        private void VarianceTrackbar_Scroll(object sender, EventArgs e)
        {
            if (capturedColor == null) return;

            lowerBound = capturedColor - VarianceTrackbar.Value;
            upperBound = capturedColor + VarianceTrackbar.Value;
        }

        private void UpdateDilateErode()
        {
            dilateErodeElement = CvInvoke.GetStructuringElement(
                ElementShape.Rectangle,
                new Size(KernelSizeTrackbar.Value, KernelSizeTrackbar.Value),
                new Point(-1, -1));
        }
        private void KernelSizeTrackbar_Scroll(object sender, EventArgs e) => UpdateDilateErode();

        private void CaptureImgBox_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.Cancel) return;

            var capturedFrame = CvInvoke.Imread(openFileDialog.FileName);
            capturedColor = CvInvoke.Mean(capturedFrame);
            CaptureColorImgBox.Image = capturedFrame;

            lowerBound = capturedColor - VarianceTrackbar.Value;
            upperBound = capturedColor + VarianceTrackbar.Value;
        }
    }
}