using Emgu.CV;

namespace ComputerVisionTool.Controls.CustomControls
{
    public partial class ImageOutput : UserControl
    {
        public Mat Mat { get; set; }
        public OperationInfo? OpInfo { get; set; }

        public ImageOutput()
        {
            InitializeComponent();

            Mat = new Mat();
        }

        public void UpdateImage()
        {
            ImageBox.Image = Mat;
        }

        private void NameTextbox_TextChanged(object sender, EventArgs e)
        {
            if (!NameManager.NamedInputsByImage.ContainsKey(this))
            {
                NameManager.NamedInputsByImage.Add(this, new NamedInput(NameTextbox.Text, this));
            }
            else
            {
                NameManager.NamedInputsByImage[this].Name = NameTextbox.Text;
            }

            ((Form1)Parent.Parent).UpdateAll();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel) return;

            if (NameTextbox.Text.Length > 0)
            {
                saveFileDialog.FileName = NameTextbox.Text;
            }

            try
            {
                CvInvoke.Imwrite(saveFileDialog.FileName, Mat);
            }
            catch { }
        }
    }
}
