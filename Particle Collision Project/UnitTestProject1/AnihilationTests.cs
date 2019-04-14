using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quadrivia.FunctionalLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class AnihilationTests
    {
        [TestMethod]
        public void HappyCase()
        {
            var a = Collisions.CollisionFuntions.Annialation(new Particles.Proton(10000), new Particles.Antiproton(55560), FRandom.Seed(1, 1));
            Assert.AreEqual("6.60639434893911E-16", Convert.ToString(a.Item1.Wavelength));
            Assert.AreEqual("4.54105498634328E+23", Convert.ToString(a.Item1.Frequency));
            Assert.AreEqual(new Particles.Photon().GetType(), a.Item1.GetType());
            Assert.AreEqual(new Particles.Photon().GetType(), a.Item2.GetType());
        }
        
    }
}
