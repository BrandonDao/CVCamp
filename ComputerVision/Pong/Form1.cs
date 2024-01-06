using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System.Diagnostics;

namespace Pong
{
    public partial class Form1 : Form
    {
        private VideoCapture videoCapture;
        private Mat currentFrameBGR;
        private MCvScalar capturedColor;

        private ScalarArray lowerBound;
        private ScalarArray upperBound;
        private Mat erodeElement;
        private Mat dilateElement;
        private Mat contourHeirarchy;

        private Point previousLeftPaddlePosition;
        private Point leftPaddlePosition;

        private Stopwatch collisionTimer;

        private Bitmap gameMap;
        private Graphics gameGFX;

        private readonly MCvScalar colorA;
        private readonly MCvScalar contourColor;

        private readonly Point defaultAnchor;
        private readonly MCvScalar defaultBorderValue;

        private bool isGamePlaying;

        private const int ballSize = 15;
        private const int defaultBallVelocity = 6;
        private Rectangle previousBallBoundingBox;
        private Rectangle ballBoundingBox;
        private Point ballVelocity;

        private const int paddleDistFromSide = 30;
        private readonly Size paddleSize;

        private Rectangle leftPaddleHitbox;
        private Rectangle rightPaddleHitbox;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Form1()
        {
            InitializeComponent();

            defaultAnchor = new Point(-1);
            defaultBorderValue = new MCvScalar(0, 0, 0);
            paddleSize = new Size(12, 100);
            colorA = new MCvScalar(0, 255, 0);
            contourColor = new MCvScalar(255, 255, 255);
        }
#pragma warning restore CS8618

        private void Form1_Load(object sender, EventArgs e)
        {
            videoCapture = new VideoCapture(0);

            VarianceTrackbar.Value = 50;

            ErodeKernelSizeTrackbar.Value = 5;
            DilateKernelSizeTrackbar.Value = 5;
            ErodeIterationsTrackbar.Value = 2;
            DilateIterationsTrackbar.Value = 2;

            currentFrameBGR = new Mat();
            Mat capturedFrame = CvInvoke.Imread(@"..\..\..\..\..\images\cat.png");
            UpdateCapturedColor(capturedFrame);

            UpdateInRangeBounds();

            contourHeirarchy = new Mat();
            UpdateDilateErode();

            gameMap = new Bitmap(GamePictureBox.Width, GamePictureBox.Height);

            gameGFX = Graphics.FromImage(gameMap);
            ResetGame();

            collisionTimer = Stopwatch.StartNew();

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

            cameraFrame.CopyTo(currentFrameBGR);

            if (IsMirroredCheckbox.Checked)
            {
                CvInvoke.Flip(currentFrameBGR, currentFrameBGR, FlipType.Horizontal);
            }

            // CvInvoke.MedianBlur(currentFrameBGR, currentFrameBGR, 5);

            using var currentFrameHSV = new Mat();
            using var inRangeMat = new Mat();

            CvInvoke.CvtColor(currentFrameBGR, currentFrameHSV, ColorConversion.Bgr2Hsv);

            CvInvoke.InRange(currentFrameHSV, lowerBound, upperBound, inRangeMat);
            InRangeImgBox.Image = inRangeMat;

            CvInvoke.Erode(inRangeMat, inRangeMat, erodeElement, defaultAnchor, ErodeIterationsTrackbar.Value, BorderType.Reflect101, defaultBorderValue);
            ErodeImgBox.Image = inRangeMat;

            CvInvoke.Dilate(inRangeMat, inRangeMat, dilateElement, defaultAnchor, DilateIterationsTrackbar.Value, BorderType.Reflect101, defaultBorderValue);
            DilateImgBox.Image = inRangeMat;

            VectorOfVectorOfPoint contours = new();
            CvInvoke.FindContours(inRangeMat, contours, contourHeirarchy, RetrType.External, ChainApproxMethod.ChainApproxNone);

            using Mat currentFrameClone = currentFrameBGR.Clone();

            if (contours.Size >= 1)
            {
                var contoursList = new List<VectorOfPoint>(contours.Size);
                for (int i = 0; i < contours.Size; i++)
                {
                    contoursList.Add(contours[i]);
                }

                VectorOfPoint leftContour = contoursList[0];
                for (int i = 1; i < contoursList.Count; i++)
                {
                    if (CvInvoke.ContourArea(contoursList[i]) > CvInvoke.ContourArea(leftContour))
                    {
                        leftContour = contoursList[i];
                    }
                }

                var leftMoment = CvInvoke.Moments(leftContour);


                CvInvoke.DrawContours(currentFrameClone, contours, -1, contourColor, thickness: 2);

                Rectangle boundingBox = CvInvoke.BoundingRectangle(leftContour);

                previousLeftPaddlePosition = leftPaddlePosition;
                leftPaddlePosition = new Point(
                    (int)(leftMoment.GravityCenter.X * gameMap.Width / currentFrameHSV.Width),
                    (int)(leftMoment.GravityCenter.Y * gameMap.Height / currentFrameHSV.Height));

                CvInvoke.DrawMarker(currentFrameClone, new Point((int)leftMoment.GravityCenter.X, (int)leftMoment.GravityCenter.Y),
                    colorA, MarkerTypes.Cross, markerSize: 10, thickness: 2);
                CvInvoke.Rectangle(currentFrameClone, boundingBox, colorA, thickness: 2);
            }
            CameraImgBox.Image = currentFrameClone;
        }
        private void UpdateGame()
        {
            if (!isGamePlaying) return;

            previousBallBoundingBox = ballBoundingBox;

            leftPaddleHitbox.Location = leftPaddlePosition;

            var leftXVelocity = leftPaddlePosition.X - previousLeftPaddlePosition.X;
            var leftYVelocity = leftPaddlePosition.Y - previousLeftPaddlePosition.Y;

            var leftHitboxes = new Rectangle[Math.Abs(leftXVelocity) + 1];
            for (int i = 0; i < leftHitboxes.Length - 1; i++)
            {
                float interpolant = i / (float)leftHitboxes.Length;

                leftHitboxes[i] = new Rectangle(
                    (int)(previousLeftPaddlePosition.X * (1 - interpolant) + leftPaddlePosition.X * interpolant),
                    (int)(previousLeftPaddlePosition.Y * (1 - interpolant) + leftPaddlePosition.Y * interpolant),
                    leftPaddleHitbox.Width,
                    leftPaddleHitbox.Height);
            }
            leftHitboxes[^1] = leftPaddleHitbox;

            rightPaddleHitbox.Y = ballBoundingBox.Y - rightPaddleHitbox.Height / 2 + ballBoundingBox.Height / 2;

            var ballHitboxes = new Rectangle[Math.Abs(ballVelocity.X) + 1];
            for (int i = 0; i < ballHitboxes.Length - 1; i++)
            {
                float interpolant = i / (float)ballHitboxes.Length;

                ballHitboxes[i] = new Rectangle(
                    (int)(previousBallBoundingBox.X * (1 - interpolant) + ballBoundingBox.X * interpolant),
                    (int)(previousBallBoundingBox.Y * (1 - interpolant) + ballBoundingBox.Y * interpolant),
                    ballBoundingBox.Width,
                    ballBoundingBox.Height);
            }
            ballHitboxes[^1] = ballBoundingBox;

            ballBoundingBox.X += ballVelocity.X;
            ballBoundingBox.Y += ballVelocity.Y;

            gameGFX.Clear(Color.Black);

            bool hasPlayerHitBall = false;

            for (int i = 0; i < ballHitboxes.Length; i++)
            {
                gameGFX.FillEllipse(Brushes.Red, ballHitboxes[i]);

                if (leftPaddleHitbox.IntersectsWith(ballHitboxes[i]))
                {
                    if (collisionTimer.ElapsedMilliseconds > 500)
                    {
                        hasPlayerHitBall = true;
                        ballVelocity.X = -ballVelocity.X + leftXVelocity;
                        if (ballVelocity.X > 20)
                        {
                            ballVelocity.X = 20;
                        }
                        ballVelocity.Y += leftYVelocity;
                        if (ballVelocity.Y > 20)
                        {
                            ballVelocity.Y = 20;
                        }
                        else if(ballVelocity.Y < -20)
                        {
                            ballVelocity.Y = -20;
                        }
                        collisionTimer.Restart();
                    }
                }
                else if (rightPaddleHitbox.IntersectsWith(ballHitboxes[i]))
                {
                    ballVelocity.X = -Math.Abs(ballVelocity.X);
                    ballBoundingBox.X = rightPaddleHitbox.Left - ballBoundingBox.Width;
                }
            }
            if(!hasPlayerHitBall)
            {
                for (int i = 0; i < leftHitboxes.Length; i++)
                {
                    gameGFX.FillRectangle(Brushes.Red, leftHitboxes[i]);

                    if (ballBoundingBox.IntersectsWith(leftHitboxes[i]))
                    {
                        if (collisionTimer.ElapsedMilliseconds > 500)
                        {
                            ballVelocity.X = -ballVelocity.X + leftXVelocity;
                            if (ballVelocity.X > 20)
                            {
                                ballVelocity.X = 20;
                            }
                            ballVelocity.Y += leftYVelocity;
                            collisionTimer.Restart();
                        }
                    }
                }
            }

            if (ballBoundingBox.Bottom + ballVelocity.Y > gameMap.Height || ballBoundingBox.Y + ballVelocity.Y < 0)
            {
                ballVelocity.Y *= -1;
            }
            if (ballBoundingBox.Right + ballVelocity.X > gameMap.Width || ballBoundingBox.X + ballVelocity.X < 0)
            {
                ResetGame();
            }


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
                ElementShape.Ellipse,
                new Size(ErodeKernelSizeTrackbar.Value, ErodeKernelSizeTrackbar.Value),
                new Point(-1, -1));

            dilateElement = CvInvoke.GetStructuringElement(
                ElementShape.Ellipse,
                new Size(DilateKernelSizeTrackbar.Value, DilateKernelSizeTrackbar.Value),
                new Point(-1, -1));
        }
        private void UpdateCapturedColor(Mat capture)
        {
            CapturedFrameImgBox.Image = capture;

            CvInvoke.CvtColor(capture, capture, ColorConversion.Bgr2Hsv);

            capturedColor = CvInvoke.Mean(capture);

            Mat capturedColorMat = new(100, 100, DepthType.Cv8U, 3);
            capturedColorMat.SetTo(capturedColor);

            var capturedColorMatClone = capturedColorMat.Clone();
            CvInvoke.CvtColor(capturedColorMatClone, capturedColorMatClone, ColorConversion.Hsv2Bgr);

            CapturedColorImgBox.Image = capturedColorMatClone;

            UpdateInRangeBounds();
        }



        #region Events
        private void CaptureImgBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;

            var capturedFrame = CvInvoke.Imread(openFileDialog.FileName);
            UpdateCapturedColor(capturedFrame);
        }
        private void CaptureButton_Click(object sender, EventArgs e) => UpdateCapturedColor(currentFrameBGR);

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
        #endregion Events
    }
}