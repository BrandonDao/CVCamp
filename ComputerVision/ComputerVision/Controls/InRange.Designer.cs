namespace ComputerVision.Controls
{
    partial class InRange
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
            InImgBox = new Emgu.CV.UI.ImageBox();
            OutImgBox = new Emgu.CV.UI.ImageBox();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            TopUpperTrackbar = new TrackBar();
            TopLowerTrackbar = new TrackBar();
            MidLowerTrackbar = new TrackBar();
            MidUpperTrackbar = new TrackBar();
            BottomLowerTrackbar = new TrackBar();
            BottomUpperTrackbar = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ConvertToHSVButton = new Button();
            ConvertToRGBButton = new Button();
            Up1ImgBox = new Emgu.CV.UI.ImageBox();
            Up2ImgBox = new Emgu.CV.UI.ImageBox();
            Up3ImgBox = new Emgu.CV.UI.ImageBox();
            Low3ImgBox = new Emgu.CV.UI.ImageBox();
            Low2ImgBox = new Emgu.CV.UI.ImageBox();
            Low1ImgBox = new Emgu.CV.UI.ImageBox();
            Up4ImgBox = new Emgu.CV.UI.ImageBox();
            Low4ImgBox = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)InImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OutImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TopUpperTrackbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TopLowerTrackbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MidLowerTrackbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MidUpperTrackbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BottomLowerTrackbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BottomUpperTrackbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Up1ImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Up2ImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Up3ImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Low3ImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Low2ImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Low1ImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Up4ImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Low4ImgBox).BeginInit();
            SuspendLayout();
            // 
            // InImgBox
            // 
            InImgBox.BorderStyle = BorderStyle.FixedSingle;
            InImgBox.Location = new Point(3, 51);
            InImgBox.Name = "InImgBox";
            InImgBox.Size = new Size(150, 150);
            InImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            InImgBox.TabIndex = 2;
            InImgBox.TabStop = false;
            InImgBox.Click += InImgBox_Click;
            // 
            // OutImgBox
            // 
            OutImgBox.BorderStyle = BorderStyle.FixedSingle;
            OutImgBox.Location = new Point(402, 51);
            OutImgBox.Name = "OutImgBox";
            OutImgBox.Size = new Size(150, 150);
            OutImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            OutImgBox.TabIndex = 3;
            OutImgBox.TabStop = false;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // TopUpperTrackbar
            // 
            TopUpperTrackbar.Location = new Point(189, 19);
            TopUpperTrackbar.Maximum = 255;
            TopUpperTrackbar.Name = "TopUpperTrackbar";
            TopUpperTrackbar.Size = new Size(203, 45);
            TopUpperTrackbar.TabIndex = 4;
            TopUpperTrackbar.Scroll += TopUpperTrackbar_Scroll;
            // 
            // TopLowerTrackbar
            // 
            TopLowerTrackbar.Location = new Point(189, 44);
            TopLowerTrackbar.Maximum = 255;
            TopLowerTrackbar.Name = "TopLowerTrackbar";
            TopLowerTrackbar.Size = new Size(203, 45);
            TopLowerTrackbar.TabIndex = 5;
            TopLowerTrackbar.TickStyle = TickStyle.TopLeft;
            TopLowerTrackbar.Scroll += TopLowerTrackbar_Scroll;
            // 
            // MidLowerTrackbar
            // 
            MidLowerTrackbar.Location = new Point(189, 124);
            MidLowerTrackbar.Maximum = 255;
            MidLowerTrackbar.Name = "MidLowerTrackbar";
            MidLowerTrackbar.Size = new Size(203, 45);
            MidLowerTrackbar.TabIndex = 7;
            MidLowerTrackbar.TickStyle = TickStyle.TopLeft;
            MidLowerTrackbar.Scroll += MidLowerTrackbar_Scroll;
            // 
            // MidUpperTrackbar
            // 
            MidUpperTrackbar.Location = new Point(189, 99);
            MidUpperTrackbar.Maximum = 255;
            MidUpperTrackbar.Name = "MidUpperTrackbar";
            MidUpperTrackbar.Size = new Size(203, 45);
            MidUpperTrackbar.TabIndex = 6;
            MidUpperTrackbar.Scroll += MidUpperTrackbar_Scroll;
            // 
            // BottomLowerTrackbar
            // 
            BottomLowerTrackbar.Location = new Point(189, 205);
            BottomLowerTrackbar.Maximum = 255;
            BottomLowerTrackbar.Name = "BottomLowerTrackbar";
            BottomLowerTrackbar.Size = new Size(203, 45);
            BottomLowerTrackbar.TabIndex = 9;
            BottomLowerTrackbar.TickStyle = TickStyle.TopLeft;
            BottomLowerTrackbar.Scroll += BottomLowerTrackbar_Scroll;
            // 
            // BottomUpperTrackbar
            // 
            BottomUpperTrackbar.Location = new Point(189, 180);
            BottomUpperTrackbar.Maximum = 255;
            BottomUpperTrackbar.Name = "BottomUpperTrackbar";
            BottomUpperTrackbar.Size = new Size(203, 45);
            BottomUpperTrackbar.TabIndex = 8;
            BottomUpperTrackbar.Scroll += BottomUpperTrackbar_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 40);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 10;
            label1.Text = "Red";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 118);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 11;
            label2.Text = "Green";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(159, 201);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 12;
            label3.Text = "Blue";
            // 
            // ConvertToHSVButton
            // 
            ConvertToHSVButton.Location = new Point(3, 206);
            ConvertToHSVButton.Name = "ConvertToHSVButton";
            ConvertToHSVButton.Size = new Size(150, 23);
            ConvertToHSVButton.TabIndex = 13;
            ConvertToHSVButton.Text = "Use HSV";
            ConvertToHSVButton.UseVisualStyleBackColor = true;
            ConvertToHSVButton.Click += ConvertToHSVButton_Click;
            // 
            // ConvertToRGBButton
            // 
            ConvertToRGBButton.Location = new Point(3, 235);
            ConvertToRGBButton.Name = "ConvertToRGBButton";
            ConvertToRGBButton.Size = new Size(150, 23);
            ConvertToRGBButton.TabIndex = 14;
            ConvertToRGBButton.Text = "Use RGB";
            ConvertToRGBButton.UseVisualStyleBackColor = true;
            ConvertToRGBButton.Click += ConvertToRGBButton_Click;
            // 
            // Up1ImgBox
            // 
            Up1ImgBox.BorderStyle = BorderStyle.FixedSingle;
            Up1ImgBox.Location = new Point(402, 15);
            Up1ImgBox.Name = "Up1ImgBox";
            Up1ImgBox.Size = new Size(30, 30);
            Up1ImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            Up1ImgBox.TabIndex = 2;
            Up1ImgBox.TabStop = false;
            // 
            // Up2ImgBox
            // 
            Up2ImgBox.BorderStyle = BorderStyle.FixedSingle;
            Up2ImgBox.Location = new Point(438, 15);
            Up2ImgBox.Name = "Up2ImgBox";
            Up2ImgBox.Size = new Size(30, 30);
            Up2ImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            Up2ImgBox.TabIndex = 15;
            Up2ImgBox.TabStop = false;
            // 
            // Up3ImgBox
            // 
            Up3ImgBox.BorderStyle = BorderStyle.FixedSingle;
            Up3ImgBox.Location = new Point(474, 15);
            Up3ImgBox.Name = "Up3ImgBox";
            Up3ImgBox.Size = new Size(30, 30);
            Up3ImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            Up3ImgBox.TabIndex = 16;
            Up3ImgBox.TabStop = false;
            // 
            // Low3ImgBox
            // 
            Low3ImgBox.BorderStyle = BorderStyle.FixedSingle;
            Low3ImgBox.Location = new Point(474, 207);
            Low3ImgBox.Name = "Low3ImgBox";
            Low3ImgBox.Size = new Size(30, 30);
            Low3ImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            Low3ImgBox.TabIndex = 19;
            Low3ImgBox.TabStop = false;
            // 
            // Low2ImgBox
            // 
            Low2ImgBox.BorderStyle = BorderStyle.FixedSingle;
            Low2ImgBox.Location = new Point(438, 207);
            Low2ImgBox.Name = "Low2ImgBox";
            Low2ImgBox.Size = new Size(30, 30);
            Low2ImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            Low2ImgBox.TabIndex = 18;
            Low2ImgBox.TabStop = false;
            // 
            // Low1ImgBox
            // 
            Low1ImgBox.BorderStyle = BorderStyle.FixedSingle;
            Low1ImgBox.Location = new Point(402, 207);
            Low1ImgBox.Name = "Low1ImgBox";
            Low1ImgBox.Size = new Size(30, 30);
            Low1ImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            Low1ImgBox.TabIndex = 17;
            Low1ImgBox.TabStop = false;
            // 
            // Up4ImgBox
            // 
            Up4ImgBox.BorderStyle = BorderStyle.FixedSingle;
            Up4ImgBox.Location = new Point(522, 15);
            Up4ImgBox.Name = "Up4ImgBox";
            Up4ImgBox.Size = new Size(30, 30);
            Up4ImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            Up4ImgBox.TabIndex = 20;
            Up4ImgBox.TabStop = false;
            // 
            // Low4ImgBox
            // 
            Low4ImgBox.BorderStyle = BorderStyle.FixedSingle;
            Low4ImgBox.Location = new Point(522, 207);
            Low4ImgBox.Name = "Low4ImgBox";
            Low4ImgBox.Size = new Size(30, 30);
            Low4ImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            Low4ImgBox.TabIndex = 21;
            Low4ImgBox.TabStop = false;
            // 
            // InRange
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Low4ImgBox);
            Controls.Add(Up4ImgBox);
            Controls.Add(Low3ImgBox);
            Controls.Add(Low2ImgBox);
            Controls.Add(Low1ImgBox);
            Controls.Add(Up3ImgBox);
            Controls.Add(Up2ImgBox);
            Controls.Add(Up1ImgBox);
            Controls.Add(ConvertToRGBButton);
            Controls.Add(ConvertToHSVButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BottomLowerTrackbar);
            Controls.Add(BottomUpperTrackbar);
            Controls.Add(MidLowerTrackbar);
            Controls.Add(MidUpperTrackbar);
            Controls.Add(TopLowerTrackbar);
            Controls.Add(TopUpperTrackbar);
            Controls.Add(OutImgBox);
            Controls.Add(InImgBox);
            Name = "InRange";
            Size = new Size(653, 302);
            ((System.ComponentModel.ISupportInitialize)InImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)OutImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)TopUpperTrackbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)TopLowerTrackbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)MidLowerTrackbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)MidUpperTrackbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BottomLowerTrackbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BottomUpperTrackbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Up1ImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Up2ImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Up3ImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Low3ImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Low2ImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Low1ImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Up4ImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Low4ImgBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Emgu.CV.UI.ImageBox InImgBox;
        private Emgu.CV.UI.ImageBox OutImgBox;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private TrackBar TopUpperTrackbar;
        private TrackBar TopLowerTrackbar;
        private TrackBar MidLowerTrackbar;
        private TrackBar MidUpperTrackbar;
        private TrackBar BottomLowerTrackbar;
        private TrackBar BottomUpperTrackbar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button ConvertToHSVButton;
        private Button ConvertToRGBButton;
        private Emgu.CV.UI.ImageBox Up1ImgBox;
        private Emgu.CV.UI.ImageBox Up2ImgBox;
        private Emgu.CV.UI.ImageBox Up3ImgBox;
        private Emgu.CV.UI.ImageBox Low3ImgBox;
        private Emgu.CV.UI.ImageBox Low2ImgBox;
        private Emgu.CV.UI.ImageBox Low1ImgBox;
        private Emgu.CV.UI.ImageBox Up4ImgBox;
        private Emgu.CV.UI.ImageBox Low4ImgBox;
    }
}
