using System;

namespace ProjectANN.ActivationFunctions
{
    public class Relu : ActivationFunction
    {
        public double _input { get; set; }
        public Relu()
        {

        }

        public override double Apply(double input)
        {
            var _output = Math.Exp(input);

            return _output;
        }
    }
}
