using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class BetaPlusDecayAtom
    {
        [TestMethod]
        public void HappyCase()
        {
            var a = Collisions.CollisionFuntions.BetaPlusDecayAtom(Collisions.CollisionFuntions.AtomCreator(24, 52));
            Assert.AreEqual("Vanadium", a.Name);
        }
        [TestMethod]
        public void Edgecase()
        {
            var a =  Collisions.CollisionFuntions.BetaPlusDecayAtom(Collisions.CollisionFuntions.AtomCreator(1, 1));
            Assert.AreEqual(null, a.Name);
        }
    }
}
