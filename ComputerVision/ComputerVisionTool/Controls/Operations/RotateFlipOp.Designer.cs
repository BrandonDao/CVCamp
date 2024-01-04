namespace ComputerVisionTool.Controls.Operations
{
    partial class RotateFlipOp
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RotateFlipOp));
            InputImg = new CustomControls.ImageInput();
            OutputImg = new CustomControls.ImageOutput();
            OpComboBox = new ComboBox();
            SuspendLayout();
            // 
            // InputImg
            // 
            InputImg.Location = new Point(3, 3);
            InputImg.Name = "InputImg";
            InputImg.Size = new Size(156, 186);
            InputImg.TabIndex = 0;
            // 
            // OutputImg
            // 
            OutputImg.Location = new Point(292, 3);
            OutputImg.Mat = (Emgu.CV.Mat)resources.GetObject("OutputImg.Mat");
            OutputImg.Name = "OutputImg";
            OutputImg.Size = new Size(157, 216);
            OutputImg.TabIndex = 1;
            // 
            // OpComboBox
            // 
            OpComboBox.FormattingEnabled = true;
            OpComboBox.Location = new Point(165, 100);
            OpComboBox.Name = "OpComboBox";
            OpComboBox.Size = new Size(121, 23);
            OpComboBox.TabIndex = 2;
            OpComboBox.SelectedIndexChanged += OpComboBox_SelectedIndexChanged;
            // 
            // RotateFlipOp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(OpComboBox);
            Controls.Add(OutputImg);
            Controls.Add(InputImg);
            Name = "RotateFlipOp";
            Size = new Size(450, 222);
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.ImageInput InputImg;
        private CustomControls.ImageOutput OutputImg;
        private ComboBox OpComboBox;
    }
}
