using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class CreateAnnihilationPhotomTests
    {
        [TestMethod]
        public void HappyCase()
        {
            var a = Collisions.CollisionFuntions.CreateAnnialationPhoton(new Particles.Proton(1000), new Particles.Antiproton(1000));
            Assert.AreEqual(new Particles.Photon().GetType(), a.GetType());
            Assert.AreEqual("4.54105493217715E+23", Convert.ToString(a.Frequency));
            
            var b = Collisions.CollisionFuntions.CreateAnnialationPhoton(new Particles.Electron(1000), new Particles.Positron(1000));
            Assert.AreEqual(new Particles.Photon().GetType(), b.GetType());
            Assert.AreEqual("2.47303167423562E+20", Convert.ToString(b.Frequency));

            var c = Collisions.CollisionFuntions.CreateAnnialationPhoton(new Particles.Proton(1000), new Particles.Antiproton(1000));
            Assert.AreEqual("6.60639442774079E-16", Convert.ToString(c.Wavelength));
        }
        [TestMethod]
        public void EdgeCase()
        {
            var a = Collisions.CollisionFuntions.CreateAnnialationPhoton(new Particles.Proton(0), new Particles.Antiproton(0));
            Assert.AreEqual("4.5410549321267E+23", Convert.ToString(a.Frequency));
        }
    }
}
