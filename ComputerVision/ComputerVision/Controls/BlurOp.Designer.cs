namespace ComputerVision.Controls
{
    partial class BlurOp
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
            KernelYTrackbar = new TrackBar();
            SaveButton = new Button();
            KernelXTrackbar = new TrackBar();
            BorderTypeComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)InImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OutImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KernelYTrackbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KernelXTrackbar).BeginInit();
            SuspendLayout();
            // 
            // InImgBox
            // 
            InImgBox.BorderStyle = BorderStyle.FixedSingle;
            InImgBox.Location = new Point(3, 3);
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
            OutImgBox.Location = new Point(501, 3);
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
            // KernelYTrackbar
            // 
            KernelYTrackbar.Location = new Point(159, 54);
            KernelYTrackbar.Maximum = 101;
            KernelYTrackbar.Minimum = 3;
            KernelYTrackbar.Name = "KernelYTrackbar";
            KernelYTrackbar.Size = new Size(336, 45);
            KernelYTrackbar.TabIndex = 4;
            KernelYTrackbar.TickFrequency = 2;
            KernelYTrackbar.Value = 3;
            KernelYTrackbar.Scroll += KernelYTrackbar_Scroll;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(539, 159);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 5;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // KernelXTrackbar
            // 
            KernelXTrackbar.Location = new Point(159, 3);
            KernelXTrackbar.Maximum = 101;
            KernelXTrackbar.Minimum = 3;
            KernelXTrackbar.Name = "KernelXTrackbar";
            KernelXTrackbar.Size = new Size(336, 45);
            KernelXTrackbar.TabIndex = 6;
            KernelXTrackbar.TickFrequency = 2;
            KernelXTrackbar.Value = 3;
            KernelXTrackbar.Scroll += KernelXTrackbar_Scroll;
            // 
            // OpTypeComboBox
            // 
            BorderTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            BorderTypeComboBox.FormattingEnabled = true;
            BorderTypeComboBox.Location = new Point(159, 105);
            BorderTypeComboBox.Name = "OpTypeComboBox";
            BorderTypeComboBox.Size = new Size(121, 23);
            BorderTypeComboBox.TabIndex = 7;
            BorderTypeComboBox.SelectedIndexChanged += OpTypeComboBox_SelectedIndexChanged;
            // 
            // BlurOp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BorderTypeComboBox);
            Controls.Add(KernelXTrackbar);
            Controls.Add(SaveButton);
            Controls.Add(KernelYTrackbar);
            Controls.Add(OutImgBox);
            Controls.Add(InImgBox);
            Name = "BlurOp";
            Size = new Size(655, 187);
            ((System.ComponentModel.ISupportInitialize)InImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)OutImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)KernelYTrackbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)KernelXTrackbar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Emgu.CV.UI.ImageBox InImgBox;
        private Emgu.CV.UI.ImageBox OutImgBox;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private TrackBar KernelYTrackbar;
        private Button SaveButton;
        private TrackBar KernelXTrackbar;
        private ComboBox BorderTypeComboBox;
    }
}
