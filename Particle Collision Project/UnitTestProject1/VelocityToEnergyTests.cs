using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class VelocityToEnergyTests
    {
        [TestMethod]
        public void HappyCase()
        {
            var a = Collisions.CollisionFuntions.VelocityToEnergy(10000, new Particles.Proton(0).RestMass);
            Assert.AreEqual("8.3631095E-20", Convert.ToString(a));
            var b = Collisions.CollisionFuntions.VelocityToEnergy(10000, new Particles.Electron(0).RestMass);
            Assert.AreEqual("4.5545E-23", Convert.ToString(b));
        }
        [TestMethod]
        public void EdgeCase()
        {
            var a = Collisions.CollisionFuntions.VelocityToEnergy(3E8, new Particles.Proton(0).RestMass);
            Assert.AreEqual(7.52679855E-11, a);
            var b = Collisions.CollisionFuntions.VelocityToEnergy(0.0000001, new Particles.Proton(0).RestMass);
            Assert.AreEqual("8.3631095E-42", Convert.ToString(b));
            var c = Collisions.CollisionFuntions.VelocityToEnergy(3E8, new Particles.Electron(0).RestMass);
            Assert.AreEqual("4.09905E-14", Convert.ToString(c));
            var d = Collisions.CollisionFuntions.VelocityToEnergy(0.0000001, new Particles.Electron(0).RestMass);
            Assert.AreEqual("4.5545E-45", Convert.ToString(d));
        }
    }
}
