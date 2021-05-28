using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectANN.ActivationFunctions
{
    public class Tanh : ActivationFunction
    {
        public double _input { get; set; }
        public Tanh()
        {

        }

        public override double Apply(double input)
        {
            var _output = (Math.Exp(input) - Math.Exp(-input)) 
                / (Math.Exp(input) + Math.Exp(-input));

            return _output;
        }
    }
}
