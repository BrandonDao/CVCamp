namespace ComputerVisionTool.Controls.Operations
{
    partial class TransformationOp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransformationOp));
            InputImg = new CustomControls.ImageInput();
            OutputImg = new CustomControls.ImageOutput();
            ContourInputImg = new CustomControls.ImageInput();
            ContourOutputImg = new CustomControls.ImageOutput();
            EpsilonTrackbar = new TrackBar();
            EpsilonLabel = new Label();
            label1 = new Label();
            MaskLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)EpsilonTrackbar).BeginInit();
            SuspendLayout();
            // 
            // InputImg
            // 
            InputImg.Location = new Point(3, 3);
            InputImg.Name = "InputImg";
            InputImg.Size = new Size(156, 184);
            InputImg.TabIndex = 0;
            // 
            // OutputImg
            // 
            OutputImg.Location = new Point(571, 3);
            OutputImg.Mat = (Emgu.CV.Mat)resources.GetObject("OutputImg.Mat");
            OutputImg.Name = "OutputImg";
            OutputImg.Size = new Size(157, 216);
            OutputImg.TabIndex = 1;
            // 
            // ContourInputImg
            // 
            ContourInputImg.Location = new Point(165, 3);
            ContourInputImg.Name = "ContourInputImg";
            ContourInputImg.Size = new Size(156, 184);
            ContourInputImg.TabIndex = 2;
            // 
            // ContourOutputImg
            // 
            ContourOutputImg.Location = new Point(408, 3);
            ContourOutputImg.Mat = (Emgu.CV.Mat)resources.GetObject("ContourOutputImg.Mat");
            ContourOutputImg.Name = "ContourOutputImg";
            ContourOutputImg.Size = new Size(157, 216);
            ContourOutputImg.TabIndex = 3;
            // 
            // EpsilonTrackbar
            // 
            EpsilonTrackbar.Location = new Point(408, 233);
            EpsilonTrackbar.Maximum = 200;
            EpsilonTrackbar.Name = "EpsilonTrackbar";
            EpsilonTrackbar.Size = new Size(157, 45);
            EpsilonTrackbar.TabIndex = 4;
            // 
            // EpsilonLabel
            // 
            EpsilonLabel.AutoSize = true;
            EpsilonLabel.Location = new Point(408, 217);
            EpsilonLabel.Name = "EpsilonLabel";
            EpsilonLabel.Size = new Size(45, 15);
            EpsilonLabel.TabIndex = 5;
            EpsilonLabel.Text = "Epsilon";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 190);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 6;
            label1.Text = "Input";
            // 
            // MaskLabel
            // 
            MaskLabel.AutoSize = true;
            MaskLabel.Location = new Point(218, 190);
            MaskLabel.Name = "MaskLabel";
            MaskLabel.Size = new Size(35, 15);
            MaskLabel.TabIndex = 7;
            MaskLabel.Text = "Mask";
            // 
            // TransformationOp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MaskLabel);
            Controls.Add(label1);
            Controls.Add(EpsilonLabel);
            Controls.Add(EpsilonTrackbar);
            Controls.Add(ContourOutputImg);
            Controls.Add(ContourInputImg);
            Controls.Add(OutputImg);
            Controls.Add(InputImg);
            Name = "TransformationOp";
            Size = new Size(893, 267);
            ((System.ComponentModel.ISupportInitialize)EpsilonTrackbar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.ImageInput InputImg;
        private CustomControls.ImageOutput OutputImg;
        private CustomControls.ImageInput ContourInputImg;
        private CustomControls.ImageOutput ContourOutputImg;
        private TrackBar EpsilonTrackbar;
        private Label EpsilonLabel;
        private Label label1;
        private Label MaskLabel;
    }
}
