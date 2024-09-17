namespace WinFormsApp1
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
            openFileDialog1 = new OpenFileDialog();
            fileBrowserButton = new Button();
            confirmFilePath = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileBrowserButton
            // 
            fileBrowserButton.Location = new Point(12, 26);
            fileBrowserButton.Name = "fileBrowserButton";
            fileBrowserButton.Size = new Size(75, 23);
            fileBrowserButton.TabIndex = 0;
            fileBrowserButton.Text = "Choose File";
            fileBrowserButton.UseVisualStyleBackColor = true;
            fileBrowserButton.Click += fileBrowserButton_Click;
            // 
            // confirmFilePath
            // 
            confirmFilePath.Location = new Point(103, 26);
            confirmFilePath.Name = "confirmFilePath";
            confirmFilePath.Size = new Size(75, 23);
            confirmFilePath.TabIndex = 1;
            confirmFilePath.Text = "Confirm";
            confirmFilePath.UseVisualStyleBackColor = true;
            confirmFilePath.Click += confirmFilePath_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 100);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 2;
            label1.Text = "Profit";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(118, 100);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(118, 140);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 140);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 4;
            label2.Text = "Total selling value";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 450);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(confirmFilePath);
            Controls.Add(fileBrowserButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button fileBrowserButton;
        private Button confirmFilePath;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
    }
}
