using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Media.Media3D;

namespace UnitTestProject1
{
    [TestClass]
    public class CreateOppositeTests
    {
        [TestMethod]
        public void HappyCase()
        {
            var a = Collisions.VectorFunctions.CreateOpposite(new Vector3D(1, 1, 1));
            Assert.AreEqual(new Vector3D(-1, -1, -1), a.Item2);
        }
        [TestMethod]
        public void Edgecase()
        {
            var a = Collisions.VectorFunctions.CreateOpposite(new Vector3D(0, 0, 0));
            Assert.AreEqual(new Vector3D(0, 0, 0), a.Item2);
        }
    }
}
