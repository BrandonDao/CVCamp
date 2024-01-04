using Emgu.CV;

namespace ComputerVisionTool.Controls.Operations
{
    public partial class RotateFlipOp : UserControl, IOperation
    {
        public struct OpType
        {
            public string Name;
            public Action<Mat, Mat> Operation;

            public OpType(string name, Action<Mat, Mat> operation)
            {
                Name = name;
                Operation = operation;
            }

            public override readonly string ToString() => Name;
        }


        public CVToolsForm ContainerForm { get; set; }

        public RotateFlipOp(Control parent, Point location, CVToolsForm containerForm)
        {
            Parent = parent;
            Location = location;
            ContainerForm = containerForm;

            InitializeComponent();

            OpComboBox.Items.AddRange(new object[]
            {
                new OpType("Rotate 90° C", (a,b)  => CvInvoke.Rotate(a,b, Emgu.CV.CvEnum.RotateFlags.Rotate90Clockwise)),
                new OpType("Rotate 90° CC", (a,b)  => CvInvoke.Rotate(a,b, Emgu.CV.CvEnum.RotateFlags.Rotate90CounterClockwise)),
                new OpType("Rotate 180°", (a,b)  => CvInvoke.Rotate(a,b, Emgu.CV.CvEnum.RotateFlags.Rotate180)),
                new OpType("Flip Horizontal", (a,b)  => CvInvoke.Flip(a,b, Emgu.CV.CvEnum.FlipType.Horizontal)),
                new OpType("Flip Vertical", (a,b)  => CvInvoke.Flip(a,b, Emgu.CV.CvEnum.FlipType.Vertical)),
                new OpType("Flip Both", (a,b)  => CvInvoke.Flip(a,b, Emgu.CV.CvEnum.FlipType.Both)),
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
            ((OpType)OpComboBox.SelectedItem).Operation.Invoke(InputImg.Mat!, OutputImg.Mat);
            OutputImg.UpdateImage();
        }

        private void OpComboBox_SelectedIndexChanged(object sender, EventArgs e) => UpdateOutput();
    }
}