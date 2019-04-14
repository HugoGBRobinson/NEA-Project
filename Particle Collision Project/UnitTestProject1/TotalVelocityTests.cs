using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quadrivia.FunctionalLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class TotalVelocityTests
    {
        [TestMethod]
        public void HappyCase()
        {
            var Outputs = Collisions.CollisionFuntions.TotalVelocity(FList.New<double>(234, 4322, new Particles.Proton(48893).Velocity));
            Assert.AreEqual(53449, Outputs);
        }
        [TestMethod]
        public void EdgeCase()
        {
            var Outputs1 = Collisions.CollisionFuntions.TotalVelocity(FList.New<double>(3E8,123434));
            Assert.AreEqual(300123434, Outputs1);
            var Outputs2 = Collisions.CollisionFuntions.TotalVelocity(FList.New<double>(1E-50, 1E-50));
            Assert.AreEqual(2E-50, Outputs2);
        }
    }
}
