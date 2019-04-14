using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Media.Media3D;

namespace UnitTestProject1
{
    [TestClass]
    public class AcellerationOfParticlesFromelectrostaticForcesTests
    {
        [TestMethod]
        public void HappyCase()
        {
            var a = Collisions.VectorFunctions.AcelerationOfParticlesFromElectrostaticForce(new Particles.Proton(0), 
                new Particles.Proton(0), new Vector3D(1, 1, 1), new Vector3D(-1, -1, -1));
            Assert.AreEqual(Convert.ToString(1.61724211485927), Convert.ToString(a));
        }
    }
}
