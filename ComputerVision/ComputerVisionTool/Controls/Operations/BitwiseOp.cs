﻿using Emgu.CV;

namespace ComputerVisionTool.Controls.Operations
{
    public partial class BitwiseOp : UserControl, IOperation
    {
        public struct OpType
        {
            public string Name;
            public Action<Mat, Mat, Mat> Operation;

            public OpType(string name, Action<Mat, Mat, Mat> operation)
            {
                Name = name;
                Operation = operation;
            }

            public override readonly string ToString() => Name;
        }

        public CVToolsForm ContainerForm { get; set; }

        public BitwiseOp(Control parent, Point location, CVToolsForm containerForm)
        {
            Parent = parent;
            Location = location;
            ContainerForm = containerForm;

            InitializeComponent();
            
            OpComboBox.Items.AddRange(new object[]
            {
                new OpType("OR", (a,b,c)  => {CvInvoke.BitwiseOr(a,b,c); InputImgB.Show(); }),
                new OpType("AND", (a,b,c) => {CvInvoke.BitwiseAnd(a,b,c); InputImgB.Show(); }),
                new OpType("XOR", (a,b,c) => {CvInvoke.BitwiseXor(a,b,c); InputImgB.Show(); }),
                new OpType("NOT", (a,_,c) => { CvInvoke.BitwiseNot(a,c); InputImgB.Hide(); }),
                new OpType("Abs. Diff.", (a,b,c) => { CvInvoke.AbsDiff(a,b,c); InputImgB.Show(); }),
            });

            OpComboBox.SelectedIndex = 0;
        }

        public void UpdateAll()
        {
            InputImgA.UpdateNamedInputs();
            InputImgB.UpdateNamedInputs();
            UpdateOutput();
        }

        private void UpdateOutput()
        {
            try
            {
                ((OpType)OpComboBox.SelectedItem).Operation.Invoke(InputImgA.Mat!, InputImgB.Mat!, OutputImg.Mat);
            }
            catch { }
            OutputImg.UpdateImage();
        }

        private void UpdateNamedInputsButton_Click(object sender, EventArgs e)
        {
            InputImgA.UpdateNamedInputs();
            InputImgB.UpdateNamedInputs();
        }

        private void OpComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateOutput();
            ContainerForm.UpdateAll();
        }
    }
}