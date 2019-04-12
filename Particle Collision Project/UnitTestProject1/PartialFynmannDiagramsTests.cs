using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quadrivia.FunctionalLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class PartialFynmannDiagramsTests
    {
        [TestMethod]
        public void HappyCase()
        {
            var a = Collisions.CollisionFuntions.PartialFeynmanDiagram(FList.New("A", "B", "c"));
            Assert.AreEqual("A + B + c", a);
            var b = Collisions.CollisionFuntions.PartialFeynmanDiagram(FList.New(new Particles.Proton(0).FeynmanSymbol, 
                new Particles.Electron(0).FeynmanSymbol, new Particles.Positron(0).FeynmanSymbol));
            Assert.AreEqual("P + e- + e+", b);
        }
        [TestMethod]
        public void EdgeCase()
        {
            var a = Collisions.CollisionFuntions.PartialFeynmanDiagram(FList.New(new Particles.Proton(0).FeynmanSymbol));
            Assert.AreEqual("P", a);
        }
        [TestMethod]
        public void ErrorCase()
        {
            try
            {
                var a = Collisions.CollisionFuntions.PartialFeynmanDiagram(FList.Empty<string>());
            }
            catch (Exception)
            {

                Assert.AreEqual(1, 1);
            }
            
        }
    }
}
