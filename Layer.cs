using System.Collections.Generic;

namespace ProjectANN
{
    class Layer
    {
        public int numNodes { get; set; }
        public List<Node> Nodes { get; set; }


        public Layer()
        {

        }

        public Layer(int nNodes)
        {
            numNodes = nNodes;
        }
    }
}
