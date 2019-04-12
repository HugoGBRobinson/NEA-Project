using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class AlphaDecayTests
    {
        [TestMethod]
        public void HappyCase()
        {
            var a = Collisions.CollisionFuntions.AlphaDecay(Collisions.CollisionFuntions.AtomCreator(24, 52));
            Assert.AreEqual("Titanium", a.Name);
        }
        [TestMethod]
        public void EdgeCase()
        {
            var a = Collisions.CollisionFuntions.AlphaDecay(Collisions.CollisionFuntions.AtomCreator(2, 4));
            Assert.AreEqual(null, a.Name);
        }
    }
}
