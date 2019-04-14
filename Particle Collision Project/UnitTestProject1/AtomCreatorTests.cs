using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class AtomCreatorTests
    {
        [TestMethod]
        public void HappyCase()
        {
            var a = Collisions.CollisionFuntions.AtomCreator(26,52);
            Assert.AreEqual("Iron", a.Name);
        }
        [TestMethod]
        public void EdgeCase()
        {
            var a = Collisions.CollisionFuntions.AtomCreator(1,1);
            Assert.AreEqual("Hydrogen", a.Name);
            var b = Collisions.CollisionFuntions.AtomCreator(118,296);
            Assert.AreEqual("Oganesson", b.Name);
        }
        [TestMethod]
        public void ErrorCase()
        {
            var a = Collisions.CollisionFuntions.AtomCreator(0,0);
            Assert.AreEqual(null, a);
            var b = Collisions.CollisionFuntions.AtomCreator(119, 296);
            Assert.AreEqual(null, b);
        }
    }
}
