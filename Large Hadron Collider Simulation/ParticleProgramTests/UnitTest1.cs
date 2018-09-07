using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ParticleProgramTests
{
    [TestClass]
    public class BaryontTests
    {
        [TestClass]
        public class HadronTests
        {
            [TestMethod]
            public void ProtonTest()
            {
                Assert.AreEqual(true, new Particle.Proton(1, 1,true).ClassCompleted);
            }
            [TestMethod]
            public void NeutronTest()
            {
                Assert.AreEqual(true, new Particle.Neutron(1, 1,true).ClassCompleted);
            }
           
        }
        [TestClass]
        public class MesonTests
        {
            [TestMethod]
            public void AnyMesonsImplimentated()
            {
                Assert.Fail();
            }
        }

    }

    [TestClass]
    public class QuarkTests
    {
        [TestMethod]
        public void UpTest()
        {
            Assert.AreEqual(true, new Particle.Up().ClassCompleted);
        }
        [TestMethod]
        public void DownTest()
        {
            Assert.AreEqual(true, new Particle.Down().ClassCompleted);
        }
        [TestMethod]
        public void TopTest()
        {
            Assert.AreEqual(true, new Particle.Top().ClassCompleted);
        }
        [TestMethod]
        public void BottomTest()
        {
            Assert.AreEqual(true, new Particle.Botton().ClassCompleted);
        }
        [TestMethod]
        public void StrangeTest()
        {
            Assert.AreEqual(true, new Particle.Strange().ClassCompleted);
        }
        [TestMethod]
        public void CharmTest()
        {
            Assert.AreEqual(true, new Particle.Charm().ClassCompleted);
        }


    }

    [TestClass]
    public class LeptonTests
    {
        [TestMethod]
        public void ElectonTest()
        {
            Assert.AreEqual(true, new Particle.Electron().ClassCompleted);
        }
        [TestMethod]
        public void PhotonTest()
        {
            Assert.AreEqual(true, new Particle.Photon().ClassCompleted);
        }


    }
}
