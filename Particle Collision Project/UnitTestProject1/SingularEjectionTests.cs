using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quadrivia.FunctionalLibrary;
using System.Windows.Media.Media3D;

namespace UnitTestProject1
{
    [TestClass]
    public class SingularEjectionTests
    {
        [TestMethod]
        public void HappyCase()
        {
            var a = Collisions.VectorFunctions.SingularEjection(new Particles.Proton(0), FRandom.Seed(1, 1));
            Assert.AreEqual(new Vector3D(203, 11, 132), a.Position);

            var b = Collisions.VectorFunctions.SingularEjection(new Particles.Photon(), FRandom.Seed(1, 1));
            Assert.AreEqual(new Vector3D(203, 11, 132), b.Position);

            var c = Collisions.VectorFunctions.SingularEjection(new Particles.Proton(0), FRandom.Seed(38, 192));
            Assert.AreEqual(new Vector3D(157, -11, 124), c.Position);

            var d = Collisions.VectorFunctions.SingularEjection(new Particles.Photon(), FRandom.Seed(112, 6));
            Assert.AreEqual(new Vector3D(64, -57, 7), d.Position);

        }
    }
}
