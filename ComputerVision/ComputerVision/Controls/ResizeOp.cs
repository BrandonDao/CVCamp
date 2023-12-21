using Emgu.CV;
using Emgu.CV.UI;

namespace ComputerVision.Controls
{
    public partial class ResizeOp : UserControl
    {
        struct InterType
        {
            public string Name;

            public Emgu.CV.CvEnum.Inter Type;

            public InterType(string name, Emgu.CV.CvEnum.Inter type)
            {
                Name = name;
                Type = type;
            }

            public override readonly string ToString() => Name;
        }

        Mat inMat;
        readonly Mat outMat;

        public ResizeOp()
        {
            InitializeComponent();

            inMat = new Mat();
            outMat = new Mat();

            OpComboBox.Items.AddRange(new object[]
            {
                new InterType("Linear", Emgu.CV.CvEnum.Inter.Linear),
                new InterType("Nearest", Emgu.CV.CvEnum.Inter.Nearest),
            });

            OpComboBox.SelectedIndex = 0;
        }

        private void AImgBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;

            if (OpComboBox.SelectedIndex == -1) OpComboBox.SelectedIndex = 0;

            ImageBox imgBox = (ImageBox)sender;

            inMat = CvInvoke.Imread(openFileDialog.FileName);

            imgBox.Image = inMat;

            UpdateOutput();
        }

        private void UpdateOutput()
        {
            var interType = (InterType)OpComboBox.SelectedItem;

            try
            {
                CvInvoke.Resize(inMat, outMat, new Size(int.Parse(WidthTextbox.Text), int.Parse(HeightTextbox.Text)), interpolation: interType.Type);
                BImgBox.Image = outMat;
            }
            catch { }
        }

        private void OpComboBox_SelectedIndexChanged(object sender, EventArgs e)
            => UpdateOutput();

        private void WidthTextbox_TextChanged(object sender, EventArgs e)
            => UpdateOutput();

        private void HeightTextbox_TextChanged(object sender, EventArgs e)
            => UpdateOutput();

        private void SaveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "image.png";

            if (saveFileDialog.ShowDialog() == DialogResult.Cancel) return;

            try
            {
                CvInvoke.Imwrite(saveFileDialog.FileName, outMat);
            }
            catch { }
        }
    }
}
