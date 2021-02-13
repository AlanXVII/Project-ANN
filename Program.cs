using System;

namespace ProjectANN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var ann = new NeuralNet();

            ann.AddLayer(new Layer(5));
        }
    }
}
