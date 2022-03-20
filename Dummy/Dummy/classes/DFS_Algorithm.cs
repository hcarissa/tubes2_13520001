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
        public Queue<string> visitedFolders;
        public Queue<string> finalPath;
        public string FileTarget;
        public string rootPath;
        public bool findAllOccurence;

        public DFS_Algorithm(string FileTargetIn, string rootPathIn, bool findAllOccurenceIn)
        {
            visitedFolders = new Queue<string>();
            finalPath = new Queue<string>();
            FileTarget = FileTargetIn;
            rootPath = rootPathIn;
            findAllOccurence = findAllOccurenceIn;

        }

        public bool isFileHere(string curDir) // untuk mengecek apakah file berada di directory
        {
            DirectoryInfo di = new DirectoryInfo(curDir);
            FileInfo[] fileArray = di.GetFiles();
            foreach (FileInfo file in fileArray)
            {
                // jika ada, mengembalikan true
                string fileName = Convert.ToString(file);

                // check if filename is same as the searched one
                if (fileName.Equals(FileTarget))
                {
                    // if same add to finalpath
                    finalPath.Enqueue(curDir +"\\"+ fileName);
                    return true;
                }
                else
                {
                    //if not, add to visited folders
                    visitedFolders.Enqueue(curDir +"\\"+ fileName);
                }
            }
            return false;
        }

        // main DFS search
        public bool DFS_search(string path)
        {
            visitedFolders.Enqueue(path);
            bool found = false;
            DirectoryInfo dir = new DirectoryInfo(path);
            DirectoryInfo[] dirArray = dir.GetDirectories();
            // if find all occurence
            if (findAllOccurence)
            {
                // check on the path
                if (isFileHere(path))
                {
                    found = true;
                }
                else // if not on path
                {
                    // check for every directory
                    foreach (DirectoryInfo dirs in dirArray)
                    {
                        found = DFS_search(path + "\\" + dirs.ToString());
                    }
                }
            }
            else // if not find all occurence
            {
                if (isFileHere(path)) // check on path
                {
                    found = true;
                }
                else // if not found on path
                {
                    // check in directory
                    foreach (DirectoryInfo dirs in dirArray)
                    {
                        found = DFS_search(path + "\\" + dirs.ToString());
                        if (found) //if found, directly return true
                        {
                            return true;
                        }
                    }
                }
            }
            return found;
        }
    }
}
