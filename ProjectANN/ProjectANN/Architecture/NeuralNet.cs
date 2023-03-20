using System;
using System.Collections.Generic;

namespace ProjectANN.Architecture
{
    public class NeuralNet
    {
        public string Name { get; set; }
        public int NumLayers { get; private set; }
        public List<Layer> Layers { get; set; }        


        public NeuralNet()
        {
            Layers = new List<Layer>();                    
        }

        public void AddLayer(Layer layer)
        { 
            Layers.Add(layer);
            NumLayers = Layers.Count;
        }

        public void Fit(double[][] X, double[] y, int epochs, int seed)
        {
            foreach(var layer in Layers)
            {
                var initialWeights = GenerateRandomWeights(layer.numNodes, seed);
                var count = 0;

                foreach (var node in layer.Nodes)
                {
                    node.weight = initialWeights[count];
                    count++;
                }
            }

            for (int ep = 0; ep < epochs; ep++)
            {
                // feed feature f's inputs to first layer's nodes
                for (int f = 0; f < X[0].Length; f++)
                {
                    for (int i = 0; i < Layers[0].numNodes; i++)
                    {
                        Layers[0].Nodes[i].input = Layers[0].Nodes[i].weight * X[f][i];
                        Layers[0].Nodes[i].output = Layers[0].Nodes[i].actFunc.Apply(Layers[0].Nodes[i].input);
                    }

                    //ExecuteForwardPhase();
                    BackPropogate();
                }
            }
        }

        private double[] GenerateRandomWeights(int numberOfWeights, int seed)
        {
            var _weights = new double[numberOfWeights];

            for (int w = 0; w < numberOfWeights; w++)
            {
                var rand = new Random(seed);
                _weights[w] = rand.NextDouble();
            }

            return _weights;
        }

        //public void ExecuteForwardPhase()
        //{
        //    for (int i = 1; i < Layers.Count; i++)
        //    {

        //        //Vector<double> input = new DenseVector(length: Layers.Count);
        //        //var weights = new Vector<double>;
        //       // var outputs = new Vector<double>;


        //       // outputs = Vector.Multiply<double>(input, weights);

        //        for (int j = 0; j < Layers[i].numNodes; j++)
        //        {
        //            Layers[i].Nodes[j].input = Layers[i].Nodes[j].weight * Layers[i-1].Nodes[j].output;
        //            Layers[i].Nodes[j].output = Layers[i].Nodes[j].actFunc.Apply(Layers[i].Nodes[j].input);
        //        }
        //    }
        //}

        public void BackPropogate()
        {
            throw new NotImplementedException();
        }
    }
}
