using System;
using ProjectANN.Architecture;
using ProjectANN.ActivationFunctions;
using ProjectANN.Main;

namespace ProjectANN
{
    class Program
    {
        static void Main(string[] args)
        {
            var Xone = new double[5] { 19, 98, 10, 67, 5 };
            var Xtwo = new double[5] { 77, 83, 12, 77, 35 };
            var Xthree = new double[5] { 79, 38, 2, 47, 91 };

            var X_train = new double[3][];

            X_train[0] = Xone;
            X_train[1] = Xtwo;
            X_train[2] = Xthree;

            var y_train = new double[5] { 1, 2, 3, 4, 5 };

            var ann = new NeuralNet();
            var relu = new Relu();

            ann.AddLayer(new Layer(5, relu));
            ann.AddLayer(new Layer(1, relu));

            ann.Fit(X_train, y_train, 2, 69);
        }
    }
}
