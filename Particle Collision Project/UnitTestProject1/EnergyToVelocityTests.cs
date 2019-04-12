using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class EnergyToVelocityTests
    {
        [TestMethod]
        public void HappyCase()
        {
            var Outputs = Collisions.CollisionFuntions.EnergyToVelocity(1000, 10);
            Assert.AreEqual(141,Math.Round(Outputs));
        }
        [TestMethod]
        public void EdgeCase()
        {
            var Outputs = Collisions.CollisionFuntions.EnergyToVelocity(1000000000, 100000000);
            Assert.AreEqual(447213595, Math.Round(Outputs));
        }
    }
}
