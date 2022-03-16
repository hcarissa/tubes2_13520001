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
