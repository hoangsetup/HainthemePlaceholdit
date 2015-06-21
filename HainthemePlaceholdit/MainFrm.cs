using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace HainthemePlaceholdit
{
    public partial class MainFrm : Form
    {
        private List<MyImageFile> _images = new List<MyImageFile>();
        private string _parentPath = "";
        private int _count;
        public MainFrm()
        {
            InitializeComponent();
            dataGridView_images.AutoGenerateColumns = false;
            themeColorPickerToolStripSplitButton_bgcolor.Color = ColorTranslator.FromHtml("#cccccc");
            themeColorPickerToolStripSplitButton_txtcolor.Color = ColorTranslator.FromHtml("#969696");
        }

        private void button_pickfoder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog_images.ShowDialog() == DialogResult.OK)
            {
                textBox_path.Text = folderBrowserDialog_images.SelectedPath;
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            progressBar_status.Maximum = _images.Count;
            foreach (MyImageFile imageFile in _images)
            {
                var file = imageFile;
                file.Text = toolStripTextBox_text.Text;
                ThreadPool.QueueUserWorkItem(o =>
                {
                    string path = _parentPath + "_placeholdit";
                    //if (!Directory.Exists(path))
                    //{
                    //    Directory.CreateDirectory(path);
                    //}

                    CopyDirectory(_parentPath, path);

                    string parentFolderOld = _parentPath.Split('\\')[_parentPath.Split('\\').Length - 1];
                    string newFolder = Path.GetDirectoryName(file.Path).Replace(parentFolderOld, parentFolderOld + "_placeholdit");

                    PlaceholditHelper.DownloadImage(newFolder, file);

                    Invoke((MethodInvoker)(() =>
                    {
                        lock (label_status)
                        {
                            _count++;
                            label_status.Text = _count + @"/" + _images.Count;
                            lock (progressBar_status)
                            {
                                int process = _count;
                                progressBar_status.Value = process;
                                if (_count == _images.Count)
                                {
                                    MessageBox.Show(@"Fisnish");
                                    Process.Start(path);
                                    dataGridView_images.DataSource = null;
                                    _images.Clear();
                                    progressBar_status.Value = 0;
                                    _count = 0;
                                    textBox_path.Text = "";
                                    label_status.Text = "";
                                }
                            }
                        }
                    }));
                });
            }
        }

        /// <summary>
        /// Convert a .NET Color to a hex string.
        /// </summary>
        /// <returns>ex: "FFFFFF", "AB12E9"</returns>
        private static string ColorToHexString(Color color)
        {
            char[] hexDigits = {
         '0', '1', '2', '3', '4', '5', '6', '7',
         '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};
            byte[] bytes = new byte[3];
            bytes[0] = color.R;
            bytes[1] = color.G;
            bytes[2] = color.B;
            char[] chars = new char[bytes.Length * 2];
            for (int i = 0; i < bytes.Length; i++)
            {
                int b = bytes[i];
                chars[i * 2] = hexDigits[b >> 4];
                chars[i * 2 + 1] = hexDigits[b & 0xF];
            }
            return new string(chars);
        }

        private void textBox_path_TextChanged(object sender, EventArgs e)
        {
            _parentPath = textBox_path.Text;
            if (string.IsNullOrEmpty(_parentPath))
            {
                return;
            }
            if (!Directory.Exists(_parentPath))
            {
                MessageBox.Show(@"Path invalid");
                dataGridView_images.DataSource = null;
                _images.Clear();
                return;
            }
            string supportedExtensions = "*.jpg,*.gif,*.png,*.bmp,*.jpe,*.jpeg,*.wmf,*.emf,*.xbm,*.ico,*.eps,*.tif,*.tiff,*.g01,*.g02,*.g03,*.g04,*.g05,*.g06,*.g07,*.g08";
            foreach (string imageFile in Directory.GetFiles(_parentPath, "*.*", SearchOption.AllDirectories).Where(s => supportedExtensions.Contains(Path.GetExtension(s).ToLower())))
            {
                MyImageFile file = new MyImageFile(imageFile)
                {
                    BgColor = ColorToHexString(themeColorPickerToolStripSplitButton_bgcolor.Color),
                    TxtColor = ColorToHexString(themeColorPickerToolStripSplitButton_txtcolor.Color)
                };
                _images.Add(file);
            }
            label_status.Text = @"0/" + _images.Count;
            dataGridView_images.DataSource = _images;
        }

        private static void CopyDirectory(string sourcePath, string destPath)
        {
            if (!Directory.Exists(destPath))
            {
                Directory.CreateDirectory(destPath);
            }

            /*            foreach (string file in Directory.GetFiles(sourcePath))
                        {
                            string dest = Path.Combine(destPath, Path.GetFileName(file));
                            File.Copy(file, dest);
                        }*/

            foreach (string folder in Directory.GetDirectories(sourcePath))
            {
                string dest = Path.Combine(destPath, Path.GetFileName(folder));
                CopyDirectory(folder, dest);
            }
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(button_pickfoder, "Pick folder");
            toolTip1.SetToolTip(button_start, "Start process");
            toolTip1.SetToolTip(textBox_path, "Path folder images");
        }

    }
}
