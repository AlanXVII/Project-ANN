namespace ProjectANN.ActivationFunctions
{
    public abstract class ActivationFunction
    {
        public double input { get; set; }
        public double output { get; set; }

        public abstract double Apply(double input);

    }
}
