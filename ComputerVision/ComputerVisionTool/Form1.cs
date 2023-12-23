using ComputerVisionTool.Controls.Operations;

namespace ComputerVisionTool
{
    public partial class Form1 : Form
    {

        private const int OpSpacing = 50;
        private const int OpX = 150;

        private List<IOperation> operations;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            operations = new List<IOperation>();

            var bitwiseOpToAdd = new BitwiseOp
            {
                Location = new Point(OpX, 0),
                Parent = this,
            };

            operations.Add(bitwiseOpToAdd);
            Controls.Add(bitwiseOpToAdd);


            //for (int i = 1; i <= 2; i++)
            //{
            //    bitwiseOpToAdd = new BitwiseOp()
            //    {
            //        Location = new Point(bitwiseOps[i - 1].Location.X, bitwiseOps[i - 1].Location.Y + bitwiseOps[i - 1].Height + OpSpacing),
            //        Parent = this,
            //    };
            //    bitwiseOps.Add(bitwiseOpToAdd);
            //    Controls.Add(bitwiseOpToAdd);
            //}
        }

        public void UpdateAll()
        {
            foreach (var ops in operations)
            {
                ops.UpdateAll();
            }
        }

        private void AddBitwiseButton_Click(object sender, EventArgs e)
        {
            var previousControl = (UserControl)operations[^1];

            var bitwiseOp = new BitwiseOp()
            {
                Parent = this,
                Location = new Point(OpX, previousControl.Location.Y + previousControl.Height + OpSpacing)
            };

            operations.Add(bitwiseOp);
            Controls.Add(bitwiseOp);
        }

        private void AddColorConvertButton_Click(object sender, EventArgs e)
        {
            var previousControl = (UserControl)operations[^1];

            var colorConverter = new ConvertColorOp()
            {
                Parent = this,
                Location = new Point(OpX, previousControl.Location.Y + previousControl.Height + OpSpacing)
            };

            operations.Add(colorConverter);
            Controls.Add(colorConverter);
        }
    }
}