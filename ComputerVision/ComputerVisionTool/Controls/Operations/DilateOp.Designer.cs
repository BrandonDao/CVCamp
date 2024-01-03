namespace ComputerVisionTool.Controls.Operations
{
    partial class DilateOp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DilateOp));
            InputImg = new CustomControls.ImageInput();
            OutputImg = new CustomControls.ImageOutput();
            IterationsTrackbar = new TrackBar();
            KernelSizeTrackbar = new TrackBar();
            KernelSizeLabel = new Label();
            IterationsLabel = new Label();
            ElementTypeComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)IterationsTrackbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KernelSizeTrackbar).BeginInit();
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
            OutputImg.Location = new Point(405, 3);
            OutputImg.Mat = (Emgu.CV.Mat)resources.GetObject("OutputImg.Mat");
            OutputImg.Name = "OutputImg";
            OutputImg.Size = new Size(157, 216);
            OutputImg.TabIndex = 1;
            // 
            // IterationsTrackbar
            // 
            IterationsTrackbar.Location = new Point(165, 111);
            IterationsTrackbar.Maximum = 50;
            IterationsTrackbar.Minimum = 1;
            IterationsTrackbar.Name = "IterationsTrackbar";
            IterationsTrackbar.Size = new Size(234, 45);
            IterationsTrackbar.TabIndex = 2;
            IterationsTrackbar.Value = 1;
            IterationsTrackbar.Scroll += IterationsTrackbar_Scroll;
            // 
            // KernelSizeTrackbar
            // 
            KernelSizeTrackbar.Location = new Point(165, 45);
            KernelSizeTrackbar.Maximum = 100;
            KernelSizeTrackbar.Minimum = 1;
            KernelSizeTrackbar.Name = "KernelSizeTrackbar";
            KernelSizeTrackbar.Size = new Size(234, 45);
            KernelSizeTrackbar.TabIndex = 3;
            KernelSizeTrackbar.Value = 1;
            KernelSizeTrackbar.Scroll += KernelSizeTrackbar_Scroll;
            // 
            // KernelSizeLabel
            // 
            KernelSizeLabel.AutoSize = true;
            KernelSizeLabel.Location = new Point(165, 27);
            KernelSizeLabel.Name = "KernelSizeLabel";
            KernelSizeLabel.Size = new Size(63, 15);
            KernelSizeLabel.TabIndex = 4;
            KernelSizeLabel.Text = "Kernel Size";
            // 
            // IterationsLabel
            // 
            IterationsLabel.AutoSize = true;
            IterationsLabel.Location = new Point(165, 93);
            IterationsLabel.Name = "IterationsLabel";
            IterationsLabel.Size = new Size(56, 15);
            IterationsLabel.TabIndex = 5;
            IterationsLabel.Text = "Iterations";
            // 
            // ElementTypeComboBox
            // 
            ElementTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ElementTypeComboBox.FormattingEnabled = true;
            ElementTypeComboBox.Location = new Point(165, 162);
            ElementTypeComboBox.Name = "ElementTypeComboBox";
            ElementTypeComboBox.Size = new Size(121, 23);
            ElementTypeComboBox.TabIndex = 6;
            // 
            // ErodeOp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ElementTypeComboBox);
            Controls.Add(IterationsLabel);
            Controls.Add(KernelSizeLabel);
            Controls.Add(KernelSizeTrackbar);
            Controls.Add(IterationsTrackbar);
            Controls.Add(OutputImg);
            Controls.Add(InputImg);
            Name = "ErodeOp";
            Size = new Size(564, 221);
            ((System.ComponentModel.ISupportInitialize)IterationsTrackbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)KernelSizeTrackbar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.ImageInput InputImg;
        private CustomControls.ImageOutput OutputImg;
        private TrackBar IterationsTrackbar;
        private TrackBar KernelSizeTrackbar;
        private Label KernelSizeLabel;
        private Label IterationsLabel;
        private ComboBox ElementTypeComboBox;
    }
}
