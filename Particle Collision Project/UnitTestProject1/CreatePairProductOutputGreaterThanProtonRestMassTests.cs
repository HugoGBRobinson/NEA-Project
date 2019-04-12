using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class CreatePairProductOutputGreaterThanProtonRestMassTests
    {
        [TestMethod]
        public void HappyCase()
        {
            var a = Collisions.CollisionFuntions.CreatePairproductionOutputGreaterThanProtonRestMass(new Particles.Photon(1E-10, 100));
            Assert.AreEqual("5.0178988498905E-19", Convert.ToString(a.Velocity));
            Assert.AreEqual(new Particles.Proton(0).GetType(), a.GetType());
        }
    }
}
