namespace ComputerVision.Controls
{
    partial class InRangeOp
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InRangeOp));
            InputImg = new ComputerVisionTool.Controls.CustomControls.ImageInput();
            OutputImg = new ComputerVisionTool.Controls.CustomControls.ImageOutput();
            BLTrackbar = new TrackBar();
            BLImgBox = new Emgu.CV.UI.ImageBox();
            TLImgBox = new Emgu.CV.UI.ImageBox();
            MLImgBox = new Emgu.CV.UI.ImageBox();
            MLTrackbar = new TrackBar();
            TLTrackbar = new TrackBar();
            TRTrackbar = new TrackBar();
            MRTrackbar = new TrackBar();
            MRImgBox = new Emgu.CV.UI.ImageBox();
            TRImgBox = new Emgu.CV.UI.ImageBox();
            BRImgBox = new Emgu.CV.UI.ImageBox();
            BRTrackbar = new TrackBar();
            LowerBoundLabel = new Label();
            UpperBoundLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)BLTrackbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BLImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TLImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MLImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MLTrackbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TLTrackbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TRTrackbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MRTrackbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MRImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TRImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BRImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BRTrackbar).BeginInit();
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
            OutputImg.Location = new Point(653, 3);
            OutputImg.Mat = (Emgu.CV.Mat)resources.GetObject("OutputImg.Mat");
            OutputImg.Name = "OutputImg";
            OutputImg.Size = new Size(157, 216);
            OutputImg.TabIndex = 1;
            // 
            // BLTrackbar
            // 
            BLTrackbar.Location = new Point(221, 144);
            BLTrackbar.Name = "BLTrackbar";
            BLTrackbar.Size = new Size(169, 45);
            BLTrackbar.TabIndex = 2;
            BLTrackbar.Scroll += BLTrackbar_Scroll;
            // 
            // BLImgBox
            // 
            BLImgBox.BorderStyle = BorderStyle.FixedSingle;
            BLImgBox.Location = new Point(165, 135);
            BLImgBox.Name = "BLImgBox";
            BLImgBox.Size = new Size(50, 50);
            BLImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            BLImgBox.TabIndex = 2;
            BLImgBox.TabStop = false;
            // 
            // TLImgBox
            // 
            TLImgBox.BorderStyle = BorderStyle.FixedSingle;
            TLImgBox.Location = new Point(165, 31);
            TLImgBox.Name = "TLImgBox";
            TLImgBox.Size = new Size(50, 50);
            TLImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            TLImgBox.TabIndex = 3;
            TLImgBox.TabStop = false;
            // 
            // MLImgBox
            // 
            MLImgBox.BorderStyle = BorderStyle.FixedSingle;
            MLImgBox.Location = new Point(165, 83);
            MLImgBox.Name = "MLImgBox";
            MLImgBox.Size = new Size(50, 50);
            MLImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            MLImgBox.TabIndex = 4;
            MLImgBox.TabStop = false;
            // 
            // MLTrackbar
            // 
            MLTrackbar.Location = new Point(221, 88);
            MLTrackbar.Name = "MLTrackbar";
            MLTrackbar.Size = new Size(169, 45);
            MLTrackbar.TabIndex = 5;
            MLTrackbar.Scroll += MLTrackbar_Scroll;
            // 
            // TLTrackbar
            // 
            TLTrackbar.Location = new Point(221, 36);
            TLTrackbar.Name = "TLTrackbar";
            TLTrackbar.Size = new Size(169, 45);
            TLTrackbar.TabIndex = 6;
            TLTrackbar.Scroll += TLTrackbar_Scroll;
            // 
            // TRTrackbar
            // 
            TRTrackbar.Location = new Point(478, 36);
            TRTrackbar.Name = "TRTrackbar";
            TRTrackbar.Size = new Size(169, 45);
            TRTrackbar.TabIndex = 12;
            TRTrackbar.Scroll += TRTrackbar_Scroll;
            // 
            // MRTrackbar
            // 
            MRTrackbar.Location = new Point(478, 88);
            MRTrackbar.Name = "MRTrackbar";
            MRTrackbar.Size = new Size(169, 45);
            MRTrackbar.TabIndex = 11;
            MRTrackbar.Scroll += MRTrackbar_Scroll;
            // 
            // MRImgBox
            // 
            MRImgBox.BorderStyle = BorderStyle.FixedSingle;
            MRImgBox.Location = new Point(422, 83);
            MRImgBox.Name = "MRImgBox";
            MRImgBox.Size = new Size(50, 50);
            MRImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            MRImgBox.TabIndex = 10;
            MRImgBox.TabStop = false;
            // 
            // TRImgBox
            // 
            TRImgBox.BorderStyle = BorderStyle.FixedSingle;
            TRImgBox.Location = new Point(422, 31);
            TRImgBox.Name = "TRImgBox";
            TRImgBox.Size = new Size(50, 50);
            TRImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            TRImgBox.TabIndex = 9;
            TRImgBox.TabStop = false;
            // 
            // BRImgBox
            // 
            BRImgBox.BorderStyle = BorderStyle.FixedSingle;
            BRImgBox.Location = new Point(422, 135);
            BRImgBox.Name = "BRImgBox";
            BRImgBox.Size = new Size(50, 50);
            BRImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            BRImgBox.TabIndex = 7;
            BRImgBox.TabStop = false;
            // 
            // BRTrackbar
            // 
            BRTrackbar.Location = new Point(478, 144);
            BRTrackbar.Name = "BRTrackbar";
            BRTrackbar.Size = new Size(169, 45);
            BRTrackbar.TabIndex = 8;
            BRTrackbar.Scroll += BRTrackbar_Scroll;
            // 
            // LowerBoundLabel
            // 
            LowerBoundLabel.AutoSize = true;
            LowerBoundLabel.Location = new Point(243, 13);
            LowerBoundLabel.Name = "LowerBoundLabel";
            LowerBoundLabel.Size = new Size(77, 15);
            LowerBoundLabel.TabIndex = 13;
            LowerBoundLabel.Text = "Lower Bound";
            // 
            // UpperBoundLabel
            // 
            UpperBoundLabel.AutoSize = true;
            UpperBoundLabel.Location = new Point(508, 13);
            UpperBoundLabel.Name = "UpperBoundLabel";
            UpperBoundLabel.Size = new Size(77, 15);
            UpperBoundLabel.TabIndex = 14;
            UpperBoundLabel.Text = "Upper Bound";
            // 
            // InRangeOp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(UpperBoundLabel);
            Controls.Add(LowerBoundLabel);
            Controls.Add(TRTrackbar);
            Controls.Add(MRTrackbar);
            Controls.Add(MRImgBox);
            Controls.Add(TRImgBox);
            Controls.Add(BRImgBox);
            Controls.Add(BRTrackbar);
            Controls.Add(TLTrackbar);
            Controls.Add(MLTrackbar);
            Controls.Add(MLImgBox);
            Controls.Add(TLImgBox);
            Controls.Add(BLImgBox);
            Controls.Add(BLTrackbar);
            Controls.Add(OutputImg);
            Controls.Add(InputImg);
            Name = "InRangeOp";
            Size = new Size(811, 220);
            ((System.ComponentModel.ISupportInitialize)BLTrackbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BLImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)TLImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)MLImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)MLTrackbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)TLTrackbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)TRTrackbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)MRTrackbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)MRImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)TRImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)BRImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)BRTrackbar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComputerVisionTool.Controls.CustomControls.ImageInput InputImg;
        private ComputerVisionTool.Controls.CustomControls.ImageOutput OutputImg;
        private TrackBar BLTrackbar;
        private Emgu.CV.UI.ImageBox BLImgBox;
        private Emgu.CV.UI.ImageBox TLImgBox;
        private Emgu.CV.UI.ImageBox MLImgBox;
        private TrackBar MLTrackbar;
        private TrackBar TLTrackbar;
        private TrackBar TRTrackbar;
        private TrackBar MRTrackbar;
        private Emgu.CV.UI.ImageBox MRImgBox;
        private Emgu.CV.UI.ImageBox TRImgBox;
        private Emgu.CV.UI.ImageBox BRImgBox;
        private TrackBar BRTrackbar;
        private Label LowerBoundLabel;
        private Label UpperBoundLabel;
    }
}
