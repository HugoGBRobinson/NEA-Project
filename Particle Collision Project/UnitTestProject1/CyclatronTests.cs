using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quadrivia.FunctionalLibrary;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class CyclatronTests
    {
        [TestMethod]
        public void HappyCase()
        {
            var a = Collisions.CollisionFuntions.Cyclatron(new Particles.Proton(1), 0.001, 0.001, 2000);
            Assert.IsTrue(a.Velocity >= 2000);

            var b = Collisions.CollisionFuntions.Cyclatron(new Particles.Proton(1), 0.01, 0.01, 2000);
            Assert.IsTrue(b.Velocity >= 2000);

            var c = Collisions.CollisionFuntions.Cyclatron(new Particles.Proton(1), 0.1, 0.1, 2000);
            Assert.IsTrue(c.Velocity >= 2000);

            var d = Collisions.CollisionFuntions.Cyclatron(new Particles.Proton(1), 1, 1, 2000);
            Assert.IsTrue(d.Velocity >= 2000);

            var e = Collisions.CollisionFuntions.Cyclatron(new Particles.Proton(1), 10, 10, 2000);
            Assert.IsTrue(e.Velocity >= 2000);

            var f = Collisions.CollisionFuntions.Cyclatron(new Particles.Proton(1), 100, 100, 2000);
            Assert.IsTrue(f.Velocity >= 2000);
        }

        [TestMethod]
        public void EdgeCase()
        {
            var a = Collisions.CollisionFuntions.Cyclatron(new Particles.Proton(1), 0.0001, 0.0001, 1000); //Has to be 1000 or under due to stack overflow 
            Assert.IsTrue(a.Velocity >= 1000);
            var b = Collisions.CollisionFuntions.Cyclatron(new Particles.Proton(1), 1000, 1000, 2000);
            Assert.IsTrue(b.Velocity >= 2000);
        }
    }
    
}
