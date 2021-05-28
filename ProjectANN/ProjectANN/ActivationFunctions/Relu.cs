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
            var _output = Math.Max(0.0, input);

            return _output;
        }
    }
}
