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
        public void NeuralNetwork_InitiliaseNetwork_CreatedCorrectly()
        {
            var ann = new NeuralNet();
            ann.AddLayer(new Layer(5, new Relu()));
            ann.AddLayer(new Layer(10, new Tanh()));

            Assert.That(ann.numLayers, Is.EqualTo(2));
            Assert.That(ann.Layers.Count, Is.EqualTo(ann.numLayers));
            Assert.That(ann.Layers[0].numNodes, Is.EqualTo(5));
            Assert.That(ann.Layers[0].Nodes.Count, Is.EqualTo(ann.Layers[0].numNodes));
        }
    }
}
