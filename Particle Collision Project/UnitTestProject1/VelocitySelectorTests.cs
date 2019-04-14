using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quadrivia.FunctionalLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class VelocitySelectorTests
    {
        [TestMethod]
        public void HappyCase()
        {
            var a = Collisions.CollisionFuntions.VelocitySelector(new Particles.Proton(0), 100, 4500, 1, FRandom.Seed(1,1));
            Assert.AreEqual(19, FList.Length(a));

            var b = Collisions.CollisionFuntions.VelocitySelector(new Particles.Electron(0), 100, 4500, 1, FRandom.Seed(1, 1));
            Assert.AreEqual(19, FList.Length(b));

            var c = Collisions.CollisionFuntions.VelocitySelector(new Particles.Proton(0), 100, 4500, 1, FRandom.Seed(35, 73));
            Assert.AreEqual(17, FList.Length(c));

            var d = Collisions.CollisionFuntions.VelocitySelector(new Particles.Electron(0), 100, 4000, 1, FRandom.Seed(1, 1));
            Assert.AreEqual(14, FList.Length(d));
        }
    }
}
