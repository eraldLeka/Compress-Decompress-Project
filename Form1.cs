using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Erald_Leka_Lab6
{
    public partial class Form1 : Form
    {
        private List<string> selectedFiles = new List<string>();

        public Form1()
        {
            InitializeComponent();
            singleThread.Checked = true;
        }

        private void browse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Choose a folder";
                folderDialog.ShowNewFolderButton = true;
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderDialog.SelectedPath;
                    listBox1.Items.Clear();
                    selectedFiles.Clear();

                    string[] choosenFiles = Directory.GetFiles(selectedPath);
                    foreach (string file in choosenFiles)
                    {
                        listBox1.Items.Add(file);
                        selectedFiles.Add(file);
                    }
                    MessageBox.Show("Selected folder: " + selectedPath);
                }
            }
        }

        private void compressButton_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("No files founded! Please upload a folder!");
                return;
            }

            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Choose an output folder to save compressed files!";
                folderDialog.ShowNewFolderButton = true;
                if (folderDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                string outputFolder = folderDialog.SelectedPath;
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                try
                {
                    if (singleThread.Checked)
                    {
                        foreach (string file in selectedFiles)
                        {
                            string fileName = Path.GetFileName(file);
                            string compressedFilePath = Path.Combine(outputFolder, fileName + ".gz");
                            CompressFile(file, compressedFilePath);
                        }
                    }
                    else if (multiThread.Checked)
                    {
                        Parallel.ForEach(selectedFiles, file =>
                        {
                            string fileName = Path.GetFileName(file);
                            string compressedFilePath = Path.Combine(outputFolder, fileName + ".gz");
                            CompressFile(file, compressedFilePath);
                        });
                    }

                    stopwatch.Stop();
                    long elapsedMs = stopwatch.ElapsedMilliseconds;

                    string mode = singleThread.Checked ? "Single Thread" : "Multi-Thread";
                    MessageBox.Show($"Compression Completed!\nMode: {mode}\nTime: {elapsedMs} ms ({elapsedMs / 1000.0:F2} seconds)");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error during compression: {ex.Message}");
                }
            }
        }

        private void CompressFile(string inputFilePath, string outputFilePath)
        {
            using (FileStream inFile = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
            using (FileStream outFile = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
            using (GZipStream compress = new GZipStream(outFile, CompressionMode.Compress))
            {
                byte[] buffer = new byte[8192];
                int bytesRead;

                while ((bytesRead = inFile.Read(buffer, 0, buffer.Length)) > 0)
                {
                    compress.Write(buffer, 0, bytesRead);
                }

                compress.Flush();
                compress.Close();
            }
        }


        private void decompressButton_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("No files founded! Please select a folder!");
                return;
            }

            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Choose an output folder to save decompressed files!";
                folderDialog.ShowNewFolderButton = true;
                if (folderDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                string outputFolder = folderDialog.SelectedPath;
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                try
                {
                    if (singleThread.Checked)
                    {
                        foreach (string file in selectedFiles)
                        {
                            if (file.EndsWith(".gz"))
                            {
                                string fileName = Path.GetFileNameWithoutExtension(file);
                                string decompressedFilePath = Path.Combine(outputFolder, fileName);
                                DecompressFile(file, decompressedFilePath);
                            }
                        }
                    }
                    else if (multiThread.Checked)
                    {
                        Parallel.ForEach(selectedFiles.Where(file => file.EndsWith(".gz")), file =>
                        {
                            string fileName = Path.GetFileNameWithoutExtension(file);
                            string decompressedFilePath = Path.Combine(outputFolder, fileName);
                            DecompressFile(file, decompressedFilePath);
                        });
                    }

                    stopwatch.Stop();
                    long elapsedMs = stopwatch.ElapsedMilliseconds;

                    string mode = singleThread.Checked ? "Single Thread" : "Multi-Thread";
                    MessageBox.Show($"Decompression Completed!\nMode: {mode}\nTime: {elapsedMs} ms ({elapsedMs / 1000.0:F2} seconds)");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error during decompression: {ex.Message}");
                }
            }
        }

        private void DecompressFile(string inputFilePath, string outputFilePath)
        {
            using (FileStream inputStream = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
            using (FileStream outputStream = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
            using (GZipStream zip = new GZipStream(inputStream, CompressionMode.Decompress))
            {
                byte[] buffer = new byte[8192];
                int bytesRead;

                while ((bytesRead = zip.Read(buffer, 0, buffer.Length)) > 0)
                {
                    outputStream.Write(buffer, 0, bytesRead);
                }
            }
        }


        private void singleThread_CheckedChanged(object sender, EventArgs e)
        {
            if (singleThread.Checked)
            {
                multiThread.Checked = false;
            }
        }

        private void multiThread_CheckedChanged(object sender, EventArgs e)
        {
            if (multiThread.Checked)
            {
                singleThread.Checked = false;
            }
        }

        
    }
}