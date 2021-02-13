using ProjectANN.ActivationFunctions;
using System;
using System.Collections.Generic;

namespace ProjectANN.Architecture
{
    public class Layer
    {
        public int numNodes { get; set; }
        public List<Node> Nodes { get; set; }
        public ActivationFunction actFunc { get; set; }

        public Layer(int nNodes, ActivationFunction func)
        {
            Nodes = GenerateNodes(nNodes);

            foreach (var nd in Nodes)
            {
                //nd.input =
                nd.actFunc = func;
                nd.weight = 0;
            }

            numNodes = nNodes;
            actFunc = actFunc;
        }

        private List<Node> GenerateNodes(int numNodes)
        {
            var _nodes = new List<Node>();

            for (int i = 0; i < numNodes; i++)
            {
                var _node = new Node();
                _nodes.Add(_node);

            }
            return _nodes;
        }
    }
}
