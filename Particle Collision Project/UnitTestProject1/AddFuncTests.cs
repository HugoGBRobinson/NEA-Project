using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class AddFuncTests
    {
        [TestMethod]
        public void HappyCase()
        {
            var a = Collisions.CollisionFuntions.add(1, 1);
            Assert.AreEqual(2, a);
            var b = Collisions.CollisionFuntions.add(1000, 1000);
            Assert.AreEqual(2000, b);
            var c = Collisions.CollisionFuntions.add(0.001, 0.001);
            Assert.AreEqual(0.002, c);
            var d = Collisions.CollisionFuntions.add(3461346314, 6457425614);
            Assert.AreEqual(9918771928, d);
        }

        [TestMethod]
        public void EdgeCase()
        {
            var a = Collisions.CollisionFuntions.add(10000000000000, 100000000000000);
            Assert.AreEqual(110000000000000, a);
            var b = Collisions.CollisionFuntions.add(0.00000000000001, 0.000000000000001);
            Assert.AreEqual(1.1E-14, b);
        }
    }
}
