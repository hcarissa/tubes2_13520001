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
        private Queue<string> visitedFolders;
        private Queue<string> finalPath;
        private string FileTarget;
        private string rootPath;
        private bool findAllOccurence;

        public DFS_Algorithm(string FileTargetIn, string rootPathIn, bool findAllOccurenceIn)
        {
            visitedFolders = new Queue<string>();
            finalPath = new Queue<string>();
            FileTarget = FileTargetIn;
            rootPath = rootPathIn;
            findAllOccurence = findAllOccurenceIn;

        }

        public int getVisitedFoldersCount()
        {
            return visitedFolders.Count;
        }

        public int getFinalPathCount()
        {
            return finalPath.Count;
        }

        public Queue<string> getFinalPathQueue()
        {
            return finalPath;
        }
        
        public string[] getVisitedArray()
        {
            int qLength = visitedFolders.Count;
            string[] strArray = new string[qLength];
            for (int i = 0; i < qLength; i++)
            {
                strArray[i] = visitedFolders.Dequeue();
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
                    // if found, add path to finalpath
                    finalPath.Enqueue(curDir +"\\"+ fileName);
                    visitedFolders.Enqueue(curDir + "\\" + fileName);
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
                    // if not found, add path to visitedfolders
                    visitedFolders.Enqueue(curDir +"\\"+ fileName);
                }
            }
            return found;
        }

        // main function
        public bool DFS_search(string path)
        {
            visitedFolders.Enqueue(path);
            bool found = false;
            DirectoryInfo dir = new DirectoryInfo(path);
            DirectoryInfo[] dirArray = dir.GetDirectories();
            // if have to find all occurence
            if (findAllOccurence)
            {
                isFileHere(path);
                foreach (DirectoryInfo dirs in dirArray)
                {
                    found = DFS_search(path + "\\" + dirs.ToString());
                }
                /*
                //find file in dir
                if (isFileHere(path))
                {
                    found = true;
                    foreach (DirectoryInfo dirs in dirArray)
                    {
                        found = DFS_search(path + "\\" + dirs.ToString());
                    }
                }
                else
                {
                    // find folders in files in dir
                    foreach (DirectoryInfo dirs in dirArray)
                    {
                        found = DFS_search(path + "\\" + dirs.ToString());
                    }
                }
                */
            }
            else // first found
            {
                // if file found, add to final
                if (isFileHere(path))
                {
                    return true;
                }
                else
                {
                    // if found in dir, immidiately return
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
