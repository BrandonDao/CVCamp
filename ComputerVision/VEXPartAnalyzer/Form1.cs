using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace VEXPartAnalyzer
{
    public partial class Form1 : Form
    {
        VideoCapture videoCapture;

        Mat erodeElement;
        Point noAnchor;

        public Form1()
        {
            videoCapture = new VideoCapture(1);

            noAnchor = new Point(-1);
            erodeElement = CvInvoke.GetStructuringElement(ElementShape.Cross, new Size(3, 3), noAnchor);

            InitializeComponent();

            Application.Idle += OnIdle;
        }

        public void OnIdle(object? sender, EventArgs e)
        {
            using Mat cameraOwnedFrame = videoCapture.QueryFrame();

            if (cameraOwnedFrame == null) return;

            using Mat frame = cameraOwnedFrame.Clone();

            CvInvoke.Flip(frame, frame, FlipType.Both);

            CameraImgBox.Image?.Dispose();
            CameraImgBox.Image = frame.Clone();

            using Mat partInRange = new();
            using Mat frameHSV = new();

            CvInvoke.CvtColor(frame, frameHSV, ColorConversion.Bgr2Hsv);
            CvInvoke.InRange(frameHSV, (ScalarArray)new MCvScalar(0, 0, 60), (ScalarArray)new MCvScalar(179, 45, 255), partInRange);
            CvInvoke.BitwiseNot(partInRange, partInRange);

            CvInvoke.Erode(partInRange, partInRange, erodeElement, noAnchor, 2, BorderType.Reflect101, new MCvScalar(0, 0, 0));

            VectorOfVectorOfPoint contours = new();
            Mat hierarchy = new();

            CvInvoke.FindContours(partInRange, contours, hierarchy, RetrType.External, ChainApproxMethod.ChainApproxNone);

            if (contours.Size == 0) return;

            int contourIdx = 0;
            for(int i = 1; i < contours.Size; i++)
            {
                if (CvInvoke.ContourArea(contours[i]) > CvInvoke.ContourArea(contours[contourIdx]))
                {
                    contourIdx = i;
                }
            }

            double min = 0;
            double max = 0;

            for (int i = 1; i < contours[contourIdx].Size / 5; i++)
            {
                if(con)
            }


            CvInvoke.CvtColor(partInRange, partInRange, ColorConversion.Gray2Bgr);

            CvInvoke.DrawContours(partInRange, contours, -1, new MCvScalar(0, 0, 255), thickness: 3);

            PartInRange.Image?.Dispose();
            PartInRange.Image = partInRange.Clone();

        }
    }
}