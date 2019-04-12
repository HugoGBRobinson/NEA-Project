using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class BetaPlusIndividualDecay
    {
        [TestMethod]
        public void HappyCase()
        {
            var a = Collisions.CollisionFuntions.BetaPlusDecayIndividual(new Particles.Proton(0));
            Assert.AreEqual(new Particles.Neutron(0).GetType(), a.Item1.GetType());
            Assert.AreEqual(new Particles.Positron(0).GetType(), a.Item2.GetType());
            Assert.AreEqual(new Particles.ElectronNeutrino(0).GetType(), a.Item3.GetType());
        }
    }
}
