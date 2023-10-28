using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandaIdea_Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Setting up the DataGridView
            dataGridViewFiles.ColumnCount = 5;
            dataGridViewFiles.Columns[0].Name = "Name";
            dataGridViewFiles.Columns[1].Name = "Full Path";
            dataGridViewFiles.Columns[2].Name = "Type";
            dataGridViewFiles.Columns[3].Name = "Last Modified";
            dataGridViewFiles.Columns[4].Name = "Extension/Size";


            // Set the column width mode to fixed
            dataGridViewFiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // Set the width of each column to a specific value
            dataGridViewFiles.Columns["Name"].Width = 150;
            dataGridViewFiles.Columns["Full Path"].Width = 250;
            dataGridViewFiles.Columns["Type"].Width = 100;
            dataGridViewFiles.Columns["Last Modified"].Width = 150;
            dataGridViewFiles.Columns["Extension/Size"].Width = 150;

        }



        private void browseButton_Click(object sender, EventArgs e)
        {

            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = dialog.SelectedPath;
                    DisplayFilesInFolder(selectedPath);
                }
            }
        }
        private void DisplayFilesInFolder(string folderPath)
        {
            dataGridViewFiles.Rows.Clear();

            try
            {
                string[] fileSystemEntries = Directory.GetFileSystemEntries(folderPath);

                foreach (string entryPath in fileSystemEntries)
                {
                    string entryType = (File.GetAttributes(entryPath) & FileAttributes.Directory) == FileAttributes.Directory
                        ? "Folder"
                        : "File";

                    if (entryType == "Folder")
                    {
                        DirectoryInfo di = new DirectoryInfo(entryPath);
                        dataGridViewFiles.Rows.Add(di.Name, di.FullName, entryType, di.LastWriteTime.ToString(), "");
                    }
                    else
                    {
                        FileInfo fileInfo = new FileInfo(entryPath);
                        dataGridViewFiles.Rows.Add(fileInfo.Name, fileInfo.FullName, entryType, fileInfo.LastWriteTime.ToString(), fileInfo.Extension + " / " + fileInfo.Length + " bytes");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
      

        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            string searchTerm = searchTextBox.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                SearchRecords(searchTerm);
            }
            else
            {
                DisplayAllRecords();
            }
        }

        private void DisplayAllRecords()
        {
            foreach (DataGridViewRow row in dataGridViewFiles.Rows)
            {
                row.Visible = true; // Show all rows
            }
        }
        private void SearchRecords(string searchTerm)
        {
            bool foundAny = false;

            if (string.IsNullOrEmpty(searchTerm))
            {
                DisplayAllRecords();
                return;
            }
            foreach (DataGridViewRow row in dataGridViewFiles.Rows)
            {
                bool found = false;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchTerm))
                    {
                        found = true;
                        foundAny = true;
                        break;
                    }
                }
                row.Visible = found;
            }
            if (!foundAny)
            {
                MessageBox.Show("Record not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void WriteToTxtFileButton_Click(object sender, EventArgs e)
        {
            DataExporter.ExportToTxt(dataGridViewFiles);
        }   
    }

}
