using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quadrivia.FunctionalLibrary;
using System.Windows.Media.Media3D;

namespace UnitTestProject1
{
    [TestClass]
    public class OppositeEjectionsTests
    {
        [TestMethod]
        public void HappyCase()
        {
            var a = Collisions.VectorFunctions.OppositeEjections(new Particles.Proton(0), new Particles.Proton(0), FRandom.Seed(1, 1));
            Assert.AreEqual(new Vector3D(203, 11, 132), a.Item1.Position);
            Assert.AreEqual(new Vector3D(-203, -11, -132), a.Item2.Position);

            var b = Collisions.VectorFunctions.OppositeEjections(new Particles.Photon(), new Particles.Photon(), FRandom.Seed(1, 1));
            Assert.AreEqual(new Vector3D(203, 11, 132), b.Item1.Position);
            Assert.AreEqual(new Vector3D(-203, -11, -132), b.Item2.Position);

            var c = Collisions.VectorFunctions.OppositeEjections(new Particles.Proton(0), new Particles.Proton(0), FRandom.Seed(38, 192));
            Assert.AreEqual(new Vector3D(157, -11, 124), c.Item1.Position);
            Assert.AreEqual(new Vector3D(-157, 11, -124), c.Item2.Position);

            var d = Collisions.VectorFunctions.OppositeEjections(new Particles.Photon(), new Particles.Photon(), FRandom.Seed(112, 6));
            Assert.AreEqual(new Vector3D(64, -57, 7), d.Item1.Position);
            Assert.AreEqual(new Vector3D(-64, 57, -7), d.Item2.Position);

        }
    }
}
