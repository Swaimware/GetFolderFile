using System;
using System.IO;
using ClosedXML.Excel;
//using DocumentFormat.OpenXml.Spreadsheet;

namespace DirectoryLister
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide a directory path as an argument.");
                return;
            }

            string directoryPath = args[0];

            if (!Directory.Exists(directoryPath))
            {
                Console.WriteLine("The specified directory does not exist.");
                return;
            }

            string outputPath = "DirectoryList.xlsx";

            // Create a new workbook and worksheet.
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Directory List");

                // Set up the column headers.
                worksheet.Cell("A1").Value = "Path";
                worksheet.Cell("B1").Value = "Type";
                worksheet.Cell("C1").Value = "Size (bytes)";

                // Traverse the directory and add each file/folder to the worksheet.
                TraverseDirectory(directoryPath, worksheet, 2);

                // Save the workbook to the output file.
                workbook.SaveAs(outputPath);
            }

            Console.WriteLine($"Directory listing saved to {outputPath}.");
        }

        static void TraverseDirectory(string directoryPath, IXLWorksheet worksheet, int currentRow)
        {
            // Add the current directory to the worksheet.
            worksheet.Cell($"A{currentRow}").Value = directoryPath;
            worksheet.Cell($"B{currentRow}").Value = "Directory";

            // Traverse all files in the directory.
            foreach (FileInfo fileInfo in new DirectoryInfo(directoryPath).GetFiles())
            {
                currentRow++;
                worksheet.Cell($"A{currentRow}").Value = fileInfo.FullName;
                worksheet.Cell($"B{currentRow}").Value = "File";
                worksheet.Cell($"C{currentRow}").Value = fileInfo.Length;
            }

            // Traverse all subdirectories in the directory.
            foreach (DirectoryInfo subDirectoryInfo in new DirectoryInfo(directoryPath).GetDirectories())
            {
                TraverseDirectory(subDirectoryInfo.FullName, worksheet, currentRow + 1);
            }
        }
    }
}
