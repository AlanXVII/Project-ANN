using System;
using System.Collections.Generic;
using ProjectANN.Architecture;
using ProjectANN.ActivationFunctions;

namespace ProjectANN.Main
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
            Layers.Add(layer);
            numLayers = Layers.Count;
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
                ExecuteForwardPhase();
                BackPropogate();
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

        public void ExecuteForwardPhase()
        {
            throw new NotImplementedException();
        }

        public void BackPropogate()
        {
            throw new NotImplementedException();
        }
    }
}
