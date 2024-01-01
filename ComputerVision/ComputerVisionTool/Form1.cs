using ComputerVisionTool.Controls.Operations;

namespace ComputerVisionTool
{
    public partial class CVToolsForm : Form
    {
        public CVToolsForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TabManager.Load(parent: this);
        }

        public void UpdateAll() => TabManager.UpdateAll();

        #region Events
        private void AddTabButton_Click(object sender, EventArgs e) => TabManager.AddPage();

        private void AddBitwiseButton_Click(object sender, EventArgs e) => TabManager.AddOperation(typeof(BitwiseOp));
        private void AddConvertColorButton_Click(object sender, EventArgs e) => TabManager.AddOperation(typeof(ConvertColorOp));



        #endregion Events

        private void CVToolsForm_ClientSizeChanged(object sender, EventArgs e)
        {
            TabManager.TabControl.Width = ClientSize.Width - TabManager.DefaultX;
            TabManager.TabControl.Height = ClientSize.Height;
        }
    }
}