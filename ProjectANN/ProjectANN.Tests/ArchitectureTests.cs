using NUnit.Framework;
using ProjectANN.Architecture;
using ProjectANN.ActivationFunctions;
using System;

namespace ProjectANN.ArchitectureTests
{
    [TestFixture]
    public class ArchitectureTests
    {
        [Test]
        public void NeuralNetwork_CanCreate()
        {
            var n = new NeuralNet();
            var ann = new NeuralNet();
            var relu = new Relu();

            var ans = relu.Apply(5);
        }
    }
}
