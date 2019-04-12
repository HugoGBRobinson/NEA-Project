using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quadrivia.FunctionalLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class FeynmannTests
    {
        //Happy Case
        [TestMethod]
        public void SingleSymbol()
        {
            var a = Collisions.CollisionFuntions.PartialFeynmanDiagram(FList.New("a"));
            Assert.AreEqual("a", a);
        }

        [TestMethod]
        public void TwoSymbolsAndPlus()
        {
            var a = Collisions.CollisionFuntions.PartialFeynmanDiagram(FList.New("a", "b"));
            Assert.AreEqual("a + b", a);
        }

        [TestMethod]
        public void ThreeSymbolsAndPlus()
        {
            var a = Collisions.CollisionFuntions.PartialFeynmanDiagram(FList.New("a", "b", "c"));
            Assert.AreEqual("a + b + c", a);
        }

        [TestMethod]
        public void TwoListsAndArrow()
        {
            var a = Collisions.CollisionFuntions.FeynmanDiagram(FList.New("a", "b", "c"), FList.New("d", "e", "f"));
            Assert.AreEqual("a + b + c ---> d + e + f", a);
        }
    }
}
