using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dummy.classes
{
    class App
    {
        public Queue<string> allNodes = new Queue<string>();
        public string rootPath { get; set; }
        public string fileTarget { get; set; }
        public bool isAllOccurence { get; set; }
        public bool isBFS { get; set; }
        // create a graph object 
        public Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
        public bool show { get; set; }

        public void fillNode(string path)
        {
            allNodes.Enqueue(path);
            DirectoryInfo dir = new DirectoryInfo(path);
            DirectoryInfo[] dirArr = dir.GetDirectories();
            if (!isThereFolder(path))
            {
                FileInfo[] fArr = dir.GetFiles();
                foreach(FileInfo files in fArr)
                {
                    allNodes.Enqueue(path + "\\" + files.ToString());
                }
            }
            else
            {
                foreach(DirectoryInfo paths in dirArr)
                {
                    fillNode(path+"\\"+paths.ToString());
                }
            }
        }

        public bool isThereFolder(string path)
        {
            bool thereIs = false;
            int counter = 0;
            DirectoryInfo dir = new DirectoryInfo(path);
            DirectoryInfo[] dirs = dir.GetDirectories();
            foreach(DirectoryInfo folders in dirs)
            {
                counter++;
                thereIs = true;
            }
            return thereIs;
        }

        public void fillNodeBFS()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue(rootPath);
            allNodes.Enqueue(rootPath);

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
                    if (!allNodes.Contains(prefix + stringFile))
                    {
                        allNodes.Enqueue(prefix + stringFile);
                    }
                }

                foreach (DirectoryInfo directory in directories)
                {
                    string stringDirectory = Convert.ToString(directory);
                    if (!allNodes.Contains(prefix + stringDirectory))
                    {
                        allNodes.Enqueue(prefix + stringDirectory);
                        queue.Enqueue(prefix + stringDirectory);
                    }
                }
            }
        }

        public string[] getNodeArray ()
        {
            fillNodeBFS();
            int qLength = allNodes.Count;
            string[] strArray = new string[qLength];
            for (int i = 0; i < qLength; i++)
            {
                strArray[i] = allNodes.Dequeue();
            }
            return strArray;
        }

        public string whichAlgo (bool isBFS)
        {
            if (isBFS)
            {
                return "BFS";
            }
            else
            {
                return "DFS";
            }
        }
    }
}
