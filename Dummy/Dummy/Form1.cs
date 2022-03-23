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
        App myController = new App();
        public Form1()
        {
            InitializeComponent();
        }

        private void pathBtn_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                myController.setRootPath(dialog.FileName);
                // myController.rootPath = dialog.FileName;
                buttonChooseFolder.Text = myController.getRootPath();
            }
            labelFolderChosen.Text = "Folder chosen!";
        }

        private void fileNameInput_TextChanged(object sender, EventArgs e)
        {
            myController.setFileTarget(textboxInputFilename.Text);
            // myController.fileTarget = textboxInputFilename.Text;
        }

        private void findAllCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (myController.getIsAllOccurence())
            {
                myController.setIsAllOccurence(false);
                // myController.isAllOccurence = true;
            }
            else
            {
                myController.setIsAllOccurence(true);
                // myController.isAllOccurence = false;
            }
        }

        private void bfsBtn_CheckedChanged(object sender, EventArgs e)
        {
            myController.setIsBFS(true);
        }

        private void dfsBtn_CheckedChanged(object sender, EventArgs e)
        {
            myController.setIsBFS(false);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            int countVisited = 0;
            int countFinalPath = 0;
            bool isFound = false;
            bool isFoundCopy = false;
            Stopwatch sw = new Stopwatch();
            if (myController.getRootPath().Length == 0) 
            {
                MessageBox.Show(
                    "You haven't filled the root path, fill it first!"
                );
            }
            else
            {
                myController.setShowGraph(!myController.getShowGraph());
                if (myController.getShowGraph())
                {
                    if (myController.getIsBFS()) // BFS Algorithm
                    {
                        // TESTING BFS
                        BFS_Algorithm bfs_algo = new BFS_Algorithm(myController.getRootPath(), myController.getFileTarget(), myController.getIsAllOccurence());
                        BFS_Algorithm bfs_algo_copy = new BFS_Algorithm(myController.getRootPath(), myController.getFileTarget(), myController.getIsAllOccurence());
                        sw.Start();
                        isFound = bfs_algo.BFS_search();
                        sw.Stop();
                        isFoundCopy = bfs_algo_copy.BFS_search();
                        countVisited = bfs_algo.getVisitedCount();
                        countFinalPath = bfs_algo.getFinalPathCount();

                        // HYPERLINK
                        if (countFinalPath > 0)
                        {
                            string[] finalPathArray = bfs_algo_copy.getFinalPathArray();
                            if (countFinalPath == 1)
                            {
                                string pathTxt = finalPathArray[0];
                                int last = pathTxt.Length;
                                int first = myController.getFileTarget().Length;
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

                                    string pathTxt = finalPathArray[i];
                                    int last = pathTxt.Length;
                                    int first = myController.getFileTarget().Length;
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
                        timeLabel.Text = "Elapsed Time is " + sw.ElapsedMilliseconds + " ms";
                        // GRAPH VISUALIZATION
                        MyGraph myGraph = new MyGraph(myController.getRootPath(), bfs_algo.getWereInQueueArray(), bfs_algo.getVisitedArray(), bfs_algo.getFinalPathArray());
                        myGraph.buildGraph();

                        Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
                        viewer.Graph = myGraph.getGraph();
                        viewer.OutsideAreaBrush = Brushes.White;
                        this.graphPanel.Controls.Add(viewer);
                    }
                    else // DFS Algorithm
                    {
                        // TESTING DFS
                        DFS_Algorithm dfs_algo = new DFS_Algorithm(myController.getFileTarget(), myController.getRootPath(), myController.getIsAllOccurence());
                        DFS_Algorithm dfs_algo_copy = new DFS_Algorithm(myController.getFileTarget(), myController.getRootPath(), myController.getIsAllOccurence());
                        sw.Start();
                        isFound = dfs_algo.DFS_search(myController.getRootPath());
                        sw.Stop();
                        timeLabel.Text = "Elapsed Time is " + sw.ElapsedMilliseconds + " ms";
                        isFoundCopy = dfs_algo_copy.DFS_search(myController.getRootPath());
                        countVisited = dfs_algo.getVisitedFoldersCount();
                        countFinalPath = dfs_algo.getFinalPathCount();

                        // HYPERLINK
                        if (countFinalPath > 0)
                        {
                            string[] finalPathArray = dfs_algo_copy.getFinalPathArray();
                            if (countFinalPath == 1)
                            {
                                string pathTxt = finalPathArray[0];
                                int last = pathTxt.Length;
                                int first = myController.getFileTarget().Length;
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
                                    string pathTxt = finalPathArray[i];
                                    int last = pathTxt.Length;
                                    int first = myController.getFileTarget().Length;
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
                        MyGraph myGraph = new MyGraph(myController.getRootPath(), wereInQueueArray, wereInQueueArray, dfs_algo.getFinalPathArray());
                        myGraph.buildGraph();

                        Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
                        viewer.Graph = myGraph.getGraph();
                        viewer.OutsideAreaBrush = Brushes.White;
                        this.graphPanel.Controls.Add(viewer);
                    }
                }
                else // graph akan di-clear apabila telah ditampilkan
                {
                    this.graphPanel.Controls.Clear();
                    hyperlinkLabel.ResetText();
                    errorLabel.ResetText();
                    multiplePath.ResetText();
                    multiplePath.Links.Clear();
                    timeLabel.ResetText();
                    sw.Reset();
                }
            }             
        }

        private void hyperlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Boolean isFound = false;
            if (myController.getIsBFS())
            {
                BFS_Algorithm bfs_algo = new BFS_Algorithm(myController.getRootPath(), myController.getFileTarget(), myController.getIsAllOccurence());
                isFound = bfs_algo.BFS_search();
                if (isFound)
                {
                    string pathTxt = bfs_algo.getFinalPathQueue().Dequeue();
                    int last = pathTxt.Length;
                    int first = myController.getFileTarget().Length;
                    string finalPath = pathTxt.Remove((last - first), first);
                    Process.Start(finalPath);
                }
            }
            else
            {
                DFS_Algorithm dfs_algo = new DFS_Algorithm(myController.getFileTarget(), myController.getRootPath(), myController.getIsAllOccurence());
                isFound = dfs_algo.DFS_search(myController.getRootPath());
                if (isFound)
                {
                    string pathTxt = dfs_algo.getFinalPathQueue().Dequeue();
                    int last = pathTxt.Length;
                    int first = myController.getFileTarget().Length;
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
