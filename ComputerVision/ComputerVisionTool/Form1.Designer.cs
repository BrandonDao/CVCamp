namespace ComputerVisionTool
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
            bitwiseOp1 = new Controls.Operations.BitwiseOp();
            bitwiseOp2 = new Controls.Operations.BitwiseOp();
            SuspendLayout();
            // 
            // bitwiseOp1
            // 
            bitwiseOp1.Location = new Point(33, 40);
            bitwiseOp1.Name = "bitwiseOp1";
            bitwiseOp1.Size = new Size(712, 300);
            bitwiseOp1.TabIndex = 0;
            // 
            // bitwiseOp2
            // 
            bitwiseOp2.Location = new Point(33, 313);
            bitwiseOp2.Name = "bitwiseOp2";
            bitwiseOp2.Size = new Size(571, 220);
            bitwiseOp2.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 545);
            Controls.Add(bitwiseOp2);
            Controls.Add(bitwiseOp1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Controls.Operations.BitwiseOp bitwiseOp1;
        private Controls.Operations.BitwiseOp bitwiseOp2;
    }
}