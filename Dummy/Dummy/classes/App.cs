using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dummy.classes
{
    class App
    {
        public string rootPath { get; set; }
        public string fileTarget { get; set; }
        public bool isAllOccurence { get; set; }
        public bool isBFS { get; set; }
        // create a graph object 
        public Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
        public bool show { get; set; }

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
