using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class GetRestMassTests
    {
        [TestMethod]
        public void Happycase()
        {
            var Output = Collisions.CollisionFuntions.GetRestMass(new Particles.Proton(0));
            Assert.AreEqual(1.6726219E-27, Output);
            var Output2 = Collisions.CollisionFuntions.GetRestMass(new Particles.Neutron(0));
            Assert.AreEqual(1.674929E-27, Output2);
            var Output3 = Collisions.CollisionFuntions.GetRestMass(new Particles.Electron(0));
            Assert.AreEqual(9.109E-31, Output3); 
        }
        [TestMethod]
        public void Errorcase() //As a photon does not have a rest mass and I have not added it as a peramiter to the photon class
        {
            var Output = Collisions.CollisionFuntions.GetRestMass(new Particles.Photon());
            Assert.AreEqual(0, Output);
        }
    }
}
