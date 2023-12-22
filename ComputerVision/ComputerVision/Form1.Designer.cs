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
            Bitwise_ImgSelectionDialog = new OpenFileDialog();
            TabControl = new TabControl();
            Bitwise_TabPage = new TabPage();
            bitwiseOp2 = new ComputerVision.BitwiseOp();
            ROI_TabPage = new TabPage();
            roiOp1 = new ComputerVision.Controls.ROIOp();
            RotateFlipTabPage = new TabPage();
            rotateFlipOp1 = new ComputerVision.Controls.RotateFlipOp();
            ResizeTabPage = new TabPage();
            resizeOp1 = new ComputerVision.Controls.ResizeOp();
            InRangeTabPage = new TabPage();
            inRange1 = new ComputerVision.Controls.InRange();
            tabPage1 = new TabPage();
            convertColorOp1 = new ComputerVision.Controls.ConvertColorOp();
            ThresholdTabPage = new TabPage();
            threshold1 = new ComputerVision.Controls.Threshold();
            CopyToTabPage = new TabPage();
            copyToOp1 = new ComputerVision.Controls.CopyToOp();
            BlurTabPage = new TabPage();
            blurOp1 = new ComputerVision.Controls.BlurOp();
            TabControl.SuspendLayout();
            Bitwise_TabPage.SuspendLayout();
            ROI_TabPage.SuspendLayout();
            RotateFlipTabPage.SuspendLayout();
            ResizeTabPage.SuspendLayout();
            InRangeTabPage.SuspendLayout();
            tabPage1.SuspendLayout();
            ThresholdTabPage.SuspendLayout();
            CopyToTabPage.SuspendLayout();
            BlurTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // Bitwise_ImgSelectionDialog
            // 
            Bitwise_ImgSelectionDialog.FileName = "Bitwise_ImgSelectionDialog";
            // 
            // TabControl
            // 
            TabControl.Controls.Add(Bitwise_TabPage);
            TabControl.Controls.Add(ROI_TabPage);
            TabControl.Controls.Add(RotateFlipTabPage);
            TabControl.Controls.Add(ResizeTabPage);
            TabControl.Controls.Add(InRangeTabPage);
            TabControl.Controls.Add(tabPage1);
            TabControl.Controls.Add(ThresholdTabPage);
            TabControl.Controls.Add(CopyToTabPage);
            TabControl.Controls.Add(BlurTabPage);
            TabControl.Location = new Point(12, 12);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(703, 328);
            TabControl.TabIndex = 8;
            // 
            // Bitwise_TabPage
            // 
            Bitwise_TabPage.Controls.Add(bitwiseOp2);
            Bitwise_TabPage.Location = new Point(4, 24);
            Bitwise_TabPage.Name = "Bitwise_TabPage";
            Bitwise_TabPage.Padding = new Padding(3);
            Bitwise_TabPage.Size = new Size(654, 300);
            Bitwise_TabPage.TabIndex = 1;
            Bitwise_TabPage.Text = "Bitwise";
            Bitwise_TabPage.UseVisualStyleBackColor = true;
            // 
            // bitwiseOp2
            // 
            bitwiseOp2.Location = new Point(6, 6);
            bitwiseOp2.Name = "bitwiseOp2";
            bitwiseOp2.Size = new Size(521, 190);
            bitwiseOp2.TabIndex = 0;
            // 
            // ROI_TabPage
            // 
            ROI_TabPage.Controls.Add(roiOp1);
            ROI_TabPage.Location = new Point(4, 24);
            ROI_TabPage.Name = "ROI_TabPage";
            ROI_TabPage.Padding = new Padding(3);
            ROI_TabPage.Size = new Size(654, 300);
            ROI_TabPage.TabIndex = 4;
            ROI_TabPage.Text = "ROI";
            ROI_TabPage.UseVisualStyleBackColor = true;
            // 
            // roiOp1
            // 
            roiOp1.Location = new Point(6, 6);
            roiOp1.Name = "roiOp1";
            roiOp1.Size = new Size(571, 180);
            roiOp1.TabIndex = 0;
            // 
            // RotateFlipTabPage
            // 
            RotateFlipTabPage.Controls.Add(rotateFlipOp1);
            RotateFlipTabPage.Location = new Point(4, 24);
            RotateFlipTabPage.Name = "RotateFlipTabPage";
            RotateFlipTabPage.Padding = new Padding(3);
            RotateFlipTabPage.Size = new Size(654, 300);
            RotateFlipTabPage.TabIndex = 5;
            RotateFlipTabPage.Text = "Rotate & Flip";
            RotateFlipTabPage.UseVisualStyleBackColor = true;
            // 
            // rotateFlipOp1
            // 
            rotateFlipOp1.Location = new Point(6, 6);
            rotateFlipOp1.Name = "rotateFlipOp1";
            rotateFlipOp1.Size = new Size(365, 186);
            rotateFlipOp1.TabIndex = 0;
            // 
            // ResizeTabPage
            // 
            ResizeTabPage.Controls.Add(resizeOp1);
            ResizeTabPage.Location = new Point(4, 24);
            ResizeTabPage.Name = "ResizeTabPage";
            ResizeTabPage.Padding = new Padding(3);
            ResizeTabPage.Size = new Size(654, 300);
            ResizeTabPage.TabIndex = 6;
            ResizeTabPage.Text = "Resize";
            ResizeTabPage.UseVisualStyleBackColor = true;
            // 
            // resizeOp1
            // 
            resizeOp1.Location = new Point(6, 6);
            resizeOp1.Name = "resizeOp1";
            resizeOp1.Size = new Size(419, 159);
            resizeOp1.TabIndex = 0;
            // 
            // InRangeTabPage
            // 
            InRangeTabPage.Controls.Add(inRange1);
            InRangeTabPage.Location = new Point(4, 24);
            InRangeTabPage.Name = "InRangeTabPage";
            InRangeTabPage.Padding = new Padding(3);
            InRangeTabPage.Size = new Size(654, 300);
            InRangeTabPage.TabIndex = 7;
            InRangeTabPage.Text = "InRange";
            InRangeTabPage.UseVisualStyleBackColor = true;
            // 
            // inRange1
            // 
            inRange1.Location = new Point(6, 6);
            inRange1.Name = "inRange1";
            inRange1.Size = new Size(576, 302);
            inRange1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(convertColorOp1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(654, 300);
            tabPage1.TabIndex = 8;
            tabPage1.Text = "Convert Color";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // convertColorOp1
            // 
            convertColorOp1.Location = new Point(6, 6);
            convertColorOp1.Name = "convertColorOp1";
            convertColorOp1.Size = new Size(313, 188);
            convertColorOp1.TabIndex = 0;
            // 
            // ThresholdTabPage
            // 
            ThresholdTabPage.Controls.Add(threshold1);
            ThresholdTabPage.Location = new Point(4, 24);
            ThresholdTabPage.Name = "ThresholdTabPage";
            ThresholdTabPage.Padding = new Padding(3);
            ThresholdTabPage.Size = new Size(654, 300);
            ThresholdTabPage.TabIndex = 9;
            ThresholdTabPage.Text = "Threshold";
            ThresholdTabPage.UseVisualStyleBackColor = true;
            // 
            // threshold1
            // 
            threshold1.Location = new Point(6, 6);
            threshold1.Name = "threshold1";
            threshold1.Size = new Size(543, 183);
            threshold1.TabIndex = 0;
            // 
            // CopyToTabPage
            // 
            CopyToTabPage.Controls.Add(copyToOp1);
            CopyToTabPage.Location = new Point(4, 24);
            CopyToTabPage.Name = "CopyToTabPage";
            CopyToTabPage.Padding = new Padding(3);
            CopyToTabPage.Size = new Size(654, 300);
            CopyToTabPage.TabIndex = 10;
            CopyToTabPage.Text = "Copy To";
            CopyToTabPage.UseVisualStyleBackColor = true;
            // 
            // copyToOp1
            // 
            copyToOp1.Location = new Point(6, 6);
            copyToOp1.Name = "copyToOp1";
            copyToOp1.Size = new Size(562, 237);
            copyToOp1.TabIndex = 0;
            // 
            // BlurTabPage
            // 
            BlurTabPage.Controls.Add(blurOp1);
            BlurTabPage.Location = new Point(4, 24);
            BlurTabPage.Name = "BlurTabPage";
            BlurTabPage.Padding = new Padding(3);
            BlurTabPage.Size = new Size(695, 300);
            BlurTabPage.TabIndex = 12;
            BlurTabPage.Text = "Blur";
            BlurTabPage.UseVisualStyleBackColor = true;
            // 
            // blurOp1
            // 
            blurOp1.Location = new Point(6, 6);
            blurOp1.Name = "blurOp1";
            blurOp1.Size = new Size(655, 187);
            blurOp1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 352);
            Controls.Add(TabControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Fish 🐟";
            Load += Form1_Load;
            TabControl.ResumeLayout(false);
            Bitwise_TabPage.ResumeLayout(false);
            ROI_TabPage.ResumeLayout(false);
            RotateFlipTabPage.ResumeLayout(false);
            ResizeTabPage.ResumeLayout(false);
            InRangeTabPage.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ThresholdTabPage.ResumeLayout(false);
            CopyToTabPage.ResumeLayout(false);
            BlurTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private OpenFileDialog Bitwise_ImgSelectionDialog;
        private TabControl TabControl;
        private TabPage Bitwise_TabPage;
        private ComputerVision.BitwiseOp bitwiseOp1;
        private TabPage ROI_TabPage;
        private ComputerVision.Controls.ROIOp roiOp1;
        private TabPage RotateFlipTabPage;
        private TabPage ResizeTabPage;
        private ComputerVision.BitwiseOp bitwiseOp2;
        private ComputerVision.Controls.RotateFlipOp rotateFlipOp1;
        private ComputerVision.Controls.ResizeOp resizeOp1;
        private TabPage InRangeTabPage;
        private ComputerVision.Controls.InRange inRange1;
        private TabPage tabPage1;
        private ComputerVision.Controls.ConvertColorOp convertColorOp1;
        private TabPage ThresholdTabPage;
        private ComputerVision.Controls.Threshold threshold1;
        private TabPage CopyToTabPage;
        private ComputerVision.Controls.CopyToOp copyToOp1;
        private TabPage BlurTabPage;
        private ComputerVision.Controls.BlurOp blurOp1;
    }
}