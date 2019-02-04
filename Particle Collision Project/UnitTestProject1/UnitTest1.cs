using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Media.Media3D;
using Quadrivia.FunctionalLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class CollisionFunctions
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}

[TestClass]
public class VectorFunctions
{ 
    [TestMethod]
    public void SingularEjectionPhoton()
    {
       Assert.AreEqual(new Vector3D(203, 11, 132) , Collisions.VectorFunctions.SingularEjection(new Particles.Photon(),FRandom.Seed(1,1)).Position);
    }
    [TestMethod]
    public void SingularEjectionProton()
    {
        Assert.AreEqual(new Vector3D(203, 11, 132), Collisions.VectorFunctions.SingularEjection(new Particles.Proton(1), FRandom.Seed(1, 1)).Position);
    }
    [TestMethod]
    public void OppositeEjectionPhoton()
    {
        Assert.AreEqual(new Vector3D(203, 11, 132), Collisions.VectorFunctions.OppositeEjections(new Particles.Photon(), new Particles.Photon(), FRandom.Seed(1, 1)).Item1.Position);
        Assert.AreEqual(new Vector3D(-203, -11, -132), Collisions.VectorFunctions.OppositeEjections(new Particles.Photon(), new Particles.Photon(), FRandom.Seed(1, 1)).Item2.Position);
    }
    [TestMethod]
    public void OppositeEjectionProton()
    {
        Assert.AreEqual(new Vector3D(203, 11, 132), Collisions.VectorFunctions.OppositeEjections(new Particles.Proton(1), new Particles.Proton(1), FRandom.Seed(1, 1)).Item1.Position);
        Assert.AreEqual(new Vector3D(-203, -11, -132), Collisions.VectorFunctions.OppositeEjections(new Particles.Proton(1), new Particles.Proton(1), FRandom.Seed(1, 1)).Item2.Position);
    }
    [TestMethod]
    public void OppositeEjectionsElectron()
    {
        Assert.AreEqual(new Vector3D(203, 11, 132), Collisions.VectorFunctions.OppositeEjections(new Particles.Electron(1), new Particles.Electron(1), FRandom.Seed(1, 1)).Item1.Position);
        Assert.AreEqual(new Vector3D(-203, -11, -132), Collisions.VectorFunctions.OppositeEjections(new Particles.Electron(1), new Particles.Electron(1), FRandom.Seed(1, 1)).Item2.Position);
    }
    [TestMethod]
    public void DistancePhoton()
    {
        Assert.AreEqual(10, Collisions.VectorFunctions.DistanceEjected(new Particles.Photon(123, 456)).Distance);
    }
    
}

