using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dummy.classes
{
    class BFS_Algorithm
    {
        private Queue<string> wereInQueue;
        private Queue<string> visited;
        private Queue<string> finalPath;
        private string rootPath;
        private string fileTarget;
        private bool findAllOccurence;

        public BFS_Algorithm (string rootPathIn, string fileTargetIn, bool findAllOccurenceIn)
        {
            wereInQueue = new Queue<string>();
            visited = new Queue<string>();
            finalPath = new Queue<string>();
            rootPath = rootPathIn;
            fileTarget = fileTargetIn;
            findAllOccurence = findAllOccurenceIn;
        }

        public int getVisitedCount()
        {
            return visited.Count;
        }
        public int getFinalPathCount()
        {
            return finalPath.Count;
        }

        public Queue<string> getFinalPathQueue()
        {
            return finalPath;
        }

        public string[] getVisitedArray ()
        {
            int qLength = visited.Count;
            string[] strArray = new string[qLength];
            for (int i = 0; i < qLength; i++)
            {
                strArray[i] = visited.Dequeue();
            }
            return strArray;
        }

        public string[] getFinalPathArray()
        {
            int qLength = finalPath.Count;
            string[] strArray = new string[qLength];
            for (int i = 0; i < qLength; i++)
            {
                strArray[i] = finalPath.Dequeue();
            }
            return strArray;
        }

        public void fillWereInQueue(string prefix, string path) 
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            FileInfo[] files = directoryInfo.GetFiles();
            DirectoryInfo[] directories = directoryInfo.GetDirectories();
            foreach (FileInfo file in files)
            {
                string stringFile = Convert.ToString(file);
                wereInQueue.Enqueue(prefix + stringFile);
            }
            foreach (DirectoryInfo directory in directories)
            {
                string stringDirectory = Convert.ToString(directory);
                wereInQueue.Enqueue(prefix + stringDirectory);
            }
        }

        public string[] getWereInQueueArray()
        {
            int qLength = wereInQueue.Count;
            string[] strArray = new string[qLength];
            for (int i = 0; i < qLength; i++)
            {
                strArray[i] = wereInQueue.Dequeue();
            }
            return strArray;
        }

        // mencari satu kejadian file ditemukan
        public bool searchOneOccurence ()
        {
            Queue<string> queue = new Queue<string>();
            // inisialisasi queue dgn nilai dari root path
            queue.Enqueue(rootPath);
            visited.Enqueue(rootPath);
            wereInQueue.Enqueue(rootPath);

            while(queue.Count != 0)
            {
                string path = queue.Dequeue();
                // Make a reference to a directory.
                DirectoryInfo parentDir = new DirectoryInfo(path);
                visited.Enqueue(path);
                
                if (parentDir.Extension.Length != 0)
                {
                    if ((parentDir.Name).Equals(fileTarget))
                    {
                        finalPath.Enqueue(parentDir.FullName);
                        return true;
                    }
                }
                else
                {
                    // Get a reference to each file in that parent directory.
                    FileInfo[] files = parentDir.GetFiles();
                    // Get a reference to each directory in that parent directory.
                    DirectoryInfo[] directories = parentDir.GetDirectories();
                    // menambahkan prefix path + '\' utk folder atau file terkini (yg sedang di cek) atau
                    // tidak menambahkan prefix bila path = 'C:\'
                    string prefix = path + "\\";
                    if (path.Equals("C:\\"))
                    {
                        prefix = path;
                    }
                    fillWereInQueue(prefix, path);

                    foreach (FileInfo file in files)
                    {
                        // casting FileInfo type to String
                        string stringFile = Convert.ToString(file);
                        if (!visited.Contains(prefix + stringFile))
                        {
                            queue.Enqueue(prefix + stringFile);
                        }
                    }

                    // iterasi setiap folder pada parent directory
                    foreach (DirectoryInfo directory in directories)
                    {
                        // casting DirectoryInfo type to String
                        string stringDirectory = Convert.ToString(directory);
                        if (!visited.Contains(prefix + stringDirectory))
                        {
                            queue.Enqueue(prefix + stringDirectory);
                        }
                    }
                }
            }
            return false;
        }

        // mencari semua kejadian file ditemukan
        public bool searchAllOccurence ()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue(rootPath);
            visited.Enqueue(rootPath);
            wereInQueue.Enqueue(rootPath);

            while (queue.Count != 0)
            {
                string path = queue.Dequeue();
                DirectoryInfo parentDir = new DirectoryInfo(path);
                visited.Enqueue(path);

                if (parentDir.Extension.Length != 0)
                {
                    if ((parentDir.Name).Equals(fileTarget))
                    {
                        finalPath.Enqueue(parentDir.FullName);
                    }
                }
                else
                {
                    FileInfo[] files = parentDir.GetFiles();
                    DirectoryInfo[] directories = parentDir.GetDirectories();
                    string prefix = path + "\\";
                    if (path.Equals("C:\\"))
                    {
                        prefix = path;
                    }
                    fillWereInQueue(prefix, path);

                    foreach (FileInfo file in files)
                    {
                        string stringFile = Convert.ToString(file);
                        if (!visited.Contains(prefix + stringFile))
                        {
                            queue.Enqueue(prefix + stringFile);
                        }
                    }
                    foreach (DirectoryInfo directory in directories)
                    {
                        string stringDirectory = Convert.ToString(directory);
                        if (!visited.Contains(prefix + stringDirectory))
                        {
                            queue.Enqueue(prefix + stringDirectory);
                        }
                    }
                }
            }
            return (finalPath.Count > 0);
        }

        public bool BFS_search ()
        {
            if (findAllOccurence)
            {
                return searchAllOccurence();
            } 
            else
            {
                return searchOneOccurence();
            }
        }
    }
}
