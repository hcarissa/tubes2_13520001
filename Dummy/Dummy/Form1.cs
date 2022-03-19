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
        // BFS_Algo bfs_algo = new BFS_Algo(...);
        // DFS_Algo dfs_algo = new DFS_Algo(...);

        private void pathBtn_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                d.rootPath = dialog.FileName;
                buttonChooseFolder.Text = d.rootPath;
            }
            labelFolderChosen.Text = "Folder chosen!";
        }

        private void fileNameInput_TextChanged(object sender, EventArgs e)
        {
            d.fileTarget = textboxInputFilename.Text;
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
            // TESTING BFS
            BFS_Algorithm bfs_algo = new BFS_Algorithm(d.rootPath, d.fileTarget);
            bool isFound = bfs_algo.findOccurence();
            int count = bfs_algo.visited.Count;
            String visitedPath = "";
            String finalPath = "empty";
            for (int i = 0; i < count; i++) { visitedPath += bfs_algo.visited.Dequeue() + "\n"; }
            if (isFound)                    { finalPath = bfs_algo.finalPath.Peek(); }

            // initialize folders & files name
            string folders = "";
            // string files = "";

            // Make a reference to a directory.
            DirectoryInfo di = new DirectoryInfo(d.rootPath);

            // Get a reference to each directory in that directory.
            DirectoryInfo[] diArr = di.GetDirectories();
            // Get a reference to each file in that directory.
            // FileInfo[] fiArr = di.GetFiles();

            // store the names of the directories.
            // foreach (DirectoryInfo dri in diArr) { folders += dri.Name + "\n"; }
            // store the names of the files.
            // foreach (FileInfo file in fiArr) { files += file.Name + "\n"; }

            MessageBox.Show($"root path: {d.rootPath}\n"  +
                   // $"file target: {d.fileTarget}\n" +
                   // $"is all occurence: {d.isAllOccurence}\n" +
                   // $"algorithm used: " + d.whichAlgo(d.isBFS) + "\n ===\n" +
                   //folders + "=== \n" +

                    // DRIVER TESTING BFS
                    $"Visited path: {count}\n{visitedPath}\n" +
                    $"Final path: {finalPath}\n" +
                    $"Found is: {isFound}\n"
                );
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //create a viewer object 
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            //create a graph object 
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            //create the graph content 
            graph.AddEdge("A", "B");
            graph.AddEdge("B", "C");
            graph.AddEdge("A", "C").Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
            graph.FindNode("A").Attr.FillColor = Microsoft.Msagl.Drawing.Color.Magenta;
            graph.FindNode("B").Attr.FillColor = Microsoft.Msagl.Drawing.Color.MistyRose;
            Microsoft.Msagl.Drawing.Node c = graph.FindNode("C");
            c.Attr.FillColor = Microsoft.Msagl.Drawing.Color.PaleGreen;
            c.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Diamond;
            //bind the graph to the viewer 
            viewer.Graph = graph;
            this.Controls.Add(viewer);
        }
    }
}
