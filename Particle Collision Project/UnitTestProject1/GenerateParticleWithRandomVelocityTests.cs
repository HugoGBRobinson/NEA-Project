using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quadrivia.FunctionalLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class GenerateParticleWithRandomVelocityTests
    {
        [TestMethod]
        public void HappyCase()
        {
            var a = Collisions.CollisionFuntions.GenerateParticleWithRandomVelocity(new Particles.Proton(0), FRandom.Seed(1, 1));
            Assert.AreEqual(new Particles.Proton(0).GetType(), a.GetType());
            Assert.AreEqual(2822, a.Velocity);
        }
    }
}
