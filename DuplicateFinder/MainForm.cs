﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuplicateFinder
{
    public partial class MainForm : Form
    {
        private BindingList<DuplicateViewModel> allDuplicates;
        private BindingList<string> currentPaths;

        public MainForm()
        {
            InitializeComponent();
        }

        private void StartNewSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                Log($"Looking for duplicates in {folderBrowserDialog.SelectedPath}...");
                var filePaths = Directory.EnumerateFiles(folderBrowserDialog.SelectedPath, "*", SearchOption.AllDirectories);
                allDuplicates = new BindingList<DuplicateViewModel>(GetDuplicates(filePaths).OrderBy(duplicate => duplicate.FileName).ToList());
                duplicateListBox.DataSource = allDuplicates;
                duplicateListBox.DisplayMember = nameof(DuplicateViewModel.FileName);
                Log($"Found {allDuplicates.Count()} duplicates in {folderBrowserDialog.SelectedPath}.");
                Cursor.Current = Cursors.Default;
            }
        }

        private IEnumerable<DuplicateViewModel> GetDuplicates(IEnumerable<string> filePaths)
        {
            return filePaths
                .GroupBy(filePath => Path.GetFileName(filePath))
                .Where(group => group.Count() > 1)
                .Select(group => new DuplicateViewModel { FileName = group.Key, FilePaths = new BindingList<string>(group.ToList()) });
        }

        private void DuplicateListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedDuplicate = duplicateListBox.SelectedItem as DuplicateViewModel;
            if (selectedDuplicate != null)
            {
                currentPaths = selectedDuplicate.FilePaths;
                fileListBox.DataSource = currentPaths;
            }
        }

        private void FileListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedFilePath = fileListBox.SelectedItem as string;
            if (!string.IsNullOrWhiteSpace(selectedFilePath))
            {
                duplicatePictureBox.ImageLocation = selectedFilePath;
                fileNameLabel.Text = selectedFilePath;
                var fileInfo = new FileInfo(selectedFilePath);
                sizeLabel.Text = $"{fileInfo.Length} bytes";
                createdLabel.Text = fileInfo.CreationTime.ToLongDateString();
                lastModifiedLabel.Text = fileInfo.LastWriteTime.ToLongDateString();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var selectedFilePath = fileListBox.SelectedItem as string;
            if (!string.IsNullOrWhiteSpace(selectedFilePath))
            {
                File.Delete(selectedFilePath);
                Log($"Deleted file {selectedFilePath}.");
            }
            currentPaths.Remove(selectedFilePath);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e) => new AboutBox().ShowDialog();

        private void Log(string message)
        {
            logTextBox.AppendText(Environment.NewLine + message);
        }
    }
}
