namespace Pong
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
            IsMirroredCheckbox = new CheckBox();
            CapturedFrameImgBox = new Emgu.CV.UI.ImageBox();
            CaptureButton = new Button();
            InRangeImgBox = new Emgu.CV.UI.ImageBox();
            VarianceTrackbar = new TrackBar();
            ErodeImgBox = new Emgu.CV.UI.ImageBox();
            ErodeKernelSizeTrackbar = new TrackBar();
            ErodeIterationsTrackbar = new TrackBar();
            GamePictureBox = new PictureBox();
            openFileDialog = new OpenFileDialog();
            CapturedFrameLabel = new Label();
            ErodeLabel = new Label();
            InRangeLabel = new Label();
            CapturedColorImgBox = new Emgu.CV.UI.ImageBox();
            CapturedColorLabel = new Label();
            DilateLabel = new Label();
            DilateIterationsTrackbar = new TrackBar();
            DilateKernelSizeTrackbar = new TrackBar();
            DilateImgBox = new Emgu.CV.UI.ImageBox();
            LinkDilateErodeCheckbox = new CheckBox();
            InRangeVarianceLabel = new Label();
            DilateErodeKernelSizeLabel = new Label();
            DilateErodeIterationsLabel = new Label();
            StartLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)CameraImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CapturedFrameImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InRangeImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VarianceTrackbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErodeImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErodeKernelSizeTrackbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErodeIterationsTrackbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GamePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CapturedColorImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DilateIterationsTrackbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DilateKernelSizeTrackbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DilateImgBox).BeginInit();
            SuspendLayout();
            // 
            // CameraImgBox
            // 
            CameraImgBox.Location = new Point(12, 12);
            CameraImgBox.Name = "CameraImgBox";
            CameraImgBox.Size = new Size(498, 321);
            CameraImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            CameraImgBox.TabIndex = 2;
            CameraImgBox.TabStop = false;
            // 
            // IsMirroredCheckbox
            // 
            IsMirroredCheckbox.AutoSize = true;
            IsMirroredCheckbox.Checked = true;
            IsMirroredCheckbox.CheckState = CheckState.Checked;
            IsMirroredCheckbox.ForeColor = SystemColors.ControlLightLight;
            IsMirroredCheckbox.Location = new Point(12, 339);
            IsMirroredCheckbox.Name = "IsMirroredCheckbox";
            IsMirroredCheckbox.Size = new Size(103, 19);
            IsMirroredCheckbox.TabIndex = 3;
            IsMirroredCheckbox.Text = "Mirror Camera";
            IsMirroredCheckbox.UseVisualStyleBackColor = true;
            // 
            // CapturedFrameImgBox
            // 
            CapturedFrameImgBox.Location = new Point(12, 389);
            CapturedFrameImgBox.Name = "CapturedFrameImgBox";
            CapturedFrameImgBox.Size = new Size(120, 90);
            CapturedFrameImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            CapturedFrameImgBox.TabIndex = 4;
            CapturedFrameImgBox.TabStop = false;
            CapturedFrameImgBox.Click += CaptureImgBox_Click;
            // 
            // CaptureButton
            // 
            CaptureButton.BackColor = SystemColors.Desktop;
            CaptureButton.Cursor = Cursors.Hand;
            CaptureButton.FlatStyle = FlatStyle.Flat;
            CaptureButton.ForeColor = SystemColors.Control;
            CaptureButton.Location = new Point(12, 485);
            CaptureButton.Name = "CaptureButton";
            CaptureButton.Size = new Size(118, 43);
            CaptureButton.TabIndex = 5;
            CaptureButton.Text = "Capture Current Frame";
            CaptureButton.UseVisualStyleBackColor = false;
            CaptureButton.Click += CaptureButton_Click;
            // 
            // InRangeImgBox
            // 
            InRangeImgBox.BorderStyle = BorderStyle.FixedSingle;
            InRangeImgBox.Location = new Point(138, 389);
            InRangeImgBox.Name = "InRangeImgBox";
            InRangeImgBox.Size = new Size(120, 90);
            InRangeImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            InRangeImgBox.TabIndex = 7;
            InRangeImgBox.TabStop = false;
            // 
            // VarianceTrackbar
            // 
            VarianceTrackbar.Cursor = Cursors.Hand;
            VarianceTrackbar.Location = new Point(132, 499);
            VarianceTrackbar.Maximum = 150;
            VarianceTrackbar.Name = "VarianceTrackbar";
            VarianceTrackbar.Size = new Size(130, 45);
            VarianceTrackbar.TabIndex = 8;
            VarianceTrackbar.Scroll += VarianceTrackbar_Scroll;
            // 
            // ErodeImgBox
            // 
            ErodeImgBox.BorderStyle = BorderStyle.FixedSingle;
            ErodeImgBox.Location = new Point(264, 389);
            ErodeImgBox.Name = "ErodeImgBox";
            ErodeImgBox.Size = new Size(120, 90);
            ErodeImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            ErodeImgBox.TabIndex = 9;
            ErodeImgBox.TabStop = false;
            // 
            // ErodeKernelSizeTrackbar
            // 
            ErodeKernelSizeTrackbar.Cursor = Cursors.Hand;
            ErodeKernelSizeTrackbar.Location = new Point(259, 499);
            ErodeKernelSizeTrackbar.Maximum = 50;
            ErodeKernelSizeTrackbar.Minimum = 1;
            ErodeKernelSizeTrackbar.Name = "ErodeKernelSizeTrackbar";
            ErodeKernelSizeTrackbar.Size = new Size(130, 45);
            ErodeKernelSizeTrackbar.TabIndex = 10;
            ErodeKernelSizeTrackbar.Value = 1;
            ErodeKernelSizeTrackbar.Scroll += ErodeKernelSizeTrackbar_Scroll;
            // 
            // ErodeIterationsTrackbar
            // 
            ErodeIterationsTrackbar.Cursor = Cursors.Hand;
            ErodeIterationsTrackbar.Location = new Point(259, 549);
            ErodeIterationsTrackbar.Maximum = 20;
            ErodeIterationsTrackbar.Name = "ErodeIterationsTrackbar";
            ErodeIterationsTrackbar.Size = new Size(130, 45);
            ErodeIterationsTrackbar.TabIndex = 11;
            ErodeIterationsTrackbar.Scroll += ErodeIterationsTrackbar_Scroll;
            // 
            // GamePictureBox
            // 
            GamePictureBox.BorderStyle = BorderStyle.FixedSingle;
            GamePictureBox.Location = new Point(516, 12);
            GamePictureBox.Name = "GamePictureBox";
            GamePictureBox.Size = new Size(925, 595);
            GamePictureBox.TabIndex = 12;
            GamePictureBox.TabStop = false;
            GamePictureBox.Click += GamePictureBox_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // CapturedFrameLabel
            // 
            CapturedFrameLabel.AutoSize = true;
            CapturedFrameLabel.ForeColor = SystemColors.ControlLightLight;
            CapturedFrameLabel.Location = new Point(26, 371);
            CapturedFrameLabel.Name = "CapturedFrameLabel";
            CapturedFrameLabel.Size = new Size(92, 15);
            CapturedFrameLabel.TabIndex = 13;
            CapturedFrameLabel.Text = "Captured Frame";
            CapturedFrameLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ErodeLabel
            // 
            ErodeLabel.AutoSize = true;
            ErodeLabel.ForeColor = SystemColors.ControlLightLight;
            ErodeLabel.Location = new Point(306, 371);
            ErodeLabel.Name = "ErodeLabel";
            ErodeLabel.Size = new Size(37, 15);
            ErodeLabel.TabIndex = 14;
            ErodeLabel.Text = "Erode";
            ErodeLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // InRangeLabel
            // 
            InRangeLabel.AutoSize = true;
            InRangeLabel.ForeColor = SystemColors.ControlLightLight;
            InRangeLabel.Location = new Point(173, 371);
            InRangeLabel.Name = "InRangeLabel";
            InRangeLabel.Size = new Size(53, 15);
            InRangeLabel.TabIndex = 15;
            InRangeLabel.Text = "In Range";
            InRangeLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // CapturedColorImgBox
            // 
            CapturedColorImgBox.BorderStyle = BorderStyle.FixedSingle;
            CapturedColorImgBox.Location = new Point(12, 547);
            CapturedColorImgBox.Name = "CapturedColorImgBox";
            CapturedColorImgBox.Size = new Size(50, 50);
            CapturedColorImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            CapturedColorImgBox.TabIndex = 16;
            CapturedColorImgBox.TabStop = false;
            // 
            // CapturedColorLabel
            // 
            CapturedColorLabel.AutoSize = true;
            CapturedColorLabel.ForeColor = SystemColors.ControlLightLight;
            CapturedColorLabel.Location = new Point(68, 565);
            CapturedColorLabel.Name = "CapturedColorLabel";
            CapturedColorLabel.Size = new Size(88, 15);
            CapturedColorLabel.TabIndex = 17;
            CapturedColorLabel.Text = "Captured Color";
            CapturedColorLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // DilateLabel
            // 
            DilateLabel.AutoSize = true;
            DilateLabel.ForeColor = SystemColors.ControlLightLight;
            DilateLabel.Location = new Point(432, 371);
            DilateLabel.Name = "DilateLabel";
            DilateLabel.Size = new Size(37, 15);
            DilateLabel.TabIndex = 21;
            DilateLabel.Text = "Dilate";
            DilateLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // DilateIterationsTrackbar
            // 
            DilateIterationsTrackbar.Cursor = Cursors.Hand;
            DilateIterationsTrackbar.Enabled = false;
            DilateIterationsTrackbar.Location = new Point(385, 549);
            DilateIterationsTrackbar.Maximum = 20;
            DilateIterationsTrackbar.Name = "DilateIterationsTrackbar";
            DilateIterationsTrackbar.Size = new Size(130, 45);
            DilateIterationsTrackbar.TabIndex = 20;
            // 
            // DilateKernelSizeTrackbar
            // 
            DilateKernelSizeTrackbar.Cursor = Cursors.Hand;
            DilateKernelSizeTrackbar.Enabled = false;
            DilateKernelSizeTrackbar.Location = new Point(385, 499);
            DilateKernelSizeTrackbar.Maximum = 50;
            DilateKernelSizeTrackbar.Minimum = 1;
            DilateKernelSizeTrackbar.Name = "DilateKernelSizeTrackbar";
            DilateKernelSizeTrackbar.Size = new Size(130, 45);
            DilateKernelSizeTrackbar.TabIndex = 19;
            DilateKernelSizeTrackbar.Value = 1;
            DilateKernelSizeTrackbar.Scroll += DilateKernelSizeTrackbar_Scroll;
            // 
            // DilateImgBox
            // 
            DilateImgBox.BorderStyle = BorderStyle.FixedSingle;
            DilateImgBox.Location = new Point(390, 389);
            DilateImgBox.Name = "DilateImgBox";
            DilateImgBox.Size = new Size(120, 90);
            DilateImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            DilateImgBox.TabIndex = 18;
            DilateImgBox.TabStop = false;
            // 
            // LinkDilateErodeCheckbox
            // 
            LinkDilateErodeCheckbox.AutoSize = true;
            LinkDilateErodeCheckbox.Checked = true;
            LinkDilateErodeCheckbox.CheckState = CheckState.Checked;
            LinkDilateErodeCheckbox.ForeColor = SystemColors.ControlLightLight;
            LinkDilateErodeCheckbox.Location = new Point(339, 585);
            LinkDilateErodeCheckbox.Name = "LinkDilateErodeCheckbox";
            LinkDilateErodeCheckbox.Size = new Size(84, 19);
            LinkDilateErodeCheckbox.TabIndex = 22;
            LinkDilateErodeCheckbox.Text = "Link Values";
            LinkDilateErodeCheckbox.UseVisualStyleBackColor = true;
            LinkDilateErodeCheckbox.CheckedChanged += LinkDilateErodeCheckbox_CheckedChanged;
            // 
            // InRangeVarianceLabel
            // 
            InRangeVarianceLabel.AutoSize = true;
            InRangeVarianceLabel.ForeColor = SystemColors.ControlLightLight;
            InRangeVarianceLabel.Location = new Point(138, 482);
            InRangeVarianceLabel.Name = "InRangeVarianceLabel";
            InRangeVarianceLabel.Size = new Size(51, 15);
            InRangeVarianceLabel.TabIndex = 23;
            InRangeVarianceLabel.Text = "Variance";
            // 
            // DilateErodeKernelSizeLabel
            // 
            DilateErodeKernelSizeLabel.AutoSize = true;
            DilateErodeKernelSizeLabel.ForeColor = SystemColors.ControlLightLight;
            DilateErodeKernelSizeLabel.Location = new Point(264, 482);
            DilateErodeKernelSizeLabel.Name = "DilateErodeKernelSizeLabel";
            DilateErodeKernelSizeLabel.Size = new Size(63, 15);
            DilateErodeKernelSizeLabel.TabIndex = 24;
            DilateErodeKernelSizeLabel.Text = "Kernel Size";
            // 
            // DilateErodeIterationsLabel
            // 
            DilateErodeIterationsLabel.AutoSize = true;
            DilateErodeIterationsLabel.Location = new Point(264, 532);
            DilateErodeIterationsLabel.Name = "DilateErodeIterationsLabel";
            DilateErodeIterationsLabel.Size = new Size(56, 15);
            DilateErodeIterationsLabel.TabIndex = 25;
            DilateErodeIterationsLabel.Text = "Iterations";
            // 
            // StartLabel
            // 
            StartLabel.AutoSize = true;
            StartLabel.BackColor = SystemColors.ActiveCaptionText;
            StartLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            StartLabel.ForeColor = SystemColors.ButtonFace;
            StartLabel.Location = new Point(934, 299);
            StartLabel.Name = "StartLabel";
            StartLabel.Size = new Size(157, 21);
            StartLabel.TabIndex = 26;
            StartLabel.Text = "Click Game To Start";
            StartLabel.Click += StartLabel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1453, 619);
            Controls.Add(StartLabel);
            Controls.Add(DilateErodeIterationsLabel);
            Controls.Add(DilateErodeKernelSizeLabel);
            Controls.Add(InRangeVarianceLabel);
            Controls.Add(LinkDilateErodeCheckbox);
            Controls.Add(DilateLabel);
            Controls.Add(DilateIterationsTrackbar);
            Controls.Add(DilateKernelSizeTrackbar);
            Controls.Add(DilateImgBox);
            Controls.Add(CapturedColorLabel);
            Controls.Add(CapturedColorImgBox);
            Controls.Add(InRangeLabel);
            Controls.Add(ErodeLabel);
            Controls.Add(CapturedFrameLabel);
            Controls.Add(GamePictureBox);
            Controls.Add(ErodeIterationsTrackbar);
            Controls.Add(ErodeKernelSizeTrackbar);
            Controls.Add(ErodeImgBox);
            Controls.Add(VarianceTrackbar);
            Controls.Add(InRangeImgBox);
            Controls.Add(CaptureButton);
            Controls.Add(CapturedFrameImgBox);
            Controls.Add(IsMirroredCheckbox);
            Controls.Add(CameraImgBox);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Pong";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)CameraImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)CapturedFrameImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)InRangeImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)VarianceTrackbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErodeImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErodeKernelSizeTrackbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErodeIterationsTrackbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)GamePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)CapturedColorImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)DilateIterationsTrackbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)DilateKernelSizeTrackbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)DilateImgBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Emgu.CV.UI.ImageBox CameraImgBox;
        private CheckBox IsMirroredCheckbox;
        private Emgu.CV.UI.ImageBox CapturedFrameImgBox;
        private Button CaptureButton;
        private Emgu.CV.UI.ImageBox InRangeImgBox;
        private TrackBar VarianceTrackbar;
        private Emgu.CV.UI.ImageBox ErodeImgBox;
        private TrackBar ErodeKernelSizeTrackbar;
        private TrackBar ErodeIterationsTrackbar;
        private PictureBox GamePictureBox;
        private OpenFileDialog openFileDialog;
        private Label CapturedFrameLabel;
        private Label ErodeLabel;
        private Label InRangeLabel;
        private Emgu.CV.UI.ImageBox CapturedColorImgBox;
        private Label CapturedColorLabel;
        private Label DilateLabel;
        private TrackBar DilateIterationsTrackbar;
        private TrackBar DilateKernelSizeTrackbar;
        private Emgu.CV.UI.ImageBox DilateImgBox;
        private CheckBox LinkDilateErodeCheckbox;
        private Label InRangeVarianceLabel;
        private Label DilateErodeKernelSizeLabel;
        private Label DilateErodeIterationsLabel;
        private Label StartLabel;
    }
}