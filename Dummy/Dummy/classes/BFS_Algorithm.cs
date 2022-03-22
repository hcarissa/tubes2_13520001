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
        public Queue<string> wereInQueue;
        public Queue<string> visited;
        public Queue<string> finalPath;
        public string rootPath;
        public string fileTarget;
        public bool findAllOccurence;

        public BFS_Algorithm (string rootPathIn, string fileTargetIn, bool findAllOccurenceIn)
        {
            wereInQueue = new Queue<string>();
            visited = new Queue<string>();
            finalPath = new Queue<string>();
            rootPath = rootPathIn;
            fileTarget = fileTargetIn;
            findAllOccurence = findAllOccurenceIn;
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
                // menambahkan prefix path + '\' utk folder atau file terkini (yg sedang di cek) atau
                // tidak menambahkan prefix bila path = 'C:\'
                string prefix = path + "\\";
                if (path.Equals("C:\\"))
                {
                    prefix = path;
                }

                // Make a reference to a directory.
                DirectoryInfo parentDir = new DirectoryInfo(path);
                // Get a reference to each file in that parent directory.
                FileInfo[] files = parentDir.GetFiles();
                // iterasi setiap file pada parent directory
                // Get a reference to each directory in that parent directory.
                DirectoryInfo[] directories = parentDir.GetDirectories();
                
                fillWereInQueue(prefix, path);

                foreach (FileInfo file in files) 
                {
                    // casting FileInfo type to String
                    string stringFile = Convert.ToString(file);

                    if (!visited.Contains(prefix + stringFile))
                    {
                        visited.Enqueue(prefix + stringFile);
                        if (stringFile.Equals(fileTarget))
                        {
                            finalPath.Enqueue(prefix + stringFile);
                            return true;
                        }
                    }
                }

                // iterasi setiap folder pada parent directory
                foreach (DirectoryInfo directory in directories) 
                {
                    // casting DirectoryInfo type to String
                    string stringDirectory = Convert.ToString(directory);

                    if (!visited.Contains(prefix + stringDirectory))
                    {
                        visited.Enqueue(prefix + stringDirectory);
                        queue.Enqueue(prefix + stringDirectory);
                    }
                }
            }
            return false;
        }

        // mencari semua kejadian file ditemukan
        public bool searchAllOccurence ()
        {
            Queue<string> queue = new Queue<string>();
            // inisialisasi queue dgn nilai dari root path
            queue.Enqueue(rootPath);
            visited.Enqueue(rootPath);
            wereInQueue.Enqueue(rootPath);

            while (queue.Count != 0)
            {
                string path = queue.Dequeue();
                // menambahkan prefix path + '\' utk folder atau file terkini (yg sedang di cek) atau
                // tidak menambahkan prefix bila path = 'C:\'
                string prefix = path + "\\";
                if (path.Equals("C:\\"))
                {
                    prefix = path;
                }

                // Make a reference to a directory.
                DirectoryInfo parentDir = new DirectoryInfo(path);
                // Get a reference to each file in that parent directory.
                FileInfo[] files = parentDir.GetFiles();
                // Get a reference to each directory in that parent directory.
                DirectoryInfo[] directories = parentDir.GetDirectories();

                fillWereInQueue(prefix, path);

                // iterasi setiap file pada parent directory
                foreach (FileInfo file in files)
                {
                    // casting FileInfo type to String
                    string stringFile = Convert.ToString(file);

                    if (!visited.Contains(prefix + stringFile))
                    {
                        visited.Enqueue(prefix + stringFile);
                        if (stringFile.Equals(fileTarget))
                        {
                            finalPath.Enqueue(prefix + stringFile);
                        }
                    }
                }

                // iterasi setiap folder pada parent directory
                foreach (DirectoryInfo directory in directories)
                {
                    // casting DirectoryInfo type to String
                    string stringDirectory = Convert.ToString(directory);

                    if (!visited.Contains(prefix + stringDirectory))
                    {
                        visited.Enqueue(prefix + stringDirectory);
                        queue.Enqueue(prefix + stringDirectory);
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
