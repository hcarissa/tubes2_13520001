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
        private string rootPath { get; set; }
        private string fileTarget { get; set; }
        private bool isAllOccurence { get; set; }
        private bool isBFS { get; set; }
        private bool showGraph { get; set; }

        public App(){
            rootPath = "";
            fileTarget = "";
            isAllOccurence = false;
            isBFS = false;
            showGraph = false;
        }

        public void setRootPath(string value) 
        {
            rootPath = value;
        }

        public string getRootPath() 
        {
           return rootPath;
        }

        public void setFileTarget(string value) 
        {
            fileTarget = value;
        }
        public string getFileTarget() 
        {
            return fileTarget;
        }

        public void setIsAllOccurence(bool value) 
        {
            isAllOccurence = value;
        }

        public bool getIsAllOccurence() 
        {
            return isAllOccurence;
        }

        public void setIsBFS(bool value) 
        {
            isBFS = value;
        }

        public bool getIsBFS() 
        {
            return isBFS;
        }

        public void setShowGraph(bool value) 
        {
            showGraph = value;
        }

        public bool getShowGraph()  
        {
            return showGraph;
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
