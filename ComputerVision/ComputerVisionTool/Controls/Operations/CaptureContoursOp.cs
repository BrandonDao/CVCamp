using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace ComputerVisionTool.Controls.Operations
{
    public partial class CaptureContoursOp : UserControl, IOperation
    {
        public CVToolsForm ContainerForm { get; set; }

        private const int ContourThickness = 3;
        private MCvScalar contourColor;

        public CaptureContoursOp(Control parent, Point location, CVToolsForm containerForm)
        {
            Parent = parent;
            Location = location;
            ContainerForm = containerForm;

            contourColor = new MCvScalar(0, 255, 0);

            InitializeComponent();

            UpdateAll();
        }


        public void UpdateAll()
        {
            InputImg.UpdateNamedInputs();
            VisualInputImg.UpdateNamedInputs();
            UpdateOutput();
        }

        private void UpdateOutput()
        {
            try
            {
                using VectorOfVectorOfPoint contours = new();
                using Mat heirarchy = new();
                Mat outputMat = VisualInputImg.Mat!.Clone();

                CvInvoke.FindContours(InputImg.Mat, contours, heirarchy, RetrType.External, ChainApproxMethod.ChainApproxNone);
                CvInvoke.DrawContours(outputMat, contours, contourIdx: -1, contourColor, thickness: ContourThickness);

                OutputImg.Mat.Dispose();
                OutputImg.Mat = outputMat;
                OutputImg.UpdateImage();
            }
            catch { }
        }
    }
}