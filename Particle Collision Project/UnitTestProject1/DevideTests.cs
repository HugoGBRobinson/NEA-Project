using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class DevideTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var a = Collisions.CollisionFuntions.Devide(10, 2);
            Assert.AreEqual(5, a);
            var b = Collisions.CollisionFuntions.Devide(5000, 5) - Collisions.CollisionFuntions.Devide(5000, 5) * 0.1;
            Assert.AreEqual(900, b);
            var c = Collisions.CollisionFuntions.Devide(5000, 5) + Collisions.CollisionFuntions.Devide(5000, 5) * 0.1;
            Assert.AreEqual(1100, c);
        }
    }
}
