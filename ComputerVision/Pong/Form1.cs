using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace Pong
{
    public partial class Form1 : Form
    {
        private VideoCapture videoCapture;
        private Mat currentFrame;
        private MCvScalar capturedColor;
        private Mat inRangeMat;

        private ScalarArray lowerBound;
        private ScalarArray upperBound;
        private Mat erodeElement;
        private Mat dilateElement;
        private Mat contourHeirarchy;

        private Bitmap gameMap;
        private Graphics gameGFX;

        private readonly MCvScalar contourColor;
        private readonly MCvScalar boundingBoxColor;

        private readonly Point defaultAnchor;
        private readonly MCvScalar defaultBorderValue;

        private bool isGamePlaying;

        private const int ballSize = 10;
        private const int defaultBallVelocity = 6;
        private Rectangle ballBoundingBox;
        private Point ballVelocity;

        private const int paddleDistFromSide = 16;
        private const int rightPaddleMaxVelocity = 8;
        private readonly Size paddleSize;
        private Rectangle leftPaddleHitbox;
        private Rectangle rightPaddleHitbox;

#pragma warning disable CS8618 // Non-nullable fields can be null on constructor exit
        public Form1()
        {
            InitializeComponent();

            defaultAnchor = new Point(-1);
            defaultBorderValue = new MCvScalar(0, 0, 0);
            paddleSize = new Size(8, 64);
            contourColor = new MCvScalar(255, 255, 0);
            boundingBoxColor = new MCvScalar(255, 0, 255);
        }
#pragma warning restore CS8618

        private void Form1_Load(object sender, EventArgs e)
        {
            videoCapture = new VideoCapture(0);

            VarianceTrackbar.Value = 80;

            ErodeKernelSizeTrackbar.Value = 25;
            DilateKernelSizeTrackbar.Value = 25;
            ErodeIterationsTrackbar.Value = 3;
            DilateIterationsTrackbar.Value = 3;

            currentFrame = new Mat();
            Mat capturedFrame = CvInvoke.Imread(@"..\..\..\..\..\images\defaultPaddleColor.png");
            UpdateCapturedColor(capturedFrame);

            UpdateInRangeBounds();
            inRangeMat = new Mat();

            contourHeirarchy = new Mat();
            UpdateDilateErode();

            gameMap = new Bitmap(GamePictureBox.Width, GamePictureBox.Height);

            gameGFX = Graphics.FromImage(gameMap);
            ResetGame();

            Application.Idle += UpdateAll!;
        }

        private void UpdateAll(object sender, EventArgs e)
        {
            UpdateCV();
            UpdateGame();
            DrawGame();
        }

        private void UpdateCV()
        {
            using Mat cameraFrame = videoCapture.QueryFrame();

            if (cameraFrame == null) return;

            cameraFrame.CopyTo(currentFrame);
            //CvInvoke.PyrMeanShiftFiltering(currentFrame, currentFrame, 5, 10, 1, new MCvTermCriteria(5, 1));

            if (IsMirroredCheckbox.Checked)
            {
                CvInvoke.Flip(currentFrame, currentFrame, FlipType.Horizontal);
            }

            CvInvoke.InRange(currentFrame, lowerBound, upperBound, inRangeMat);
            InRangeImgBox.Image = inRangeMat;

            CvInvoke.Erode(inRangeMat, inRangeMat, erodeElement, defaultAnchor, ErodeIterationsTrackbar.Value, BorderType.Reflect101, defaultBorderValue);
            ErodeImgBox.Image = inRangeMat;

            CvInvoke.Dilate(inRangeMat, inRangeMat, dilateElement, defaultAnchor, DilateIterationsTrackbar.Value, BorderType.Reflect101, defaultBorderValue);
            DilateImgBox.Image = inRangeMat;

            VectorOfVectorOfPoint contours = new();
            CvInvoke.FindContours(inRangeMat, contours, contourHeirarchy, RetrType.External, ChainApproxMethod.ChainApproxNone);

            if (contours.Length > 0)
            {
                Moments moment = CvInvoke.Moments(contours[0]);
                Rectangle boundingRect = CvInvoke.BoundingRectangle(contours[0]);

                Mat currentFrameClone = currentFrame.Clone();

                CvInvoke.DrawContours(currentFrameClone, contours, -1, contourColor, thickness: 3);
                CvInvoke.DrawMarker(currentFrameClone, new Point((int)moment.GravityCenter.X, (int)moment.GravityCenter.Y),
                    contourColor, MarkerTypes.Cross, markerSize: 15, thickness: 3);
                CvInvoke.Rectangle(currentFrameClone, boundingRect, boundingBoxColor, thickness: 5);

                CameraImgBox.Image = currentFrameClone;
            }
        }
        private void UpdateGame()
        {
            if (!isGamePlaying) return;

            rightPaddleHitbox.Y = ballBoundingBox.Y + ballBoundingBox.Height / 2 - rightPaddleHitbox.Height / 2;
            if (rightPaddleHitbox.Y < 0)
            {
                rightPaddleHitbox.Y = 0;
            }
            else if (rightPaddleHitbox.Y + rightPaddleHitbox.Height > gameMap.Height)
            {
                rightPaddleHitbox.Y = gameMap.Height - rightPaddleHitbox.Height;
            }


            ballBoundingBox.X += ballVelocity.X;
            ballBoundingBox.Y += ballVelocity.Y;

            if (ballBoundingBox.Bottom + ballVelocity.Y > gameMap.Height || ballBoundingBox.Y + ballVelocity.Y < 0)
            {
                ballVelocity.Y *= -1;
            }
            if (ballBoundingBox.Right + ballVelocity.X > gameMap.Width || ballBoundingBox.X + ballVelocity.X < 0)
            {
                ResetGame();
            }

            if (ballBoundingBox.IntersectsWith(leftPaddleHitbox))
            {
                ballVelocity.X = defaultBallVelocity;
            }
            else if (ballBoundingBox.IntersectsWith(rightPaddleHitbox))
            {
                ballVelocity.X = -defaultBallVelocity;
            }
        }
        private void DrawGame()
        {
            gameGFX.Clear(Color.Black);

            gameGFX.FillRectangle(Brushes.White, leftPaddleHitbox);
            gameGFX.FillRectangle(Brushes.White, rightPaddleHitbox);
            gameGFX.FillEllipse(Brushes.White, ballBoundingBox);

            GamePictureBox.Image = gameMap;
        }

        private void ResetGame()
        {
            isGamePlaying = false;
            StartLabel.Show();

            ballBoundingBox = new Rectangle(
                gameMap.Width / 2 - ballSize / 2,
                gameMap.Height / 2 - ballSize / 2,
                ballSize,
                ballSize);

            ballVelocity = new Point(defaultBallVelocity, -defaultBallVelocity);

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
        }
        private void UpdateInRangeBounds()
        {
            lowerBound = (ScalarArray)new MCvScalar(
                capturedColor.V0 - VarianceTrackbar.Value,
                capturedColor.V1 - VarianceTrackbar.Value,
                capturedColor.V2 - VarianceTrackbar.Value);

            upperBound = (ScalarArray)new MCvScalar(
                capturedColor.V0 + VarianceTrackbar.Value,
                capturedColor.V1 + VarianceTrackbar.Value,
                capturedColor.V2 + VarianceTrackbar.Value);
        }
        private void UpdateDilateErode()
        {
            erodeElement = CvInvoke.GetStructuringElement(
                ElementShape.Rectangle,
                new Size(ErodeKernelSizeTrackbar.Value, ErodeKernelSizeTrackbar.Value),
                new Point(-1, -1));

            dilateElement = CvInvoke.GetStructuringElement(
                ElementShape.Rectangle,
                new Size(DilateKernelSizeTrackbar.Value, DilateKernelSizeTrackbar.Value),
                new Point(-1, -1));
        }
        private void UpdateCapturedColor(Mat capture)
        {
            CapturedFrameImgBox.Image = capture;
            capturedColor = CvInvoke.Mean(capture);
            CapturedColorImgBox.Image = (ScalarArray)capturedColor;

            UpdateInRangeBounds();
        }



        #region Events
        private void CaptureImgBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;

            var capturedFrame = CvInvoke.Imread(openFileDialog.FileName);
            UpdateCapturedColor(capturedFrame);
        }
        private void CaptureButton_Click(object sender, EventArgs e) => UpdateCapturedColor(currentFrame);

        private void VarianceTrackbar_Scroll(object sender, EventArgs e) => UpdateInRangeBounds();

        private void ErodeKernelSizeTrackbar_Scroll(object sender, EventArgs e)
        {
            if (LinkDilateErodeCheckbox.Checked)
            {
                DilateKernelSizeTrackbar.Value = ErodeKernelSizeTrackbar.Value;
            }
            UpdateDilateErode();
        }
        private void ErodeIterationsTrackbar_Scroll(object sender, EventArgs e)
        {
            if (LinkDilateErodeCheckbox.Checked)
            {
                DilateIterationsTrackbar.Value = ErodeIterationsTrackbar.Value;
            }
        }

        private void DilateKernelSizeTrackbar_Scroll(object sender, EventArgs e) => UpdateDilateErode();

        #endregion Events

        private void LinkDilateErodeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            DilateKernelSizeTrackbar.Enabled = !LinkDilateErodeCheckbox.Checked;
            DilateIterationsTrackbar.Enabled = !LinkDilateErodeCheckbox.Checked;
        }

        private void StartLabel_Click(object sender, EventArgs e) => GamePictureBox_Click(sender, e);
        private void GamePictureBox_Click(object sender, EventArgs e)
        {
            isGamePlaying = true;
            StartLabel.Hide();
        }
    }
}