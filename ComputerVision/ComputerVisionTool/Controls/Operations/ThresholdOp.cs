using Emgu.CV;
using Emgu.CV.CvEnum;

namespace ComputerVisionTool.Controls.Operations
{
    public partial class ThresholdOp : UserControl, IOperation
    {
        public struct OpType
        {
            public string Name;
            public Action<Mat, Mat, int, int> Operation;

            public OpType(string name, Action<Mat, Mat, int, int> operation)
            {
                Name = name;
                Operation = operation;
            }

            public override readonly string ToString() => Name;
        }



        public CVToolsForm ContainerForm { get; set; }

        public ThresholdOp(Control parent, Point location, CVToolsForm containerForm)
        {
            Parent = parent;
            Location = location;
            ContainerForm = containerForm;

            InitializeComponent();

            OpComboBox.Items.AddRange(new object[]
            {
                new OpType("Binary",      (a,b,c,d) => {CvInvoke.Threshold(a,b,c,d,ThresholdType.Binary); MaxValueLabel.Show(); MaxValueTrackbar.Show(); }),
                new OpType("Binary Inv",  (a,b,c,d) => {CvInvoke.Threshold(a,b,c,d,ThresholdType.BinaryInv); MaxValueLabel.Show(); MaxValueTrackbar.Show(); }),
                new OpType("To Zero",     (a,b,c,d) => {CvInvoke.Threshold(a,b,c,d,ThresholdType.ToZero); MaxValueLabel.Hide(); MaxValueTrackbar.Hide(); }),
                new OpType("To Zero Inv", (a,b,c,d) => {CvInvoke.Threshold(a,b,c,d,ThresholdType.ToZeroInv); MaxValueLabel.Hide(); MaxValueTrackbar.Hide(); }),
                new OpType("Truncate",    (a,b,c,d) => {CvInvoke.Threshold(a,b,c,d,ThresholdType.Trunc); MaxValueLabel.Hide(); MaxValueTrackbar.Hide(); }),
            });

            OpComboBox.SelectedIndex = 0;
        }

        public void UpdateAll()
        {
            InputImg.UpdateNamedInputs();
            UpdateOutput();
        }

        private void UpdateOutput()
        {
            try
            {
                ((OpType)OpComboBox.SelectedItem).Operation.Invoke(InputImg.Mat!, OutputImg.Mat, ThresholdTrackbar.Value, MaxValueTrackbar.Value);
            }
            catch { }
            OutputImg.UpdateImage();
        }

        private void OpComboBox_SelectedIndexChanged(object sender, EventArgs e) => UpdateOutput();
        private void ThresholdTrackbar_Scroll(object sender, EventArgs e) => UpdateOutput();
        private void MaxValueTrackbar_Scroll(object sender, EventArgs e) => UpdateOutput();
    }
}
