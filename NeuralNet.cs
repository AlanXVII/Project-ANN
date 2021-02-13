using System.Collections.Generic;

namespace ProjectANN
{
    class NeuralNet
    {
        public string name { get; set; }
        public double numLayers { get; private set; }
        public List<Layer> Layers { get; set; }        


        public NeuralNet()
        {
            Layers = new List<Layer>();                    
        }

        public void AddLayer(Layer layer)
        {
            var _nodes = GetNodes(layer.numNodes);
            layer.Nodes = _nodes;

            Layers.Add(layer);
            numLayers = Layers.Count;
        }

        private List<Node> GetNodes(int numNodes)
        {
            var _nodes = new List<Node>();

            for (int i = 0; i < numNodes; i++)
            {
                var _node = new Node();
                _nodes.Add(_node);

            }            
            return _nodes;
        }

        public void Fit(double[][] X, double[] y, int epochs)
        {

        }
    }
}
