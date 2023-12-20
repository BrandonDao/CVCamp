namespace CVExercises
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Bitwise_ImgSelectionDialog = new OpenFileDialog();
            TabControl = new TabControl();
            Bitwise_TabPage = new TabPage();
            bitwiseOp1 = new ComputerVision.BitwiseOp();
            Test_TabPage = new TabPage();
            Test_InputPictureBox = new Emgu.CV.UI.ImageBox();
            Test_OutputPictureBox = new Emgu.CV.UI.ImageBox();
            ROI_TabPage = new TabPage();
            TabControl.SuspendLayout();
            Bitwise_TabPage.SuspendLayout();
            Test_TabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Test_InputPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Test_OutputPictureBox).BeginInit();
            SuspendLayout();
            // 
            // Bitwise_ImgSelectionDialog
            // 
            Bitwise_ImgSelectionDialog.FileName = "Bitwise_ImgSelectionDialog";
            // 
            // TabControl
            // 
            TabControl.Controls.Add(Bitwise_TabPage);
            TabControl.Controls.Add(Test_TabPage);
            TabControl.Controls.Add(ROI_TabPage);
            TabControl.Location = new Point(12, 12);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(727, 388);
            TabControl.TabIndex = 8;
            // 
            // Bitwise_TabPage
            // 
            Bitwise_TabPage.Controls.Add(bitwiseOp1);
            Bitwise_TabPage.Location = new Point(4, 24);
            Bitwise_TabPage.Name = "Bitwise_TabPage";
            Bitwise_TabPage.Padding = new Padding(3);
            Bitwise_TabPage.Size = new Size(719, 360);
            Bitwise_TabPage.TabIndex = 1;
            Bitwise_TabPage.Text = "Bitwise";
            Bitwise_TabPage.UseVisualStyleBackColor = true;
            // 
            // bitwiseOp1
            // 
            bitwiseOp1.Location = new Point(6, 6);
            bitwiseOp1.Name = "bitwiseOp1";
            bitwiseOp1.Size = new Size(521, 190);
            bitwiseOp1.TabIndex = 0;
            // 
            // Test_TabPage
            // 
            Test_TabPage.Controls.Add(Test_InputPictureBox);
            Test_TabPage.Controls.Add(Test_OutputPictureBox);
            Test_TabPage.Location = new Point(4, 24);
            Test_TabPage.Name = "Test_TabPage";
            Test_TabPage.Padding = new Padding(3);
            Test_TabPage.Size = new Size(719, 360);
            Test_TabPage.TabIndex = 3;
            Test_TabPage.Text = "Test";
            Test_TabPage.UseVisualStyleBackColor = true;
            // 
            // Test_InputPictureBox
            // 
            Test_InputPictureBox.Location = new Point(6, 6);
            Test_InputPictureBox.Name = "Test_InputPictureBox";
            Test_InputPictureBox.Size = new Size(251, 251);
            Test_InputPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            Test_InputPictureBox.TabIndex = 3;
            Test_InputPictureBox.TabStop = false;
            // 
            // Test_OutputPictureBox
            // 
            Test_OutputPictureBox.Location = new Point(323, 6);
            Test_OutputPictureBox.Name = "Test_OutputPictureBox";
            Test_OutputPictureBox.Size = new Size(251, 251);
            Test_OutputPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            Test_OutputPictureBox.TabIndex = 2;
            Test_OutputPictureBox.TabStop = false;
            // 
            // ROI_TabPage
            // 
            ROI_TabPage.Location = new Point(4, 24);
            ROI_TabPage.Name = "ROI_TabPage";
            ROI_TabPage.Padding = new Padding(3);
            ROI_TabPage.Size = new Size(719, 360);
            ROI_TabPage.TabIndex = 4;
            ROI_TabPage.Text = "ROI";
            ROI_TabPage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 412);
            Controls.Add(TabControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Fish 🐟";
            Load += Form1_Load;
            TabControl.ResumeLayout(false);
            Bitwise_TabPage.ResumeLayout(false);
            Test_TabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Test_InputPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Test_OutputPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private OpenFileDialog Bitwise_ImgSelectionDialog;
        private TabControl TabControl;
        private TabPage Test_TabPage;
        private Emgu.CV.UI.ImageBox Test_OutputPictureBox;
        private TabPage Bitwise_TabPage;
        private Emgu.CV.UI.ImageBox Test_InputPictureBox;
        private ComputerVision.BitwiseOp bitwiseOp1;
        private TabPage ROI_TabPage;
    }
}