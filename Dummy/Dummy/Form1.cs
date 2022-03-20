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
        App d = new App();
        public Form1()
        {
            InitializeComponent();
            // BFS_Algo bfs_algo = new BFS_Algo(...);
            // DFS_Algo dfs_algo = new DFS_Algo(...);

            //create the graph content 
            d.show = false;
            d.graph.AddEdge("A", "B");
            d.graph.AddEdge("B", "C");
            d.graph.AddEdge("A", "C").Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
            d.graph.FindNode("A").Attr.FillColor = Microsoft.Msagl.Drawing.Color.Magenta;
            d.graph.FindNode("B").Attr.FillColor = Microsoft.Msagl.Drawing.Color.MistyRose;

            // Microsoft.Msagl.Drawing.Node c = graph.FindNode("C");
            // c.Attr.FillColor = Microsoft.Msagl.Drawing.Color.PaleGreen;
            // c.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Diamond;
        }

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
            if(d.isAllOccurence == false)
            {
                d.isAllOccurence = true;
            }
            else
            {
                d.isAllOccurence = false;
            }
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
            String visitedPath = "";
            String finalPath = "";
            int countVisited = 0;
            int countFinalPath = 0;
            bool isFound = false;

            if (d.isBFS)
            {
                // TESTING BFS
                BFS_Algorithm bfs_algo = new BFS_Algorithm(d.rootPath, d.fileTarget, d.isAllOccurence);
                isFound = bfs_algo.BFS_search();
                countVisited = bfs_algo.visited.Count;
                countFinalPath = bfs_algo.finalPath.Count;
                for (int i = 0; i < countVisited; i++) { visitedPath += bfs_algo.visited.Dequeue() + "\n"; }
                if (countFinalPath == 0) { finalPath = "empty"; }
                else
                {
                    for (int i = 0; i < countFinalPath; i++) { finalPath += bfs_algo.finalPath.Dequeue() + "\n"; }
                }
            }
            if (!d.isBFS)
            {
                // TESTING DFS
                DFS_Algorithm dfs_algo = new DFS_Algorithm(d.fileTarget, d.rootPath, d.isAllOccurence);
                isFound = dfs_algo.DFS_search(d.rootPath);
                countVisited = dfs_algo.visitedFolders.Count;
                countFinalPath = dfs_algo.finalPath.Count;
                for (int i = 0; i < countVisited; i++) { visitedPath += dfs_algo.visitedFolders.Dequeue() + "\n"; }
                if (countFinalPath == 0) { finalPath = "empty"; }
                else 
                { 
                    for (int i = 0; i < countFinalPath; i++) { finalPath += dfs_algo.finalPath.Dequeue() + "\n"; }
                    isFound = true; 
                } 
            }

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

                    // DRIVER TESTING BFS/DFS
                    $"Visited path: {countVisited}\n{visitedPath}\n" +
                    $"Final path: {countFinalPath}\n{finalPath}" +
                    $"Found is: {isFound}\n"
                );   
        }

        private void buttonGraphTrial_Click(object sender, EventArgs e)
        {
            // GRAPH VISUALIZATION
            // create a viewer object 
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            // bind the graph to the viewer 
            viewer.Graph = d.graph;

            d.show = !d.show;
            if (d.show) { this.graphPanel.Controls.Add(viewer); }
            else { this.graphPanel.Controls.Clear(); }
        }
    }
}
