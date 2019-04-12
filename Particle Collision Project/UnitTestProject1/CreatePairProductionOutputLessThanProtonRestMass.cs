using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class CreatePairProductionOutputLessThanProtonRestMass
    {
        [TestMethod]
        public void HappyCase()
        {
            var a = Collisions.CollisionFuntions.CreatePairproductionOutputLessThanProtonRestMass(new Particles.Photon(1E-10, 100));
            Assert.AreEqual("2.76565133377293E-22", Convert.ToString(a.Velocity));
            Assert.AreEqual(new Particles.Electron(0).GetType(), a.GetType());
        }
    }
}
