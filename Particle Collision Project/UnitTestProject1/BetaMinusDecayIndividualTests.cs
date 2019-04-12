using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class BetaMinusDecayIndividualTests
    {
        [TestMethod]
        public void HappyCase()
        {
            var a = Collisions.CollisionFuntions.BetaMinusDecayIndividual(new Particles.Neutron(0));
            Assert.AreEqual(new Particles.Proton(0).GetType(), a.Item1.GetType());
            Assert.AreEqual(new Particles.Electron(0).GetType(), a.Item2.GetType());
            Assert.AreEqual(new Particles.AntiElectronNeutrino(0).GetType(), a.Item3.GetType());
        }
    }
}
