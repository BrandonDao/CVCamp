namespace ComputerVisionTool.Controls.Operations
{
    partial class BitwiseOp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BitwiseOp));
            InputImgA = new CustomControls.ImageInput();
            InputImgB = new CustomControls.ImageInput();
            OutputImg = new CustomControls.ImageOutput();
            ArrowLabel = new Label();
            OpComboBox = new ComboBox();
            UpdateNamedInputsButton = new Button();
            SuspendLayout();
            // 
            // InputImgA
            // 
            InputImgA.CallWhenChanged = null;
            InputImgA.Location = new Point(3, 3);
            InputImgA.Name = "InputImgA";
            InputImgA.OpInfo = null;
            InputImgA.Size = new Size(156, 186);
            InputImgA.TabIndex = 0;
            // 
            // InputImgB
            // 
            InputImgB.CallWhenChanged = null;
            InputImgB.Location = new Point(165, 3);
            InputImgB.Name = "InputImgB";
            InputImgB.OpInfo = null;
            InputImgB.Size = new Size(156, 186);
            InputImgB.TabIndex = 1;
            // 
            // OutputImg
            // 
            OutputImg.Location = new Point(412, 3);
            OutputImg.Mat = (Emgu.CV.Mat)resources.GetObject("OutputImg.Mat");
            OutputImg.Name = "OutputImg";
            OutputImg.OpInfo = null;
            OutputImg.Size = new Size(157, 216);
            OutputImg.TabIndex = 2;
            // 
            // ArrowLabel
            // 
            ArrowLabel.AutoSize = true;
            ArrowLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ArrowLabel.Location = new Point(343, 86);
            ArrowLabel.Name = "ArrowLabel";
            ArrowLabel.Size = new Size(46, 37);
            ArrowLabel.TabIndex = 3;
            ArrowLabel.Text = "->";
            // 
            // OpComboBox
            // 
            OpComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            OpComboBox.FormattingEnabled = true;
            OpComboBox.Location = new Point(327, 126);
            OpComboBox.Name = "OpComboBox";
            OpComboBox.Size = new Size(79, 23);
            OpComboBox.TabIndex = 4;
            OpComboBox.SelectedIndexChanged += OpComboBox_SelectedIndexChanged;
            // 
            // UpdateNamedInputsButton
            // 
            UpdateNamedInputsButton.Location = new Point(91, 191);
            UpdateNamedInputsButton.Name = "UpdateNamedInputsButton";
            UpdateNamedInputsButton.Size = new Size(131, 23);
            UpdateNamedInputsButton.TabIndex = 5;
            UpdateNamedInputsButton.Text = "Update Named Inputs";
            UpdateNamedInputsButton.UseVisualStyleBackColor = true;
            UpdateNamedInputsButton.Click += UpdateNamedInputsButton_Click;
            // 
            // BitwiseOp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(UpdateNamedInputsButton);
            Controls.Add(OpComboBox);
            Controls.Add(ArrowLabel);
            Controls.Add(OutputImg);
            Controls.Add(InputImgB);
            Controls.Add(InputImgA);
            Name = "BitwiseOp";
            Size = new Size(571, 220);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.ImageInput InputImgA;
        private CustomControls.ImageInput InputImgB;
        private CustomControls.ImageOutput OutputImg;
        private Label ArrowLabel;
        private ComboBox OpComboBox;
        private Button UpdateNamedInputsButton;
    }
}
