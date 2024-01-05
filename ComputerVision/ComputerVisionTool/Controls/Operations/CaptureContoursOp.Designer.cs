namespace ComputerVisionTool.Controls.Operations
{
    partial class CaptureContoursOp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptureContoursOp));
            InputImg = new CustomControls.ImageInput();
            VisualInputImg = new CustomControls.ImageInput();
            OutputImg = new CustomControls.ImageOutput();
            InputLabel = new Label();
            DrawOntoLabel = new Label();
            SuspendLayout();
            // 
            // InputImg
            // 
            InputImg.Location = new Point(3, 3);
            InputImg.Name = "InputImg";
            InputImg.Size = new Size(156, 184);
            InputImg.TabIndex = 0;
            // 
            // VisualInputImg
            // 
            VisualInputImg.Location = new Point(165, 3);
            VisualInputImg.Name = "VisualInputImg";
            VisualInputImg.Size = new Size(156, 184);
            VisualInputImg.TabIndex = 1;
            // 
            // OutputImg
            // 
            OutputImg.Location = new Point(381, 3);
            OutputImg.Mat = (Emgu.CV.Mat)resources.GetObject("OutputImg.Mat");
            OutputImg.Name = "OutputImg";
            OutputImg.Size = new Size(157, 216);
            OutputImg.TabIndex = 2;
            // 
            // InputLabel
            // 
            InputLabel.AutoSize = true;
            InputLabel.Location = new Point(35, 190);
            InputLabel.Name = "InputLabel";
            InputLabel.Size = new Size(96, 15);
            InputLabel.TabIndex = 3;
            InputLabel.Text = "Input (Grayscale)";
            // 
            // DrawOntoLabel
            // 
            DrawOntoLabel.AutoSize = true;
            DrawOntoLabel.Location = new Point(183, 190);
            DrawOntoLabel.Name = "DrawOntoLabel";
            DrawOntoLabel.Size = new Size(115, 15);
            DrawOntoLabel.TabIndex = 4;
            DrawOntoLabel.Text = "Image To Draw Onto";
            // 
            // CaptureContoursOp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DrawOntoLabel);
            Controls.Add(InputLabel);
            Controls.Add(OutputImg);
            Controls.Add(VisualInputImg);
            Controls.Add(InputImg);
            Name = "CaptureContoursOp";
            Size = new Size(538, 220);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.ImageInput InputImg;
        private CustomControls.ImageInput VisualInputImg;
        private CustomControls.ImageOutput OutputImg;
        private Label InputLabel;
        private Label DrawOntoLabel;
    }
}
