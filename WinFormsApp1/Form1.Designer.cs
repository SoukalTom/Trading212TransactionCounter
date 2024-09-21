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
            labelProfit = new Label();
            textBoxProfit = new TextBox();
            textBoxMarketSell = new TextBox();
            labelMarketSell = new Label();
            textBoxMarketBuy = new TextBox();
            labelMarketBuy = new Label();
            labelSelectedFile = new Label();
            textBoxDividend = new TextBox();
            labelDividend = new Label();
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
            fileBrowserButton.Size = new Size(95, 23);
            fileBrowserButton.TabIndex = 0;
            fileBrowserButton.Text = "Select File";
            fileBrowserButton.UseVisualStyleBackColor = true;
            fileBrowserButton.Click += fileBrowserButton_Click;
            // 
            // confirmFilePath
            // 
            confirmFilePath.Location = new Point(12, 248);
            confirmFilePath.Name = "confirmFilePath";
            confirmFilePath.Size = new Size(75, 23);
            confirmFilePath.TabIndex = 1;
            confirmFilePath.Text = "Calculate";
            confirmFilePath.UseVisualStyleBackColor = true;
            confirmFilePath.Click += confirmFilePath_Click;
            // 
            // labelProfit
            // 
            labelProfit.AutoSize = true;
            labelProfit.Location = new Point(12, 74);
            labelProfit.Name = "labelProfit";
            labelProfit.Size = new Size(36, 15);
            labelProfit.TabIndex = 2;
            labelProfit.Text = "Profit";
            // 
            // textBoxProfit
            // 
            textBoxProfit.Location = new Point(118, 74);
            textBoxProfit.Name = "textBoxProfit";
            textBoxProfit.ReadOnly = true;
            textBoxProfit.Size = new Size(100, 23);
            textBoxProfit.TabIndex = 3;
            // 
            // textBoxMarketSell
            // 
            textBoxMarketSell.Location = new Point(118, 114);
            textBoxMarketSell.Name = "textBoxMarketSell";
            textBoxMarketSell.ReadOnly = true;
            textBoxMarketSell.Size = new Size(100, 23);
            textBoxMarketSell.TabIndex = 5;
            // 
            // labelMarketSell
            // 
            labelMarketSell.AutoSize = true;
            labelMarketSell.Location = new Point(12, 114);
            labelMarketSell.Name = "labelMarketSell";
            labelMarketSell.Size = new Size(92, 15);
            labelMarketSell.TabIndex = 4;
            labelMarketSell.Text = "Total market sell";
            // 
            // textBoxMarketBuy
            // 
            textBoxMarketBuy.Location = new Point(118, 156);
            textBoxMarketBuy.Name = "textBoxMarketBuy";
            textBoxMarketBuy.ReadOnly = true;
            textBoxMarketBuy.Size = new Size(100, 23);
            textBoxMarketBuy.TabIndex = 7;
            // 
            // labelMarketBuy
            // 
            labelMarketBuy.AutoSize = true;
            labelMarketBuy.Location = new Point(12, 156);
            labelMarketBuy.Name = "labelMarketBuy";
            labelMarketBuy.Size = new Size(95, 15);
            labelMarketBuy.TabIndex = 6;
            labelMarketBuy.Text = "Total market buy";
            // 
            // labelSelectedFile
            // 
            labelSelectedFile.AutoSize = true;
            labelSelectedFile.Location = new Point(118, 30);
            labelSelectedFile.Name = "labelSelectedFile";
            labelSelectedFile.Size = new Size(111, 15);
            labelSelectedFile.TabIndex = 8;
            labelSelectedFile.Text = "No file was selected";
            // 
            // textBoxDividend
            // 
            textBoxDividend.Location = new Point(118, 199);
            textBoxDividend.Name = "textBoxDividend";
            textBoxDividend.ReadOnly = true;
            textBoxDividend.Size = new Size(100, 23);
            textBoxDividend.TabIndex = 10;
            // 
            // labelDividend
            // 
            labelDividend.AutoSize = true;
            labelDividend.Location = new Point(12, 199);
            labelDividend.Name = "labelDividend";
            labelDividend.Size = new Size(54, 15);
            labelDividend.TabIndex = 9;
            labelDividend.Text = "Dividend";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 450);
            Controls.Add(textBoxDividend);
            Controls.Add(labelDividend);
            Controls.Add(labelSelectedFile);
            Controls.Add(textBoxMarketBuy);
            Controls.Add(labelMarketBuy);
            Controls.Add(textBoxMarketSell);
            Controls.Add(labelMarketSell);
            Controls.Add(textBoxProfit);
            Controls.Add(labelProfit);
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
        private Label labelProfit;
        private TextBox textBoxProfit;
        private TextBox textBoxMarketSell;
        private Label labelMarketSell;
        private TextBox textBoxMarketBuy;
        private Label labelMarketBuy;
        private Label labelSelectedFile;
        private TextBox textBoxDividend;
        private Label labelDividend;
    }
}
