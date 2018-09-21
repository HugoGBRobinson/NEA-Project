using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CollisionTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AnnialationHappyCaseLowSpeed()
        {
            var PhotonList = Collisions.Program.Anialation(new Particle.Proton(100, false), new Particle.Antiproton(100, true));
           // Assert.AreEqual(PhotonList[0].Energy,);
        }
    }
}
