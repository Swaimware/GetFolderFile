namespace GetFilesInFolder
{
    public partial class GetMediaList : Form
    {
        string directoryPath = string.Empty;
        List<string> listPaths = new List<string>();
        public GetMediaList()
        {
            InitializeComponent();
        }

        private void ChooseDirectoryButton_Click(object sender, EventArgs e)
        {
            // Creeate Folder Browser Dialog.
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            directoryPath = folderBrowserDialog.SelectedPath;
            if (directoryPath != "")
            {
                // Set the text of the text box to the path of the selected folder.
                DirectoryTextBox.Text = folderBrowserDialog.SelectedPath;

            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            TraverseDirectory(directoryPath);
            ResultRichTextBox.Clear();
            // Export listPaths to rich text box.
            foreach (string path in listPaths)
            {
                ResultRichTextBox.AppendText(path + "\n");
            }
        }
        private void TraverseDirectory(string directoryPath)
        {

            // Traverse all files in the directory.
            foreach (FileInfo fileInfo in new DirectoryInfo(directoryPath).GetFiles())
            {
                listPaths.Add(fileInfo.FullName);
            }
            if (IncludeSubDirCheckBox.Checked)
            {
                // Traverse all subdirectories in the directoryPath directory
                foreach (DirectoryInfo subDirectoryInfo in new DirectoryInfo(directoryPath).GetDirectories())
                {
                    TraverseDirectory(subDirectoryInfo.FullName);
                }
                
            }
        }

    }
}
