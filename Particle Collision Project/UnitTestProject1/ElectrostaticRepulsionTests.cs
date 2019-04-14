using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quadrivia.FunctionalLibrary;
using System.Windows.Media.Media3D;

namespace UnitTestProject1
{
    [TestClass]
    public class ElectrostaticRepulsionTests
    {
        [TestMethod]
        public void HappyCase()
        {
            var a = Collisions.CollisionFuntions.ElectrostaticRepulsion(new Particles.Proton(10), new Particles.Proton(10),
                FRandom.Seed(1, 1), new Vector3D(1, 1, 1), new Vector3D(1, -1, -1));
            Assert.AreEqual(new Vector3D(0, 2, 2), a.Item1.Position);
            Assert.AreEqual(new Vector3D(-0,-2,-2), a.Item2.Position);
            Assert.AreEqual("2.4258631722889", Convert.ToString(a.Item1.Velocity));
            Assert.AreEqual("2.4258631722889", Convert.ToString( a.Item2.Velocity));
        }
    }
}
