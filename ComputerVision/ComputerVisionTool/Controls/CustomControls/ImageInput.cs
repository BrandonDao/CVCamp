using Emgu.CV;

namespace ComputerVisionTool.Controls.CustomControls
{
    public partial class ImageInput : UserControl
    {
        public Mat? Mat { get; private set; }
        public OperationInfo? OpInfo { get; set; }
        public Action? CallWhenChanged { get; set; }

        public ImageInput()
        {
            InitializeComponent();

            Mat = new Mat();
        }

        public void UpdateNamedInputs()
        {
            NamedInputComboBox.Items.Clear();
            NamedInputComboBox.Items.Add(NamedInput.NoInput);

            foreach (NamedInput namedInput in NameManager.NamedInputsByImage.Values)
            {
                if (namedInput.ImageOutput.OpInfo!.ID == OpInfo!.ID) continue;

                NamedInputComboBox.Items.Add(namedInput);
            }
        }

        private void ImageBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;

            Mat = CvInvoke.Imread(openFileDialog.FileName);

            ImageBox.Image = Mat;
            CallWhenChanged!.Invoke();
        }

        private void NamedInputComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mat = ((NamedInput)NamedInputComboBox.SelectedItem).ImageOutput.Mat;
            ImageBox.Image = Mat;
            CallWhenChanged!.Invoke();
        }
    }
}