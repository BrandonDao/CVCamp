namespace VEXPartAnalyzer
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
            CameraImgBox = new Emgu.CV.UI.ImageBox();
            PartInRange = new Emgu.CV.UI.ImageBox();
            epsilonTrackbar = new TrackBar();
            VertexCountLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)CameraImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PartInRange).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epsilonTrackbar).BeginInit();
            SuspendLayout();
            // 
            // CameraImgBox
            // 
            CameraImgBox.Location = new Point(12, 30);
            CameraImgBox.Name = "CameraImgBox";
            CameraImgBox.Size = new Size(320, 240);
            CameraImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            CameraImgBox.TabIndex = 2;
            CameraImgBox.TabStop = false;
            // 
            // PartInRange
            // 
            PartInRange.Location = new Point(338, 30);
            PartInRange.Name = "PartInRange";
            PartInRange.Size = new Size(160, 120);
            PartInRange.SizeMode = PictureBoxSizeMode.Zoom;
            PartInRange.TabIndex = 3;
            PartInRange.TabStop = false;
            // 
            // epsilonTrackbar
            // 
            epsilonTrackbar.Location = new Point(338, 156);
            epsilonTrackbar.Maximum = 100;
            epsilonTrackbar.Name = "epsilonTrackbar";
            epsilonTrackbar.Size = new Size(160, 45);
            epsilonTrackbar.TabIndex = 4;
            // 
            // VertexCountLabel
            // 
            VertexCountLabel.AutoSize = true;
            VertexCountLabel.Location = new Point(338, 195);
            VertexCountLabel.Name = "VertexCountLabel";
            VertexCountLabel.Size = new Size(78, 15);
            VertexCountLabel.TabIndex = 5;
            VertexCountLabel.Text = "Vertex Count:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(VertexCountLabel);
            Controls.Add(epsilonTrackbar);
            Controls.Add(PartInRange);
            Controls.Add(CameraImgBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)CameraImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PartInRange).EndInit();
            ((System.ComponentModel.ISupportInitialize)epsilonTrackbar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Emgu.CV.UI.ImageBox CameraImgBox;
        private Emgu.CV.UI.ImageBox PartInRange;
        private TrackBar epsilonTrackbar;
        private Label VertexCountLabel;
    }
}
