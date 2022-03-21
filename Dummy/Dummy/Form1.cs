using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            d.isAllOccurence = false;
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
            bool isFoundCopy = false;
            // d.fillNodeBFS();

            if (d.isBFS)
            {
                // TESTING BFS
                BFS_Algorithm bfs_algo = new BFS_Algorithm(d.rootPath, d.fileTarget, d.isAllOccurence);
                BFS_Algorithm bfs_algo_copy = new BFS_Algorithm(d.rootPath, d.fileTarget, d.isAllOccurence);
                isFound = bfs_algo.BFS_search();
                isFoundCopy = bfs_algo_copy.BFS_search();
                countVisited = bfs_algo.visited.Count;
                countFinalPath = bfs_algo.finalPath.Count;

                // HYPERLINK
                if (countFinalPath > 0)
                {

                    string pathText = bfs_algo_copy.finalPath.Dequeue();
                    hyperlinkLabel.Text = pathText;
                    hyperlinkLabel.LinkBehavior = LinkBehavior.HoverUnderline;
                    hyperlinkLabel.LinkColor = Color.Blue;
                }
                else if (countFinalPath == 0)
                {
                    hyperlinkLabel.Text = "File not found!";
                    hyperlinkLabel.LinkBehavior = LinkBehavior.NeverUnderline;
                    hyperlinkLabel.LinkColor = Color.Black;
                }

                // GRAPH VISUALIZATION
                MyGraph myGraph = new MyGraph(d.rootPath, bfs_algo.getFinalPathArray(), bfs_algo.getVisitedArray());
                myGraph.buildGraph();

                Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
                viewer.Graph = myGraph.graph;
                viewer.OutsideAreaBrush = Brushes.White;

                d.show = !d.show;
                if (d.show) {
                    this.graphPanel.Controls.Add(viewer);
                }
                else
                {
                    this.graphPanel.Controls.Clear();
                    hyperlinkLabel.ResetText();
                }
            }
            if (!d.isBFS)
            {
                // TESTING DFS
                DFS_Algorithm dfs_algo = new DFS_Algorithm(d.fileTarget, d.rootPath, d.isAllOccurence);
                DFS_Algorithm dfs_algo_copy = new DFS_Algorithm(d.fileTarget, d.rootPath, d.isAllOccurence);
                isFound = dfs_algo.DFS_search(d.rootPath);
                isFoundCopy = dfs_algo_copy.DFS_search(d.rootPath);
                countVisited = dfs_algo.visitedFolders.Count;
                countFinalPath = dfs_algo.finalPath.Count;

                // HYPERLINK
                if (countFinalPath > 0)
                {

                    string pathText = dfs_algo_copy.finalPath.Dequeue();
                    hyperlinkLabel.Text = pathText;
                    hyperlinkLabel.LinkBehavior = LinkBehavior.HoverUnderline;
                    hyperlinkLabel.LinkColor = Color.Blue;
                }
                else if (countFinalPath == 0)
                {
                    hyperlinkLabel.Text = "File not found!";
                    hyperlinkLabel.LinkBehavior = LinkBehavior.NeverUnderline;                 
                    hyperlinkLabel.LinkColor = Color.Black;
                }

                // GRAPH VISUALIZATION
                MyGraph myGraph = new MyGraph(d.rootPath, dfs_algo.getFinalPathArray(), dfs_algo.getVisitedArray());
                myGraph.buildGraph();

                Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
                viewer.Graph = myGraph.graph;
                viewer.OutsideAreaBrush = Brushes.White;

                d.show = !d.show;
                if (d.show)
                {
                    this.graphPanel.Controls.Add(viewer);
                }
                else
                {
                    this.graphPanel.Controls.Clear(); 
                    hyperlinkLabel.ResetText(); }
            }

            // Find all nodes in root path
            /*
             DirectoryInfo di = new DirectoryInfo(d.rootPath);
            int countNode = d.allNodes.Count();
            String allnode = "";
            for (int i = 0; i < countNode; i++) { allnode += d.allNodes.Dequeue() + "\n"; }
             */

            /*
             MessageBox.Show($"root path: {d.rootPath}\n"  +
                    // $"file target: {d.fileTarget}\n" +
                    // $"is all occurence: {d.isAllOccurence}\n" +
                    // $"algorithm used: " + d.whichAlgo(d.isBFS) + "\n ===\n" +
                    //folders + "=== \n" +

                    // DRIVER TESTING BFS/DFS
                    $"All Nodes: {countNode}\n{allnode}\n" +
                    $"Visited path: {countVisited}\n{visitedPath}\n" +
                    $"Final path: {countFinalPath}\n{finalPath}" +
                    $"Found is: {isFound}\n"
                );   
             */
        }

        private void hyperlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Boolean isFound = false;
            if (d.isBFS)
            {
                BFS_Algorithm bfs_algo = new BFS_Algorithm(d.rootPath, d.fileTarget, d.isAllOccurence);
                isFound = bfs_algo.BFS_search();                
                if (isFound)
                {
                    string finalPath = bfs_algo.finalPath.Dequeue();
                    Process.Start(finalPath);
                }
                else
                {
                    
                }
            }
            else if (!d.isBFS)
            {
                DFS_Algorithm dfs_algo = new DFS_Algorithm(d.fileTarget, d.rootPath, d.isAllOccurence);
                isFound = dfs_algo.DFS_search(d.rootPath);
                if (isFound)
                {
                    string finalPath = dfs_algo.finalPath.Dequeue();
                    Process.Start(finalPath);
                }
                else
                {
                    
                }
            }
        }
    }
}
