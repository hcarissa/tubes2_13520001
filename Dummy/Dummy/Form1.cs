using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dummy.classes;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.IO;

namespace Dummy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        App d = new App();

        private void pathBtn_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                d.rootPath = dialog.FileName;
                pathBox.Text = d.rootPath;
            }
        }

        private void fileNameInput_TextChanged(object sender, EventArgs e)
        {
            d.fileTarget = fileNameInput.Text;
        }

        private void findAllCheck_CheckedChanged(object sender, EventArgs e)
        {
            d.isAllOccurence = true;
        }

        private void bfsBtn_CheckedChanged(object sender, EventArgs e)
        {
            d.isBFS = true;
        }

        private void dfsBtn_CheckedChanged(object sender, EventArgs e)
        {
            d.isBFS = false;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            // initialize folders & files name
            string folders = "";
            string files = "";

            // Make a reference to a directory.
            DirectoryInfo di = new DirectoryInfo(d.rootPath);

            // Get a reference to each directory in that directory.
            DirectoryInfo[] diArr = di.GetDirectories();
            // Get a reference to each file in that directory.
            FileInfo[] fiArr = di.GetFiles();

            // store the names of the directories.
            foreach (DirectoryInfo dri in diArr) { folders += dri.Name + "\n"; }
            // store the names of the files.
            foreach (FileInfo file in fiArr) { files += file.Name + "\n"; }

            MessageBox.Show($"root path: {d.rootPath}\n" +
                $"file target: {d.fileTarget}\n" +
                $"is all occurence: {d.isAllOccurence}\n" +
                $"algorithm used: " + d.whichAlgo(d.isBFS) + "\n ===\n" +
                folders + "=== \n" +
                files
                );
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
