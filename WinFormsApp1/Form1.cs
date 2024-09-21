using Trading212TransactionCounter;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // File path
        String filePath;
        // Create new instance of FileProcessor
        private FileProcessor fileProcess = new FileProcessor();

        private void fileBrowserButton_Click(object sender, EventArgs e)
        {
            // Create a new instance of OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set filter options for csv
            openFileDialog.Filter = "Text Files (*.csv)|*.csv";

            // Show the file dialog and check if the user selected a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path
                filePath = openFileDialog.FileName;
                // Show the selected file path to user
                labelSelectedFile.Text = filePath;
            }
        }

        private void confirmFilePath_Click(object sender, EventArgs e)
        {
            if (filePath != null)
            {
                // Returns list with values ready to display
                List<float> resultValues = fileProcess.processSelectedFile(filePath);

                // Display all values
                textBoxProfit.Text = resultValues[0].ToString();
                textBoxMarketSell.Text = resultValues[1].ToString();
                textBoxMarketBuy.Text = resultValues[2].ToString();
                textBoxDividend.Text = resultValues[3].ToString();
            }
        }
    }
}
