using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quadrivia.FunctionalLibrary;
namespace UnitTestProject1
{
    [TestClass]
    public class TotalRestMassTests
    {
        [TestMethod]
        public void HappyCase()
        {
            var Outputs = Collisions.CollisionFuntions.TotalRestmass(FList.New<double>(13, 43, 665, 345, 7657));
            Assert.AreEqual(8723, Outputs);
        }
        [TestMethod]
        public void EdgeCase()
        {
            var Outputs1 = Collisions.CollisionFuntions.TotalRestmass(FList.New<double>(1000000,100000,10000,1000000));
            Assert.AreEqual(2110000, Outputs1);
            var Outputs2 = Collisions.CollisionFuntions.TotalRestmass(FList.New<double>(1E-50,1E-50));
            Assert.AreEqual(2E-50, Outputs2);
        }
    }
}
