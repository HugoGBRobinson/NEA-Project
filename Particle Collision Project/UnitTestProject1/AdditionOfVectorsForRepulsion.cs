using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Media.Media3D;

namespace UnitTestProject1
{
    [TestClass]
    public class AdditionOfVectorsForRepulsion
    {
        [TestMethod]
        public void HappyCase()
        {
            var a = Collisions.VectorFunctions.AdditionOfVectorsForRepulsion(new Vector3D(1, 1, 1) , 
                new Particles.Proton(0, new Vector3D(2, 2, 2)), 
                new Particles.Proton(0, new Vector3D(2, 2, 2)));
            Assert.AreEqual(new Vector3D(5, 5, 5), a.Position);
        }
        [TestMethod]
        public void EdgeCase()
        {
            var a = Collisions.VectorFunctions.AdditionOfVectorsForRepulsion(new Vector3D(0.01, 0.45, 27),
                new Particles.Proton(0, new Vector3D(0.22, 0.001, 0.004)),
                new Particles.Proton(0, new Vector3D(0.78, 454,0.98)));
            Assert.AreEqual(Convert.ToString(new Vector3D(1.01, 454.451, 27.984)), Convert.ToString(a.Position));
        }
    }
}
