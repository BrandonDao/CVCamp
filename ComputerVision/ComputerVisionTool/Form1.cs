using ComputerVision.Controls;
using ComputerVisionTool.Controls.CustomControls;
using ComputerVisionTool.Controls.Operations;
using Emgu.CV;

namespace ComputerVisionTool
{
    public partial class CVToolsForm : Form
    {
        private VideoCapture videoCapture;
        private ImageOutput cameraOutput;

        public CVToolsForm()
        {
            InitializeComponent();

            videoCapture = new VideoCapture(0);
            cameraOutput = new ImageOutput()
            {
                Parent = new BaseOp(containerForm: this)
            };

            NameManager.NamedInputsByImage.Add(cameraOutput, new NamedInput("Camera Video Capture", cameraOutput));

            Application.Idle += UpdateVideoCapture;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TabManager.Load(parent: this);
        }

        public void UpdateAll() => TabManager.UpdateAll();

        #region Events
        private void UpdateVideoCapture(object? sender, EventArgs e)
        {
            using Mat frame = videoCapture.QueryFrame();

            if (frame == null) return;

            var frameClone = frame.Clone();

            CvInvoke.Flip(frameClone, frameClone, Emgu.CV.CvEnum.FlipType.Horizontal);

            cameraOutput.Mat.Dispose();
            cameraOutput.Mat = frameClone;
            //cameraOutput.UpdateImage();
            UpdateAll();
        }


        private void AddTabButton_Click(object sender, EventArgs e) => TabManager.AddPage();

        private void AddBitwiseButton_Click(object sender, EventArgs e) => TabManager.AddOperation(typeof(BitwiseOp));
        private void AddConvertColorButton_Click(object sender, EventArgs e) => TabManager.AddOperation(typeof(ConvertColorOp));
        private void AddErodeButton_Click(object sender, EventArgs e) => TabManager.AddOperation(typeof(ErodeOp));
        private void AddDilateButton_Click(object sender, EventArgs e) => TabManager.AddOperation(typeof(DilateOp));
        private void AddThresholdButton_Click(object sender, EventArgs e) => TabManager.AddOperation(typeof(ThresholdOp));
        private void AddInRangeButton_Click(object sender, EventArgs e) => TabManager.AddOperation(typeof(InRangeOp));

        private void CVToolsForm_ClientSizeChanged(object sender, EventArgs e)
        {
            TabManager.TabControl.Width = ClientSize.Width - TabManager.DefaultX;
            TabManager.TabControl.Height = ClientSize.Height;
        }


        #endregion Events
    }
}