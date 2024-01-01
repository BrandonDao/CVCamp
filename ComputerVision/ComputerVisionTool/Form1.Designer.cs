namespace ComputerVisionTool
{
    partial class CVToolsForm
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
            AddBitwiseButton = new Button();
            AddConvertColorButton = new Button();
            AddTabButton = new Button();
            SuspendLayout();
            // 
            // AddBitwiseButton
            // 
            AddBitwiseButton.Location = new Point(12, 75);
            AddBitwiseButton.Name = "AddBitwiseButton";
            AddBitwiseButton.Size = new Size(140, 23);
            AddBitwiseButton.TabIndex = 1;
            AddBitwiseButton.Text = "Add Bitwise";
            AddBitwiseButton.UseVisualStyleBackColor = true;
            AddBitwiseButton.Click += AddBitwiseButton_Click;
            // 
            // AddConvertColorButton
            // 
            AddConvertColorButton.Location = new Point(12, 104);
            AddConvertColorButton.Name = "AddConvertColorButton";
            AddConvertColorButton.Size = new Size(140, 23);
            AddConvertColorButton.TabIndex = 2;
            AddConvertColorButton.Text = "Add Color Converter";
            AddConvertColorButton.UseVisualStyleBackColor = true;
            AddConvertColorButton.Click += AddConvertColorButton_Click;
            // 
            // AddTabButton
            // 
            AddTabButton.Location = new Point(12, 12);
            AddTabButton.Name = "AddTabButton";
            AddTabButton.Size = new Size(140, 23);
            AddTabButton.TabIndex = 3;
            AddTabButton.Text = "Add Tab";
            AddTabButton.UseVisualStyleBackColor = true;
            AddTabButton.Click += AddTabButton_Click;
            // 
            // CVToolsForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(984, 461);
            Controls.Add(AddTabButton);
            Controls.Add(AddConvertColorButton);
            Controls.Add(AddBitwiseButton);
            MaximumSize = new Size(5000, 5000);
            MinimumSize = new Size(1000, 500);
            Name = "CVToolsForm";
            ShowIcon = false;
            Text = "CV Tool";
            Load += Form1_Load;
            ClientSizeChanged += CVToolsForm_ClientSizeChanged;
            ResumeLayout(false);
        }

        #endregion
        private Button AddBitwiseButton;
        private Button AddConvertColorButton;
        private Button AddTabButton;
    }
}