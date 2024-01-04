using Emgu.CV;

namespace ComputerVisionTool.Controls.Operations
{
    public partial class ROIOp : UserControl, IOperation
    {
        public CVToolsForm ContainerForm { get; set; }

        public ROIOp(Control parent, Point location, CVToolsForm containerForm)
        {
            Parent = parent;
            Location = location;
            ContainerForm = containerForm;

            InitializeComponent();
        }

        public void UpdateAll()
        {
            InputImg.UpdateNamedInputs();
            OnImageChanged();
            UpdateOutput();
        }

        private void UpdateOutput()
        {
            try
            {
                OutputImg.Mat.Dispose();

                OutputImg.Mat = new Mat(InputImg.Mat, new Rectangle(
                    XTrackbar.Value,
                    YTrackbar.Maximum - YTrackbar.Value,
                    X2Trackbar.Value - XTrackbar.Value,
                    YTrackbar.Value - Y2Trackbar.Value));

                OutputImg.UpdateImage();
            }
            catch { }
        }

        private void OnImageChanged()
        {
            try
            {
                XTrackbar.Maximum = InputImg.Mat!.Width;
                X2Trackbar.Maximum = InputImg.Mat!.Width;

                YTrackbar.Maximum = InputImg.Mat!.Height;
                Y2Trackbar.Maximum = InputImg.Mat!.Height;
            }
            catch { }   
        }

        private void XTrackbar_Scroll(object sender, EventArgs e)
        {
            if (XTrackbar.Value >= X2Trackbar.Value) XTrackbar.Value = X2Trackbar.Value - 1;
            UpdateOutput();
        }
        private void YTrackbar_Scroll(object sender, EventArgs e)
        {
            if (YTrackbar.Value <= Y2Trackbar.Value) YTrackbar.Value = Y2Trackbar.Value + 1;
            UpdateOutput();
        }
        private void X2Trackbar_Scroll(object sender, EventArgs e)
        {
            if (X2Trackbar.Value <= XTrackbar.Value) X2Trackbar.Value = XTrackbar.Value + 1;
            UpdateOutput();
        }
        private void Y2Trackbar_Scroll(object sender, EventArgs e)
        {
            if (Y2Trackbar.Value >= YTrackbar.Value) Y2Trackbar.Value = YTrackbar.Value - 1;
            UpdateOutput();
        }

        private void ResetTrackbarsButton_Click(object sender, EventArgs e)
        {
            XTrackbar.Value = 0;
            YTrackbar.Value = Y2Trackbar.Maximum;
            X2Trackbar.Value = X2Trackbar.Maximum;
            Y2Trackbar.Value = 0;
        }
    }
}