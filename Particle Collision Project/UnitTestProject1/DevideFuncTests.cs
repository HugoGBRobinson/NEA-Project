using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class DevideFuncTests
    {
        [TestMethod]
        public void HappyCase()
        {
            var a = Collisions.CollisionFuntions.Devide(10, 5);
            Assert.AreEqual(2, a);
            var b = Collisions.CollisionFuntions.Devide(1000, 20);
            Assert.AreEqual(50, b);
            var c = Collisions.CollisionFuntions.Devide(0.001, 10);
            Assert.AreEqual(0.0001, c);
            var d = Collisions.CollisionFuntions.Devide(3461346314, 6457425614);
            Assert.AreEqual(1, Math.Round(d));
        }

        [TestMethod]
        public void EdgeCase()
        {
            var a = Collisions.CollisionFuntions.Devide(10000000000000, 10000000000000000000);
            Assert.AreEqual(1E-06, a);
            var b = Collisions.CollisionFuntions.Devide(0.00000000000001, 0.00000000000000000001);
            Assert.AreEqual(1000000, b);
        }
    }
}
