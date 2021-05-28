using ProjectANN.ActivationFunctions;
using System;

namespace ProjectANN.Architecture
{
    public class Node
    {
        public double input { get; set; }
        public double output { get; set; }
        public ActivationFunction actFunc { get; set; }
        public double weight { get; set; }

        public Node()
        {

        }

        private double Activate(double inptu)
        {
            var output = Math.Exp(input);

            return output;
        }

        private void GetWeights()
        {

        }
    }
}
