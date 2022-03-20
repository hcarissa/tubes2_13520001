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
        public Queue<string> queue;
        public Queue<string> visited;
        public Queue<string> finalPath;
        public string rootPath;
        public string fileTarget;
        public bool findAllOccurence;

        public BFS_Algorithm (string rootPathIn, string fileTargetIn, bool findAllOccurenceIn)
        {
            queue = new Queue<string>();
            visited = new Queue<string>();
            finalPath = new Queue<string>();
            rootPath = rootPathIn;
            fileTarget = fileTargetIn;
            findAllOccurence = findAllOccurenceIn;
        }

        // mencari satu kejadian file ditemukan
        public bool searchOneOccurence ()
        {
            // inisialisasi queue dgn nilai dari root path
            queue.Enqueue(rootPath);
            visited.Enqueue(rootPath);

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

                // Get a reference to each directory in that parent directory.
                DirectoryInfo[] directories = parentDir.GetDirectories();
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
            // inisialisasi queue dgn nilai dari root path
            queue.Enqueue(rootPath);
            visited.Enqueue(rootPath);

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
