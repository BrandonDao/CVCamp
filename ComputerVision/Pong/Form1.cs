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

        private Point leftPaddlePosition;
        private Point rightPaddlePosition;

        private Stopwatch collisionTimer;

        private Bitmap gameMap;
        private Graphics gameGFX;

        private readonly MCvScalar colorA;
        private readonly MCvScalar colorB;
        private readonly MCvScalar contourColor;

        private readonly Point defaultAnchor;
        private readonly MCvScalar defaultBorderValue;

        private bool isGamePlaying;

        private const int ballSize = 15;
        private const int defaultBallVelocity = 6;
        private Rectangle ballBoundingBox;
        private Point ballVelocity;

        private const int paddleDistFromSide = 16;
        private readonly Size paddleSize;

        private Rectangle previousLeftPaddleHitbox;
        private Rectangle leftPaddleHitbox;

        private Rectangle rightPaddleHitbox;
        private Rectangle previousRightPaddleHitbox;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Form1()
        {
            InitializeComponent();

            defaultAnchor = new Point(-1);
            defaultBorderValue = new MCvScalar(0, 0, 0);
            paddleSize = new Size(12, 100);
            colorA = new MCvScalar(0, 255, 0);
            colorB = new MCvScalar(255, 0, 0);
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
            Mat capturedFrame = CvInvoke.Imread(@"..\..\..\..\..\images\defaultPaddleColor.png");
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
            
            if (contours.Size >= 2)
            {
                var contoursList = new List<VectorOfPoint>(contours.Size);
                for(int i = 0; i < contours.Size; i++)
                {
                    contoursList.Add(contours[i]);
                }

                contoursList.Sort(new Comparison<VectorOfPoint>((a, b) =>
                {
                    var aArea = CvInvoke.ContourArea(a);
                    var bArea = CvInvoke.ContourArea(b);

                    return aArea > bArea ? 1 : (aArea == bArea ? 0 : 1);
                }));

                var leftContour = contoursList[0];
                var rightContour = contoursList[1];

                var leftMoment = CvInvoke.Moments(leftContour);
                var rightMoment = CvInvoke.Moments(rightContour);

                if (leftMoment.GravityCenter.X > rightMoment.GravityCenter.X)
                {
                    var tempContour = leftContour;
                    var tempMoment = leftMoment;

                    leftContour = rightContour;
                    leftMoment = rightMoment;

                    rightContour = tempContour;
                    rightMoment = tempMoment;
                }

                CvInvoke.DrawContours(currentFrameClone, contours, -1, contourColor, thickness: 2);

                Rectangle boundingBox = CvInvoke.BoundingRectangle(leftContour);

                leftPaddlePosition = new Point(
                    (int)(leftMoment.GravityCenter.X * gameMap.Width / currentFrameHSV.Width),
                    (int)(leftMoment.GravityCenter.Y * gameMap.Height / currentFrameHSV.Height));

                CvInvoke.DrawMarker(currentFrameClone, new Point((int)leftMoment.GravityCenter.X, (int)leftMoment.GravityCenter.Y),
                    colorA, MarkerTypes.Cross, markerSize: 10, thickness: 2);
                CvInvoke.Rectangle(currentFrameClone, boundingBox, colorA, thickness: 2);


                boundingBox = CvInvoke.BoundingRectangle(rightContour);

                rightPaddlePosition = new Point(
                    (int)(rightMoment.GravityCenter.X * gameMap.Width / currentFrameHSV.Width),
                    (int)(rightMoment.GravityCenter.Y * gameMap.Height / currentFrameHSV.Height));

                CvInvoke.DrawMarker(currentFrameClone, new Point((int)rightMoment.GravityCenter.X, (int)rightMoment.GravityCenter.Y),
                    colorB, MarkerTypes.Cross, markerSize: 10, thickness: 2);
                CvInvoke.Rectangle(currentFrameClone, boundingBox, colorB, thickness: 2);
            }
            CameraImgBox.Image = currentFrameClone;
        }
        private void UpdateGame()
        {
            if (!isGamePlaying) return;

            previousLeftPaddleHitbox = leftPaddleHitbox;
            previousRightPaddleHitbox = rightPaddleHitbox;

            leftPaddleHitbox.X = leftPaddlePosition.X - leftPaddleHitbox.Width / 2;
            leftPaddleHitbox.Y = leftPaddlePosition.Y - leftPaddleHitbox.Height / 2;

            rightPaddleHitbox.X = rightPaddlePosition.X - rightPaddleHitbox.Width / 2;
            rightPaddleHitbox.Y = rightPaddlePosition.Y - rightPaddleHitbox.Height / 2;

            int leftXVelocity = leftPaddleHitbox.X - previousLeftPaddleHitbox.X;
            int leftYVelocity = leftPaddleHitbox.Y - previousLeftPaddleHitbox.Y;

            int rightXVelocity = rightPaddleHitbox.X - previousRightPaddleHitbox.X;
            int rightYVelocity = rightPaddleHitbox.Y - previousRightPaddleHitbox.Y;

            var leftHitboxes = new Rectangle[Math.Abs(leftXVelocity) / 10 + 1];
            for(int i = 0; i < leftHitboxes.Length - 1; i++)
            {
                float interpolant = i / (float)leftHitboxes.Length;

                leftHitboxes[i] = new Rectangle(
                    (int)(previousLeftPaddleHitbox.X * (1 - interpolant) + leftPaddleHitbox.X * interpolant),
                    (int)(previousLeftPaddleHitbox.Y * (1 - interpolant) + leftPaddleHitbox.Y * interpolant),
                    leftPaddleHitbox.Width,
                    leftPaddleHitbox.Height);
            }
            leftHitboxes[^1] = leftPaddleHitbox;

            var rightHitboxes = new Rectangle[Math.Abs(rightXVelocity) / 10 + 1];
            for (int i = 0; i < rightHitboxes.Length - 1; i++)
            {
                float interpolant = i / (float)leftHitboxes.Length;

                rightHitboxes[i] = new Rectangle(
                    (int)(previousRightPaddleHitbox.X * (1 - interpolant) + rightPaddleHitbox.X * interpolant),
                    (int)(previousRightPaddleHitbox.Y * (1 - interpolant) + rightPaddleHitbox.Y * interpolant),
                    rightPaddleHitbox.Width,
                    rightPaddleHitbox.Height);
            }
            rightHitboxes[^1] = rightPaddleHitbox;

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

            gameGFX.Clear(Color.Black);

            for (int i = 0; i < leftHitboxes.Length; i++)
            {
                gameGFX.FillRectangle(Brushes.Red, leftHitboxes[i]);

                if (ballBoundingBox.IntersectsWith(leftHitboxes[i]))
                {
                    if (collisionTimer.ElapsedMilliseconds > 500)
                    {
                        ballVelocity.X = -ballVelocity.X + leftXVelocity;
                        ballVelocity.Y += leftYVelocity;
                        collisionTimer.Restart();
                    }
                }
            }
            for (int i = 0; i < rightHitboxes.Length; i++)
            {
                gameGFX.FillRectangle(Brushes.Red, rightHitboxes[i]);

                if (ballBoundingBox.IntersectsWith(rightHitboxes[i]))
                {
                    if (collisionTimer.ElapsedMilliseconds > 500)
                    {
                        ballVelocity.X = -ballVelocity.X + rightXVelocity;
                        ballVelocity.Y += rightYVelocity;
                        collisionTimer.Restart();
                    }
                }
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