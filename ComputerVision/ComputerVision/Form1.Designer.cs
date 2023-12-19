namespace CVExercises
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
            outputPictureBox = new Emgu.CV.UI.ImageBox();
            LHSPictureBox = new Emgu.CV.UI.ImageBox();
            RHSPictureBox = new Emgu.CV.UI.ImageBox();
            ImageSelectionDialog = new OpenFileDialog();
            OperationDropdown = new ComboBox();
            SaveOutputButton = new Button();
            AutoNameCheckbox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)outputPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LHSPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RHSPictureBox).BeginInit();
            SuspendLayout();
            // 
            // outputPictureBox
            // 
            outputPictureBox.BackColor = SystemColors.ControlLight;
            outputPictureBox.BorderStyle = BorderStyle.FixedSingle;
            outputPictureBox.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            outputPictureBox.Location = new Point(524, 12);
            outputPictureBox.Name = "outputPictureBox";
            outputPictureBox.Size = new Size(250, 250);
            outputPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            outputPictureBox.TabIndex = 2;
            outputPictureBox.TabStop = false;
            outputPictureBox.Tag = 2;
            // 
            // LHSPictureBox
            // 
            LHSPictureBox.BackColor = SystemColors.ControlLight;
            LHSPictureBox.BorderStyle = BorderStyle.FixedSingle;
            LHSPictureBox.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            LHSPictureBox.Location = new Point(12, 12);
            LHSPictureBox.Name = "LHSPictureBox";
            LHSPictureBox.Size = new Size(250, 250);
            LHSPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            LHSPictureBox.TabIndex = 3;
            LHSPictureBox.TabStop = false;
            LHSPictureBox.Tag = 0;
            LHSPictureBox.DoubleClick += LHSPictureBox_DoubleClick;
            // 
            // RHSPictureBox
            // 
            RHSPictureBox.BackColor = SystemColors.ControlLight;
            RHSPictureBox.BorderStyle = BorderStyle.FixedSingle;
            RHSPictureBox.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            RHSPictureBox.Location = new Point(268, 12);
            RHSPictureBox.Name = "RHSPictureBox";
            RHSPictureBox.Size = new Size(250, 250);
            RHSPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            RHSPictureBox.TabIndex = 4;
            RHSPictureBox.TabStop = false;
            RHSPictureBox.Tag = 1;
            RHSPictureBox.DoubleClick += RHSPictureBox_DoubleClick;
            // 
            // ImageSelectionDialog
            // 
            ImageSelectionDialog.FileName = "ImageSelectionDialog";
            // 
            // OperationDropdown
            // 
            OperationDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            OperationDropdown.FormattingEnabled = true;
            OperationDropdown.Items.AddRange(new object[] { "NOT", "AND", "OR", "XOR" });
            OperationDropdown.Location = new Point(341, 267);
            OperationDropdown.Name = "OperationDropdown";
            OperationDropdown.Size = new Size(121, 23);
            OperationDropdown.TabIndex = 5;
            OperationDropdown.SelectedIndex = 0;
            OperationDropdown.SelectionChangeCommitted += OperationDropdown_SelectionChangeCommitted;
            // 
            // SaveOutputButton
            // 
            SaveOutputButton.Location = new Point(524, 267);
            SaveOutputButton.Name = "SaveOutputButton";
            SaveOutputButton.Size = new Size(75, 23);
            SaveOutputButton.TabIndex = 6;
            SaveOutputButton.Text = "Save Image";
            SaveOutputButton.UseVisualStyleBackColor = true;
            SaveOutputButton.Click += SaveOutputButton_Click;
            // 
            // AutoNameCheckbox
            // 
            AutoNameCheckbox.AutoSize = true;
            AutoNameCheckbox.Checked = true;
            AutoNameCheckbox.CheckState = CheckState.Checked;
            AutoNameCheckbox.Location = new Point(615, 270);
            AutoNameCheckbox.Name = "AutoNameCheckbox";
            AutoNameCheckbox.Size = new Size(159, 19);
            AutoNameCheckbox.TabIndex = 7;
            AutoNameCheckbox.Text = "Auto-Name Saved Image";
            AutoNameCheckbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 327);
            Controls.Add(AutoNameCheckbox);
            Controls.Add(SaveOutputButton);
            Controls.Add(OperationDropdown);
            Controls.Add(RHSPictureBox);
            Controls.Add(LHSPictureBox);
            Controls.Add(outputPictureBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)outputPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)LHSPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)RHSPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Emgu.CV.UI.ImageBox outputPictureBox;
        private Emgu.CV.UI.ImageBox LHSPictureBox;
        private Emgu.CV.UI.ImageBox RHSPictureBox;
        private OpenFileDialog ImageSelectionDialog;
        private ComboBox OperationDropdown;
        private Button SaveOutputButton;
        private CheckBox AutoNameCheckbox;
    }
}