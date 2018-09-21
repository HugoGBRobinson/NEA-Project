using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Particle;

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

                var p = new Proton(1, true);

                Assert.AreEqual(1.6726219 * Math.Pow(10, -27), p.RestMass);
                Assert.AreEqual(1, p.RelativeCharge);
                Assert.AreEqual(1, p.BaryonNumber);
            }
            [TestMethod]
            public void NeutronTest()
            {
                var n = new Neutron(1, true);
                Assert.AreEqual(1.674929 * Math.Pow(10, -27), n.RestMass);
                Assert.AreEqual(0, n.RelativeCharge);
                Assert.AreEqual(1, n.BaryonNumber);

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
            var up = new Up();
            Assert.AreEqual((2 / 3), up.Charge);
            Assert.AreEqual(0, up.Strangeness);
        }
        [TestMethod]
        public void DownTest()
        {
            var down = new Down();
            Assert.AreEqual(-(1/3), down.Charge);
            Assert.AreEqual(0, down.Strangeness);
        }
        [TestMethod]
        public void TopTest()
        {
            var top= new Top();
            Assert.AreEqual((2 / 3), top.Charge);
            Assert.AreEqual(0, top.Strangeness);
        }
        [TestMethod]
        public void BottomTest()
        {
            var bottom = new Botton();
            Assert.AreEqual(-(1 / 3), bottom.Charge);
            Assert.AreEqual(0, bottom.Strangeness);
        }
        [TestMethod]
        public void StrangeTest()
        {
            var strange = new Strange();
            Assert.AreEqual(-(1 / 3), strange.Charge);
            Assert.AreEqual(-1, strange.Strangeness);
        }
        [TestMethod]
        public void CharmTest()
        {
            var charm = new Charm();
            Assert.AreEqual((2 / 3), charm.Charge);
            Assert.AreEqual(0, charm.Strangeness);
        }


    }

    [TestClass]
    public class LeptonTests
    {
        [TestMethod]
        public void ElectonTest()
        {
            Assert.Fail();
        }
        [TestMethod]
        public void PhotonTest()
        {
            Assert.Fail();
        }


    }
}
