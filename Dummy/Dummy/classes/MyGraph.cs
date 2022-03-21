using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dummy.classes
{
    class MyGraph
    {
        public string rootPath;
        // public string[] allNodes;
        public string[] finalPath;
        public string[] visitedPath;
        public Microsoft.Msagl.Drawing.Graph graph;

        public MyGraph (string rootPathIn, string[] finalPathIn, string[] visitedPathIn)
        {
            rootPath = rootPathIn;
            // allNodes = allNodesIn;
            finalPath = finalPathIn;
            visitedPath = visitedPathIn;
            graph = new Microsoft.Msagl.Drawing.Graph("graph");
        }

        public void buildGraph ()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue(rootPath);

            while (queue.Count != 0)
            {
                string path = queue.Dequeue();
                string prefix = path + "\\";
                if (path.Equals("C:\\"))
                {
                    prefix = path;
                }

                DirectoryInfo parentDir = new DirectoryInfo(path);
                FileInfo[] files = parentDir.GetFiles();
                DirectoryInfo[] directories = parentDir.GetDirectories();

                foreach (FileInfo file in files)
                {
                    string stringFile = Convert.ToString(file);
                    if (isVisitedPathContain(path))
                    {
                        if ((isFinalPathContain(path)) && (isFinalPathContain(prefix+stringFile)))
                        {
                            graph.AddEdge(path, prefix + stringFile).Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                            graph.FindNode(path).Label.FontColor = Microsoft.Msagl.Drawing.Color.Blue;
                            graph.FindNode(path).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Plaintext;
                            graph.FindNode(path).Attr.LabelMargin = 25;
                            graph.FindNode(prefix + stringFile).Label.FontColor = Microsoft.Msagl.Drawing.Color.Blue;
                            graph.FindNode(prefix + stringFile).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Plaintext;
                            graph.FindNode(prefix + stringFile).Attr.LabelMargin = 25;
                        }
                        else if (!isVisitedPathContain(prefix + stringFile))
                        {
                            graph.AddEdge(path, prefix + stringFile);
                            graph.FindNode(path).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Plaintext;
                            graph.FindNode(prefix + stringFile).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Plaintext;
                            graph.FindNode(path).Attr.LabelMargin = 25;
                            graph.FindNode(prefix + stringFile).Attr.LabelMargin = 25;
                        }
                        else if (isVisitedPathContain(prefix + stringFile) && (!isFinalPathContain(prefix + stringFile))) {
                            graph.AddEdge(path, prefix + stringFile).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                            graph.FindNode(path).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Plaintext;
                            graph.FindNode(prefix + stringFile).Label.FontColor = Microsoft.Msagl.Drawing.Color.Red;
                            graph.FindNode(prefix + stringFile).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Plaintext;
                            graph.FindNode(path).Attr.LabelMargin = 25;
                            graph.FindNode(prefix + stringFile).Attr.LabelMargin = 25;
                        }
                    }
                    else
                    {
                        graph.AddEdge(path, prefix + stringFile);
                        graph.FindNode(path).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Plaintext;
                        graph.FindNode(prefix + stringFile).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Plaintext;
                        graph.FindNode(path).Attr.LabelMargin = 25;
                        graph.FindNode(prefix + stringFile).Attr.LabelMargin = 25;
                    }
                    graph.FindNode(prefix + stringFile).LabelText = stringFile;
                }

                foreach (DirectoryInfo directory in directories)
                {
                    string stringDirectory = Convert.ToString(directory);
                    queue.Enqueue(prefix + stringDirectory);
                    if (isVisitedPathContain(path))
                    {
                        if ((isFinalPathContain(path)) && (isFinalPathContain(prefix + stringDirectory)))
                        {
                            graph.AddEdge(path, prefix + stringDirectory).Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                            graph.FindNode(path).Label.FontColor = Microsoft.Msagl.Drawing.Color.Blue;
                            graph.FindNode(path).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Plaintext;
                            graph.FindNode(path).Attr.LabelMargin = 25;
                            graph.FindNode(prefix + stringDirectory).Label.FontColor = Microsoft.Msagl.Drawing.Color.Blue;
                            graph.FindNode(prefix + stringDirectory).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Plaintext;
                            graph.FindNode(prefix + stringDirectory).Attr.LabelMargin = 25;
                        }
                        else if (!isVisitedPathContain(prefix + stringDirectory))
                        {
                            graph.AddEdge(path, prefix + stringDirectory);
                            graph.FindNode(path).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Plaintext;
                            graph.FindNode(prefix + stringDirectory).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Plaintext;
                            graph.FindNode(path).Attr.LabelMargin = 25;
                            graph.FindNode(prefix + stringDirectory).Attr.LabelMargin = 25;
                        }
                        else if (isVisitedPathContain(prefix + stringDirectory) && (!isFinalPathContain(prefix + stringDirectory)))
                        {
                            graph.AddEdge(path, prefix + stringDirectory).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                            graph.FindNode(path).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Plaintext;
                            graph.FindNode(prefix + stringDirectory).Label.FontColor = Microsoft.Msagl.Drawing.Color.Red;
                            graph.FindNode(prefix + stringDirectory).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Plaintext;
                            graph.FindNode(path).Attr.LabelMargin = 25;
                            graph.FindNode(prefix + stringDirectory).Attr.LabelMargin = 25;
                        }
                    }
                    else
                    {
                        graph.AddEdge(path, prefix + stringDirectory);
                        graph.FindNode(path).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Plaintext;
                        graph.FindNode(prefix + stringDirectory).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Plaintext;
                        graph.FindNode(path).Attr.LabelMargin = 25;
                        graph.FindNode(prefix + stringDirectory).Attr.LabelMargin = 25;
                    }
                    graph.FindNode(prefix + stringDirectory).LabelText = stringDirectory;
                }
            }
            if (!isFinalPathContain(rootPath))
            {
                graph.FindNode(rootPath).Label.FontColor = Microsoft.Msagl.Drawing.Color.Red;
            }
        }

        public bool isVisitedPathContain (string value)
        {
            bool check = Array.Exists(visitedPath, x => x == value);
            return check;
        }

        public bool isFinalPathContain (string value)
        {
            for (int i = 0; i < finalPath.Length; i++)
            {
                if (finalPath[i].Contains(value))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
