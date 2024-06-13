using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace PaperPlatformer
{
    public partial class Form1 : Form
    {
        private readonly Mat erodeElement;
        private readonly Mat dilateElement;
        private readonly Point defaultAnchor;
        private readonly MCvScalar defaultBorderValue;
        private readonly VideoCapture videoCapture;

        private VectorOfVectorOfPoint contours;
        private List<Rectangle> savedBoundingBoxes;
        private Rectangle playerBoundingBox;

        private PointF[] cameraFrameBounds;

        private sbyte xVelocity;
        private sbyte yVelocity;

        private bool isLeftDown;
        private bool isRightDown;
        private bool isJumping;
        private bool isGrounded;

        public Form1()
        {
            InitializeComponent();

            defaultAnchor = new Point(-1, -1);
            defaultBorderValue = new MCvScalar(0, 255, 0);
            erodeElement = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(5, 5), defaultAnchor);
            dilateElement = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(5, 5), defaultAnchor);

            videoCapture = new VideoCapture(1);

            savedBoundingBoxes = new List<Rectangle>();
            playerBoundingBox = new Rectangle(320, 0, 25, 25);

            Mat? cameraFrame = null;
            while (cameraFrame == null)
            {
                cameraFrame = videoCapture.QueryFrame();
            }
            cameraFrameBounds = new PointF[]
            {
                new Point(0, 0),
                new Point(0, cameraFrame.Height),
                new Point(cameraFrame.Width, cameraFrame.Height),
                new Point(cameraFrame.Width, 0)
            };
            cameraFrame.Dispose();

            Application.Idle += OnIdle;
        }

        private void OnIdle(object? sender, EventArgs e)
        {
            using Mat cameraFrame = videoCapture.QueryFrame();

            if (cameraFrame == null) return;

            using Mat frame = cameraFrame.Clone();

            CvInvoke.Flip(frame, frame, FlipType.Both);

            CameraInputImgBox.Image?.Dispose();
            CameraInputImgBox.Image = frame;

            using Mat frameHSV = new();
            using Mat paperInRange = new();

            CvInvoke.CvtColor(frame, frameHSV, ColorConversion.Bgr2Hsv);
            CvInvoke.InRange(frameHSV, (ScalarArray)new MCvScalar(0, 0, 145), (ScalarArray)new MCvScalar(179, 70, 255), paperInRange);

            InRangeImgBox.Image?.Dispose();
            InRangeImgBox.Image = paperInRange.Clone();

            CvInvoke.Erode(paperInRange, paperInRange, erodeElement, defaultAnchor, iterations: 4, BorderType.Reflect101, defaultBorderValue);
            CvInvoke.Dilate(paperInRange, paperInRange, dilateElement, defaultAnchor, iterations: 6, BorderType.Reflect101, defaultBorderValue);
            CvInvoke.Erode(paperInRange, paperInRange, erodeElement, defaultAnchor, iterations: 2, BorderType.Reflect101, defaultBorderValue);

            DilatedErodedImgBox.Image?.Dispose();
            DilatedErodedImgBox.Image = paperInRange.Clone();

            contours?.Dispose();
            contours = new();

            using VectorOfVectorOfPoint paperContour = new();
            using Mat heirarchy = new();

            CvInvoke.FindContours(paperInRange, paperContour, heirarchy, RetrType.External, ChainApproxMethod.ChainApproxNone);

            int contourIdx = 0;
            double largestContourArea = CvInvoke.ContourArea(paperContour[contourIdx]);
            for (int i = 1; i < paperContour.Size; i++)
            {
                double currentArea = CvInvoke.ContourArea(paperContour[i]);
                if (largestContourArea > currentArea) continue;
                
                contourIdx = i;
                largestContourArea = currentArea;
            }

            CvInvoke.ApproxPolyDP(paperContour[contourIdx], paperContour[contourIdx], EpsilonTrackbar.Value, closed: true);

            using Mat contourMat = frame.Clone();

            CvInvoke.DrawContours(contourMat, paperContour, contourIdx, defaultBorderValue, thickness: 3);
            PaperContourImgBox.Image?.Dispose();
            PaperContourImgBox.Image = contourMat.Clone();

            using Mat warpedPaper = new();

            if (paperContour[contourIdx].Size == 4)
            {
                int topLeftIdx = 0;
                double topLeftIdxDistance = Math.Pow(paperContour[contourIdx][topLeftIdx].X, 2) + Math.Pow(paperContour[contourIdx][topLeftIdx].Y, 2);

                for (int i = 1; i < paperContour[contourIdx].Size; i++)
                {
                    double currentDistance = Math.Pow(paperContour[contourIdx][i].X, 2) + Math.Pow(paperContour[contourIdx][i].Y, 2);
                    
                    if (topLeftIdxDistance < currentDistance) continue;
                    
                    topLeftIdx = i;
                }

                Mat perspectiveTransform = CvInvoke.GetPerspectiveTransform(
                        new PointF[]
                        {
                            paperContour[contourIdx][topLeftIdx],
                            paperContour[contourIdx][(topLeftIdx + 1) % 4],
                            paperContour[contourIdx][(topLeftIdx + 2) % 4],
                            paperContour[contourIdx][(topLeftIdx + 3) % 4]
                        },
                        cameraFrameBounds
                    );

                CvInvoke.WarpPerspective(
                    frame,
                    warpedPaper,
                    perspectiveTransform,
                    frame.Size,
                    warpType: Warp.Default);

                PerspectiveImgBox.Image?.Dispose();
                PerspectiveImgBox.Image = warpedPaper.Clone();

                using Mat binaryWarpedPaper = new();
                CvInvoke.ExtractChannel(warpedPaper, binaryWarpedPaper, 2);
                CvInvoke.Threshold(binaryWarpedPaper, binaryWarpedPaper, 100, 255, ThresholdType.BinaryInv);

                BinInvThresholdImgBox.Image?.Dispose();
                BinInvThresholdImgBox.Image = binaryWarpedPaper.Clone();

                CvInvoke.FindContours(binaryWarpedPaper, contours, heirarchy, RetrType.External, ChainApproxMethod.ChainApproxNone);

                using Mat warpedPaperCopy = warpedPaper.Clone();

                for (int i = 0; i < contours.Size; i++)
                {
                    Rectangle boundingRect = CvInvoke.BoundingRectangle(contours[i]);
                    CvInvoke.Rectangle(warpedPaperCopy, boundingRect, defaultBorderValue, thickness: 3);
                }

                BoundingBoxesImgBox.Image?.Dispose();
                BoundingBoxesImgBox.Image = warpedPaperCopy.Clone();


                savedBoundingBoxes = new List<Rectangle>(capacity: contours.Size);

                for (int i = 0; i < contours.Size; i++)
                {
                    savedBoundingBoxes.Add(CvInvoke.BoundingRectangle(contours[i]));
                }

                if (savedBoundingBoxes.Count > 0)
                {
                    yVelocity += 2;

                    if (yVelocity > 20)
                    {
                        yVelocity = 20;
                    }
                    if (isJumping && isGrounded)
                    {
                        isGrounded = false;
                        yVelocity -= 40;
                    }

                    playerBoundingBox.Y += yVelocity;

                    if (playerBoundingBox.Y > warpedPaper.Height)
                    {
                        playerBoundingBox.Y = 0;
                    }
                    else if (playerBoundingBox.Y < 0)
                    {
                        playerBoundingBox.Y = warpedPaper.Height;
                    }

                    if (isLeftDown)
                    {
                        xVelocity -= 2;

                        if (xVelocity < -10)
                        {
                            xVelocity = -10;
                        }
                    }
                    else if (isRightDown)
                    {
                        xVelocity += 2;

                        if (xVelocity > 10)
                        {
                            xVelocity = 10;
                        }
                    }
                    else
                    {
                        xVelocity /= 2;
                    }

                    playerBoundingBox.X += xVelocity;
                    if (playerBoundingBox.X < 0)
                    {
                        playerBoundingBox.X = warpedPaper.Width;
                    }
                    else if (playerBoundingBox.X > warpedPaper.Width)
                    {
                        playerBoundingBox.X = 0;
                    }


                    foreach (var boundingBox in savedBoundingBoxes)
                    {
                        CvInvoke.Rectangle(warpedPaper, boundingBox, defaultBorderValue, thickness: 3);

                        if (boundingBox.IntersectsWith(playerBoundingBox))
                        {
                            isGrounded = true;
                            playerBoundingBox.Y = boundingBox.Top - playerBoundingBox.Height;
                        }
                    }

                    CvInvoke.DrawMarker(warpedPaper,
                        new Point(
                            playerBoundingBox.X + playerBoundingBox.Width / 2,
                            playerBoundingBox.Y + playerBoundingBox.Height / 2),
                        defaultBorderValue, MarkerTypes.Square, markerSize: 20, thickness: 5);

                    CvInvoke.WarpPerspective(warpedPaper,
                        warpedPaper,
                        perspectiveTransform,
                        frame.Size,
                        warpType: Warp.InverseMap);

                    warpedPaper.CopyTo(frame, warpedPaper);

                    GameImgBox.Image?.Dispose();
                    GameImgBox.Image = frame.Clone();
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                isLeftDown = true;
            }
            if(e.KeyCode == Keys.D)
            {
                isRightDown = true;
            }
            if (e.KeyCode == Keys.Space)
            {
                isJumping = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                isLeftDown = false;
            }
            if(e.KeyCode == Keys.D)
            {
                isRightDown = false;
            }
            if (e.KeyCode == Keys.Space)
            {
                isJumping = false;
            }
        }
    }
}