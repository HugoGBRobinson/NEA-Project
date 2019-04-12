using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class BetaMinusDecayAtom
    {
        [TestMethod]
        public void HappyCase()
        {
            var a = Collisions.CollisionFuntions.BetaMinusDeacyAtom(Collisions.CollisionFuntions.AtomCreator(24, 52));
            Assert.AreEqual("Manganese", a.Name);
        }
        [TestMethod]
        public void Edgecase()
        {
            var a = Collisions.CollisionFuntions.BetaMinusDeacyAtom(Collisions.CollisionFuntions.AtomCreator(118, 294));
            Assert.AreEqual(null, a.Name);
        }
    }
}
