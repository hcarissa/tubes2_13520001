using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dummy.classes
{
    internal class DFS_Algorithm
    {
        public Queue<string> foldersToVisit;
        public Queue<string> visitedFolders;
        public Queue<string> finalPath;
        public string FileTarget;
        public string rootPath;

        public bool isFileHere() // untuk mengecek apakah file berada di directory
        {
            DirectoryInfo di = new DirectoryInfo(rootPath);
            FileInfo[] fileArray = di.GetFiles();
            foreach (FileInfo file in fileArray)
            {
                // jika ada, mengembalikan true
                if(file.Name == FileTarget)
                {
                    return true;
                }
            }
            return false;
        }

        public bool isThereFolder() // mengecek apakah masih ada folder dalam directory
        {
            DirectoryInfo di = new DirectoryInfo(rootPath);
            DirectoryInfo[] directoryArray = di.GetDirectories();
            int counter = 0;
            bool found = false;
            foreach (DirectoryInfo dir in directoryArray)
            {
                counter++;
                found = true; // jika ada mengembalikan true
            }
            return found;
        }

        public bool isFileFound()
        {
            foldersToVisit.Enqueue(rootPath);
            visitedFolders.Enqueue(rootPath);

            while(foldersToVisit.Count != 0)
            {
                string searched = foldersToVisit.Dequeue();
                string slash = searched + "//";
                if(searched[-1] == '/')
                {
                    slash = searched;
                }
                DirectoryInfo rootDir = new DirectoryInfo(searched);
                FileInfo[] fileArr = rootDir.GetFiles();

            }
            return false;
        }
    }
}
