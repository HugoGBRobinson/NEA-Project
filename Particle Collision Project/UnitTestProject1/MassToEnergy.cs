using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class MassToEnergy
    {
        [TestMethod]
        public void HappyCase()
        {
            var a = Collisions.CollisionFuntions.MassToEnergy(new Particles.Proton(0).RestMass);
            Assert.AreEqual("1.50535971E-10", Convert.ToString(a));
            var b = Collisions.CollisionFuntions.MassToEnergy(new Particles.Electron(0).RestMass);
            Assert.AreEqual("8.1981E-14", Convert.ToString(b));
        }
        [TestMethod]
        public void EdgeCase()
        {
            var a = Collisions.CollisionFuntions.MassToEnergy(100000);
            Assert.AreEqual(9E+21, a);
            var b = Collisions.CollisionFuntions.MassToEnergy(1E-50);
            Assert.AreEqual("9E-34", Convert.ToString(b));

        }
    }
}
