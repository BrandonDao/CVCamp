using ComputerVisionTool;
using ComputerVisionTool.Controls.Operations;
using Emgu.CV;
using Emgu.CV.Structure;

namespace ComputerVision.Controls
{
    public partial class InRangeOp : UserControl, IOperation
    {
        public CVToolsForm ContainerForm { get; set; }

        private ScalarArray lowerBound;
        private ScalarArray upperBound;

        public InRangeOp(Control parent, Point location, CVToolsForm containerForm)
        {
            Parent = parent;
            Location = location;
            ContainerForm = containerForm;

            InitializeComponent();
        }

        public void UpdateAll()
        {
            InputImg.UpdateNamedInputs();
            UpdateOutput();
        }

        private void UpdateLowerBound()
        {
            lowerBound = (ScalarArray)new MCvScalar(TLTrackbar.Value, MLTrackbar.Value, BLTrackbar.Value);
            UpdateOutput();
        }

        private void UpdateUpperBound()
        {
            upperBound = (ScalarArray)new MCvScalar(TRTrackbar.Value, MRTrackbar.Value, BRTrackbar.Value);
            UpdateOutput();
        }

        private void UpdateOutput()
        {
            try
            {
                CvInvoke.InRange(InputImg.Mat, lowerBound, upperBound, OutputImg.Mat);
            }
            catch { }

            OutputImg.UpdateImage();
        }

        private void TLTrackbar_Scroll(object sender, EventArgs e) => UpdateLowerBound();
        private void MLTrackbar_Scroll(object sender, EventArgs e) => UpdateLowerBound();
        private void BLTrackbar_Scroll(object sender, EventArgs e) => UpdateLowerBound();

        private void TRTrackbar_Scroll(object sender, EventArgs e) => UpdateUpperBound();
        private void MRTrackbar_Scroll(object sender, EventArgs e) => UpdateUpperBound();
        private void BRTrackbar_Scroll(object sender, EventArgs e) => UpdateUpperBound();
    }
}