using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quadrivia.FunctionalLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class PairProductionTests
    {
        [TestMethod]
        public void HappyCase()
        {
            var a = Collisions.CollisionFuntions.PairProductionPhoton(new Particles.Photon(100, 100), FRandom.Seed(1, 1));
            Assert.AreEqual(new Particles.Electron(0).GetType(), a.Item1.GetType());


            var b = Collisions.CollisionFuntions.PairProductionPhoton(new Particles.Photon(800E-16,1E25), FRandom.Seed(1, 1));
            Assert.AreEqual(new Particles.Proton(0).GetType(), b.Item1.GetType());
        }
        [TestMethod]
        public void EdgeCase()
        {
            var a = Collisions.CollisionFuntions.PairProductionPhoton(new Particles.Photon(1, 1E100),FRandom.Seed(1,1));
            Assert.AreEqual(new Particles.Proton(0).GetType(), a.Item1.GetType());
            var b = Collisions.CollisionFuntions.PairProductionPhoton(new Particles.Photon(1, 1E-100), FRandom.Seed(1, 1));
            Assert.AreEqual(new Particles.Electron(0).GetType(), b.Item1.GetType());
        }

        
    }
}
