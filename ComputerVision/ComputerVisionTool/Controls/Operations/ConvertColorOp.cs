using Emgu.CV;
using Emgu.CV.CvEnum;

namespace ComputerVisionTool.Controls.Operations
{
    public partial class ConvertColorOp : UserControl, IOperation
    {
        public struct OpType
        {
            public string Name;
            public ColorConversion Conversion;

            public OpType(string name, ColorConversion conversion)
            {
                Name = name;
                Conversion = conversion;
            }

            public override readonly string ToString() => Name;
        }

        public OperationInfo OpInfo { get; }
        public CVToolsForm ContainerForm { get; set; }

        public ConvertColorOp(Control parent, Point location, CVToolsForm containerForm)
        {
            Parent = parent;
            Location = location;
            ContainerForm = containerForm;

            InitializeComponent();

            OpInfo = new OperationInfo();

            OpComboBox.Items.AddRange(new object[]
            {
                new OpType("BGR -> HSV", ColorConversion.Bgr2Hsv),
                new OpType("HSV -> BGR", ColorConversion.Hsv2Bgr),
                new OpType("BGR -> Grayscale", ColorConversion.Bgr2Gray),
                new OpType("Grayscale -> BGR", ColorConversion.Gray2Bgr),
            });

            OpComboBox.SelectedIndex = 0;
        }

        public void UpdateAll()
        {
            InputImg.UpdateNamedInputs();
            UpdateOutput();
        }

        private void OpComboBox_SelectedIndexChanged(object sender, EventArgs e) => UpdateAll();

        private void UpdateOutput()
        {
            try
            {
                CvInvoke.CvtColor(InputImg.Mat, OutputImg.Mat, ((OpType)OpComboBox.SelectedItem).Conversion);
            }
            catch { }
            OutputImg.UpdateImage();
        }
    }
}
