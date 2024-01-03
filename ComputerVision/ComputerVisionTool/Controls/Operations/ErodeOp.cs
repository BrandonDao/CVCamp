using Emgu.CV;
using Emgu.CV.Structure;

namespace ComputerVisionTool.Controls.Operations
{
    public partial class ErodeOp : UserControl, IOperation
    {
        public CVToolsForm ContainerForm { get; set; }

        private Point defaultAnchor;
        private Mat element;
        private MCvScalar defaultBorderValue;

        public ErodeOp(Control parent, Point location, CVToolsForm containerForm)
        {
            Parent = parent;
            Location = location;
            ContainerForm = containerForm;

            defaultAnchor = new Point(-1, -1);
            defaultBorderValue = new MCvScalar(0, 0, 0);

            InitializeComponent();
        }


        public void UpdateAll()
        {
            InputImg.UpdateNamedInputs();
            UpdateOutput();
        }

        private void UpdateElement()
        {
            element = CvInvoke.GetStructuringElement(
                Emgu.CV.CvEnum.ElementShape.Rectangle,
                new Size(KernelSizeTrackbar.Value, KernelSizeTrackbar.Value),
                defaultAnchor);

            UpdateOutput();
        }

        private void UpdateOutput()
        {
            try
            {
                CvInvoke.Erode(
                    InputImg.Mat,
                    OutputImg.Mat,
                    element,
                    defaultAnchor,
                    IterationsTrackbar.Value,
                    Emgu.CV.CvEnum.BorderType.Reflect101,
                    defaultBorderValue);
            }
            catch { }

            OutputImg.UpdateImage();
        }

        private void KernelSizeTrackbar_Scroll(object sender, EventArgs e) => UpdateElement();
        private void IterationsTrackbar_Scroll(object sender, EventArgs e) => UpdateOutput();
    }
}
