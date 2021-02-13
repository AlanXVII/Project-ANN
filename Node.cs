using System;

namespace ProjectANN
{
    class Node
    {
        public double input { get; set; }
        public double output { get; set; }


        public Node()
        {

        }

        private double Activate(double inptu)
        {
            var output = Math.Exp(input);

            return output;
        }
    }
}
