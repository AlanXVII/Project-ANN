using ProjectANN.ActivationFunctions;
using ProjectANN.Architecture;
using NUnit.Framework;


namespace ProjectANN.ActivationFunctions.Tests
{
    [TestFixture]
    public class ActivationFunctionsTests
    {
        [Test]
        public void NeuralNetwork_CanCreate()
        {
            var ann = new NeuralNet();
            var relu = new Relu();

            var ans = relu.Apply(5);

            Assert.That(ans, Is.EqualTo(2));
        }
    }
}
