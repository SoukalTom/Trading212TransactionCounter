using Trading212TransactionCounter;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String filePath;
        private FileProcessor fileProcess = new FileProcessor();

        private void fileBrowserButton_Click(object sender, EventArgs e)
        {
            // Create a new instance of OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set filter options for the types of files (optional)
            openFileDialog.Filter = "Text Files (*.csv)|*.csv";

            // Show the file dialog and check if the user selected a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path
                filePath = openFileDialog.FileName;
            }
        }

        private void confirmFilePath_Click(object sender, EventArgs e)
        {
            if (filePath != null)
            {
                List<float> resultValues = fileProcess.processSelectedFile(filePath);
                textBox1.Text = resultValues[0].ToString();
                textBox2.Text = resultValues[1].ToString();
            }
        }
    }
}
