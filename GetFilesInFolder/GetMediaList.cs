using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Drawing.Text;
using System.IO;
using System.Linq;


namespace GetFilesInFolder
{
    public partial class GetMediaList : Form
    {
        string directoryPath = string.Empty;
        List<string> listPaths = new List<string>();
        List<StyleDirectory> directories = new List<StyleDirectory>();
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
            (var artist, var sortedArtist) = CreateArtistList();
            CreateXlsx(artist, sortedArtist);
            //DisplayArtists(artist);
        }
        private (List<Artist>, List<Artist>) CreateArtistList()
        {
            var scratchArtists = new Artist();
            var listArtists = new Artists();
            var thelistArtists = listArtists.TheArtists;
            // Traverse all directories in the directories list and create a list of artists.
            foreach (StyleDirectory directory in directories)
            {
                if (directory.DirectoryName == string.Empty) continue;
                string? style = directory.DirectoryName;
                // Export directories information to rich text box.
                foreach (Artist artist in directory.Artists)
                {
                    if (artist.Albums.Count == 0) continue;
                    scratchArtists.ArtistName = artist.ArtistName + " (" + style + ")";
                    foreach (string album in artist.Albums)
                    {
                        scratchArtists.Albums.Add(album);
                    }
                    thelistArtists.Add(scratchArtists);
                    scratchArtists = new Artist();
                }
            }
            var thelistArtistsSorted = thelistArtists.OrderBy(x => x.ArtistName).ToList();
            return (thelistArtists, thelistArtistsSorted);
        }
        private void CreateXlsx(List<Artist> artists, List<Artist> sortedArtist)
        {
            // Create xlsx spreadsheet.
            var workbook = new XLWorkbook();
            CreateWorksheet(artists, workbook, "Artist");
            CreateWorksheet(sortedArtist, workbook, "SortedArtist");
            // Save the spreadsheet.
            workbook.SaveAs("Artists.xlsx");
        }
        private XLWorkbook CreateWorksheet(List<Artist> artists, XLWorkbook workbook, string worksheetName)
        {

            var worksheet = workbook.Worksheets.Add(worksheetName);
            // Create header row.
            worksheet.Cell("A1").Value = "Artist";
            worksheet.Cell("B1").Value = "Album";
            // Create data rows.
            int row = 2;
            foreach (Artist artist in artists)
            {
                worksheet.Cell("A" + row.ToString()).Value = artist.ArtistName;
                foreach (string album in artist.Albums)
                {
                    worksheet.Cell("B" + row.ToString()).Value = album;
                    row++;
                }
            }
            return workbook;
        }
        private void DisplayArtists(List<Artist> artists)
        {
            // Export directories information to rich text box.
            foreach (Artist artist in artists)
            {
                ResultRichTextBox.AppendText(artist.ArtistName + "\n");
                foreach (string album in artist.Albums)
                {
                    ResultRichTextBox.AppendText("\t" + album + "\n");
                }
            }
        }
        private void TraverseDirectory(string directoryPath)
        {
            if (directoryPath == string.Empty)
            {
                return;
            }
            // Traverse all subdirectories in the path directoryPath.
            foreach (string directory in System.IO.Directory.GetDirectories(directoryPath))
            {
                // Create a new Directory object.
                var directoryObject = new StyleDirectory();
                // Set the DirectoryName property to just the name of the current directory.
                directoryObject.DirectoryName = new System.IO.DirectoryInfo(directory).Name;
                // traverse all subdirectories in the current directory.
                foreach (string subDirectory in System.IO.Directory.GetDirectories(directory))
                {
                    // Create a new Artist object.
                    var artistObject = new Artist();
                    // Set the ArtistName property of the new object to the name of the current directory.
                    artistObject.ArtistName = new System.IO.DirectoryInfo(subDirectory).Name;
                    // Add the new object to the list of Artist objects.
                    artistObject.Albums = GetAlbums(subDirectory);
                    // Add the new object to the list of Artist objects.
                    directoryObject.Artists.Add(artistObject);
                }
                // Add the new object to the list of Directory objects.
                directories.Add(directoryObject);
            }
        }
        private List<string> GetAlbums(string subDirectory)
        {
            // Create a new list of strings.
            List<string> albums = new List<string>();
            // Traverse all subdirectories in the subDirectory directory.
            foreach (string directory in System.IO.Directory.GetDirectories(subDirectory))
            {
                // Add the name of the current directory to the list of strings.
                albums.Add(new System.IO.DirectoryInfo(directory).Name);
            }
            // Return the list of strings.
            return albums;
        }
    }
}

