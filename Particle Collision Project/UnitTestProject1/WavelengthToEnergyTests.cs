using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class WavelengthToEnergyTests
    {
        [TestMethod]
        public void Happycase()
        {
            var Outputs = Collisions.CollisionFuntions.WavelengthToEnergy(new Particles.Photon(1.989E-20, 200));
            Assert.AreEqual((6.63E-34*3E8)/1.989E-20, Outputs);
        }
        [TestMethod]
        public void Edgecase()
        {
            var Outputs1 = Collisions.CollisionFuntions.WavelengthToEnergy(new Particles.Photon(10E-20,10E50));
            Assert.AreEqual(1.989E-06, Outputs1);
        }
        [TestMethod]
        public void ErrorCase()
        {
            try
            {
                var Outputs = Collisions.CollisionFuntions.WavelengthToEnergy(new Particles.Photon());
            }
            catch (Exception)
            {

                Assert.AreSame(1, 1);
            }
            
            
        }

    }
}
