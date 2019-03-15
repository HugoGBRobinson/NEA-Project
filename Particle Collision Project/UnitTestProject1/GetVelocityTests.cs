using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class GetVelocityTests
    {
        [TestMethod]
        public void Happycase()
        {
            var Output = Collisions.CollisionFuntions.GetVelocity(new Particles.Proton(1000));
            Assert.AreEqual(1000, Output);
            var Output2 = Collisions.CollisionFuntions.GetVelocity(new Particles.Neutron(3E-9));
            Assert.AreEqual(3E-9, Output2);
            var Output3 = Collisions.CollisionFuntions.GetVelocity(new Particles.Electron(3.8294));
            Assert.AreEqual(3.8294, Output3);
            var Output4 = Collisions.CollisionFuntions.GetVelocity(new Particles.Photon());
            Assert.AreEqual(3E8, Output4);
        }

    }
}
