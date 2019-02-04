using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quadrivia.FunctionalLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class AnihilationTests
    {
        [TestMethod]
        public void OverTheSpeedOFLight()
        {
            var a = Collisions.CollisionFuntions.Annialation(new Particles.Proton(300000001), new Particles.Antiproton(299999999), FRandom.Seed(1, 1));
            Assert.AreEqual("That is faster than the speed of light, which is not allowed", a);
        }
    }
}
