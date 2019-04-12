using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class EnergyToFrequency
    {
        [TestMethod]
        public void HappyCase()
        {
            var Outputs = Collisions.CollisionFuntions.EnergyToFrequency(1000);
            Assert.AreEqual("1.50829562594268E+36", Convert.ToString(Outputs));
        }
        [TestMethod]
        public void EdgeCase()
        {
            var Outputs = Collisions.CollisionFuntions.EnergyToFrequency(1000000000000);
            Assert.AreEqual("1.50829562594268E+45", Convert.ToString(Outputs));
        }
    }
}
