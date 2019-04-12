using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class EnergyToWavelengthTests
    {
        [TestMethod]
        public void HappyCase()
        {
            var Outputs = Collisions.CollisionFuntions.EnergyToWavelength(1000);
            Assert.AreEqual("1.989E-28", Convert.ToString(Outputs));
        }
        [TestMethod]
        public void EdgeCase()
        {
            var Outputs = Collisions.CollisionFuntions.EnergyToWavelength(1000000000000);
            Assert.AreEqual(1.989E-37, Outputs);
        }
    }
}
