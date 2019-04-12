using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quadrivia.FunctionalLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class VelocitySelectorTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var a = Collisions.CollisionFuntions.VelocitySelector(new Particles.Proton(0), 100, 4500, 1, FRandom.SeedDefault());
            Assert.AreEqual(22, FList.Length(a));
        }
    }
}
