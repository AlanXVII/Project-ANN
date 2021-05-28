using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectANN.ActivationFunctions
{
    public class Sigmoid : ActivationFunction
    {
        public double _input { get; set; }
        public Sigmoid()
        {

        }

        public override double Apply(double input)
        {
            var _output = 1 / (1 + Math.Exp(-input));

            return _output;
        }
    }
}
