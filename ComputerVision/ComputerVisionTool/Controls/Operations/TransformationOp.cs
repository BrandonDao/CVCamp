using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace ComputerVisionTool.Controls.Operations
{
    public partial class TransformationOp : UserControl, IOperation
    {

        public CVToolsForm ContainerForm { get; set; }

        public TransformationOp(Control parent, Point location, CVToolsForm containerForm)
        {
            Parent = parent;
            Location = location;
            ContainerForm = containerForm;

            InitializeComponent();
        }

        public void UpdateAll()
        {
            InputImg.UpdateNamedInputs();
            ContourInputImg.UpdateNamedInputs();
            UpdateOutput();
        }

        private void UpdateOutput()
        {
            try
            {
                using VectorOfVectorOfPoint contours = new();
                using Mat heirarchy = new();
                CvInvoke.FindContours(ContourInputImg.Mat, contours, heirarchy, RetrType.External, ChainApproxMethod.ChainApproxNone);
                CvInvoke.ApproxPolyDP(contours[0], contours[0], EpsilonTrackbar.Value, closed: true);

                ContourOutputImg.Mat.Dispose();

                int contourIndex = 0;
                for (int i = 1; i < contours.Size; i++)
                {
                    if (CvInvoke.ContourArea(contours[i]) > CvInvoke.ContourArea(contours[contourIndex]))
                    {
                        contourIndex = i;
                    }
                }

                var clone = InputImg.Mat!.Clone();
                CvInvoke.DrawContours(clone, contours, contourIndex, new MCvScalar(0, 255, 0), thickness: 4);

                ContourOutputImg.Mat.Dispose();
                ContourOutputImg.Mat = clone;
                ContourOutputImg.UpdateImage();

                int pt1Index = 0;
                for(int i = 1; i < contours.Size; i++)
                {
                    if (Math.Pow(0 - contours[contourIndex][i].X, 2) + Math.Pow(0 - contours[contourIndex][i].Y, 2)
                        < Math.Pow(0 - contours[contourIndex][pt1Index].X, 2) + Math.Pow(0 - contours[contourIndex][pt1Index].Y, 2))
                    {
                        pt1Index = i;
                    }
                }

                CvInvoke.WarpPerspective(
                    InputImg.Mat!,
                    OutputImg.Mat,
                    CvInvoke.GetPerspectiveTransform(
                        new PointF[] { contours[contourIndex][pt1Index], contours[contourIndex][(pt1Index + 1) % 4], contours[contourIndex][(pt1Index + 2) % 4], contours[contourIndex][(pt1Index + 3) % 4] },
                        new PointF[] { new Point(0, 0), new Point(InputImg.Mat!.Width, 0), new Point(InputImg.Mat.Width, InputImg.Mat.Height), new Point(0, InputImg.Mat.Height) }
                    ),
                    InputImg.Mat.Size,
                    warpType: Warp.Default);


                OutputImg.UpdateImage();
            }
            catch { }
        }
    }
}