using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class FrequencyToEnergyTests
    {
        [TestMethod]
        public void Happycase()
        {
            var Outputs = Collisions.CollisionFuntions.FrequencyToEnergy(new Particles.Photon(1.989E-20, 200));
            Assert.AreEqual(1.326E-31, Outputs);
        }
        [TestMethod]
        public void Edgecase()
        {
            var Outputs1 = Collisions.CollisionFuntions.FrequencyToEnergy(new Particles.Photon(10E-20, 10E50));
            Assert.AreEqual(6.63E+17, Outputs1);
        }
        [TestMethod]
        public void ErrorCase()
        {
            try
            {
                var Outputs = Collisions.CollisionFuntions.FrequencyToEnergy(new Particles.Photon());
            }
            catch (Exception)
            {

                Assert.AreSame(1, 1);
            }


        }
    }
}
