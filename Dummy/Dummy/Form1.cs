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
                d.show = !d.show;
                if (d.show) {
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
                        if (countFinalPath == 1)
                        {
                            string pathTxt = bfs_algo_copy.finalPath.Dequeue();
                            int last = pathTxt.Length;
                            int first = d.fileTarget.Length;
                            string pathText = pathTxt.Remove((last - first), first);
                            hyperlinkLabel.Text = pathText;
                            hyperlinkLabel.LinkBehavior = LinkBehavior.HoverUnderline;
                            hyperlinkLabel.LinkColor = Color.Blue;
                        }
                        else
                        {
                            int i = 0;
                            multiplePath.Text = "";
                            int counter = 0;
                            for (i = 0; i < countFinalPath; i++)
                            {

                                string pathTxt = bfs_algo_copy.finalPath.Dequeue();
                                int last = pathTxt.Length;
                                int first = d.fileTarget.Length;
                                string pathText = pathTxt.Remove((last - first), first);
                                multiplePath.Text += pathText;
                                multiplePath.Links.Add(counter, pathText.Length, pathText);
                                counter = counter + pathText.Length;
                                multiplePath.Text += "\n";
                                counter += 1;
                            }
                        }
                    }
                    else if (countFinalPath == 0)
                    {
                        errorLabel.Text = "File not found!";
                    }

                    // GRAPH VISUALIZATION
                    string[] wereInQueueArray = bfs_algo.getWereInQueueArray();
                    string test = "";
                    for (int i = 0; i < wereInQueueArray.Length; i++)
                    {
                        test += wereInQueueArray[i] + "\n";
                    }
                    MessageBox.Show($"Were in queue: \n {test}");
                    MyGraph myGraph = new MyGraph(d.rootPath, wereInQueueArray, bfs_algo.getVisitedArray(), bfs_algo.getFinalPathArray());
                    myGraph.buildGraph();

                    Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
                    viewer.Graph = myGraph.graph;
                    viewer.OutsideAreaBrush = Brushes.White;
                    this.graphPanel.Controls.Add(viewer);
                }
                else
                {
                    this.graphPanel.Controls.Clear();
                    hyperlinkLabel.ResetText();
                    errorLabel.ResetText();
                    multiplePath.ResetText();
                    multiplePath.Links.Clear();
                }
            }
            if (!d.isBFS)
            {
                DirectoryInfo parentDir = new DirectoryInfo(d.rootPath);
                FileInfo[] files = parentDir.GetFiles();
                DirectoryInfo[] directories = parentDir.GetDirectories();
                DirectoryInfo parentDir2 = new DirectoryInfo(d.rootPath + "\\" + Convert.ToString(files[0]));
                MessageBox.Show($"{d.rootPath}\\{Convert.ToString(files[0])}\n" +
                    $"{parentDir.Extension.Length} \n" +
                    $"{parentDir2.Extension.Length} \n" +
                    $"{parentDir2.Name.Equals("dua.txt")} \n" +
                    $"{files} \n" +
                    $"{directories.Length}"
                    );


                d.show = !d.show;
                if (d.show)
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
                        if (countFinalPath == 1)
                        {
                            string pathTxt = dfs_algo_copy.finalPath.Dequeue();
                            int last = pathTxt.Length;
                            int first = d.fileTarget.Length;
                            string pathText = pathTxt.Remove((last - first), first);
                            hyperlinkLabel.Text = pathText;
                            hyperlinkLabel.LinkBehavior = LinkBehavior.HoverUnderline;
                            hyperlinkLabel.LinkColor = Color.Blue;
                        }
                        else
                        {
                            int i = 0;
                            multiplePath.Text = "";
                            int counter = 0;
                            for (i = 0; i < countFinalPath; i++)
                            {

                                string pathTxt = dfs_algo_copy.finalPath.Dequeue();
                                int last = pathTxt.Length;
                                int first = d.fileTarget.Length;
                                string pathText = pathTxt.Remove((last - first), first);
                                multiplePath.Text += pathText;
                                multiplePath.Links.Add(counter, pathText.Length, pathText);
                                counter = counter + pathText.Length;
                                multiplePath.Text += "\n";
                                counter += 1;
                            }
                        }
                    }
                    else if (countFinalPath == 0)
                    {
                        errorLabel.Text = "File not found!";
                    }

                    // GRAPH VISUALIZATION
                    string[] wereInQueueArray = dfs_algo.getVisitedArray();
                    MyGraph myGraph = new MyGraph(d.rootPath, wereInQueueArray, wereInQueueArray, dfs_algo.getFinalPathArray());
                    myGraph.buildGraph();

                    Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
                    viewer.Graph = myGraph.graph;
                    viewer.OutsideAreaBrush = Brushes.White;
                    this.graphPanel.Controls.Add(viewer);
                }
                else
                {
                    this.graphPanel.Controls.Clear(); 
                    hyperlinkLabel.ResetText();
                    errorLabel.ResetText();
                    multiplePath.ResetText();
                    multiplePath.Links.Clear();
                }
            }

            // Find all nodes in root path
            /*
            DirectoryInfo di = new DirectoryInfo(d.rootPath);
            int countNode = d.allNodes.Count();
            String allnode = "";
            for (int i = 0; i < countNode; i++) { allnode += d.allNodes.Dequeue() + "\n"; }
             

            
             MessageBox.Show($"root path: {d.rootPath}\n"  +
                    // $"file target: {d.fileTarget}\n" +
                    // $"is all occurence: {d.isAllOccurence}\n" +
                     $"algorithm used: " + d.whichAlgo(d.isBFS) + "\n ===\n" +
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
                    string pathTxt = bfs_algo.finalPath.Dequeue();
                    int last = pathTxt.Length;
                    int first = d.fileTarget.Length;
                    string finalPath = pathTxt.Remove((last - first), first);
                    Process.Start(finalPath);
                }
            }
            else if (!d.isBFS)
            {
                DFS_Algorithm dfs_algo = new DFS_Algorithm(d.fileTarget, d.rootPath, d.isAllOccurence);
                isFound = dfs_algo.DFS_search(d.rootPath);
                if (isFound)
                {
                    string pathTxt = dfs_algo.finalPath.Dequeue();
                    int last = pathTxt.Length;
                    int first = d.fileTarget.Length;
                    string finalPath = pathTxt.Remove((last - first), first);
                    Process.Start(finalPath);
                }
            }
        }

        private void multiplePath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string target = e.Link.LinkData as string;
            Process.Start(target);
        }
    }
}
