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
            bool found = false;
            foreach (FileInfo file in fileArray)
            {
                // jika ada, mengembalikan true
                string fileName = Convert.ToString(file);
                if (fileName.Equals(FileTarget))
                {
                    finalPath.Enqueue(curDir +"\\"+ fileName);
                    if (findAllOccurence)
                    {
                        found = true;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    visitedFolders.Enqueue(curDir +"\\"+ fileName);
                }
            }
            return found;
        }


        public bool DFS_search(string path)
        {
            visitedFolders.Enqueue(path);
            bool found = false;
            DirectoryInfo dir = new DirectoryInfo(path);
            DirectoryInfo[] dirArray = dir.GetDirectories();
            if (findAllOccurence)
            {
                if (isFileHere(path))
                {
                    found = true;
                }
                else
                {
                    foreach (DirectoryInfo dirs in dirArray)
                    {
                        found = DFS_search(path + "\\" + dirs.ToString());
                    }
                }
            }
            else
            {
                if (isFileHere(path))
                {
                    found = true;
                }
                else
                {
                    foreach (DirectoryInfo dirs in dirArray)
                    {
                        found = DFS_search(path + "\\" + dirs.ToString());
                        if (found)
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
