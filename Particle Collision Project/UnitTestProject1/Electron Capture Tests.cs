using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quadrivia.FunctionalLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class Electron_Capture_Tests
    {
        [TestMethod]
        public void HappyCase()
        {
            var Outputs1 = Collisions.CollisionFuntions.ElectronCaputre(Collisions.CollisionFuntions.AtomCreator(8, 16), FRandom.Seed(1, 1));
            Assert.AreEqual("Nitrogen", Outputs1.Item1.Name);
            Assert.AreEqual(7, Outputs1.Item1.AtomicNumber);
            Assert.AreEqual(16, Outputs1.Item1.MassNumber);
            Assert.AreEqual("Electron-Neutrino", Outputs1.Item2.Name);
            var Outputs2 = Collisions.CollisionFuntions.ElectronCaputre(Collisions.CollisionFuntions.AtomCreator(95,240), FRandom.Seed(1, 1));
            Assert.AreEqual("Plutonium", Outputs2.Item1.Name);
            Assert.AreEqual(94, Outputs2.Item1.AtomicNumber);
            Assert.AreEqual(240, Outputs2.Item1.MassNumber);
            Assert.AreEqual("Electron-Neutrino", Outputs1.Item2.Name);
            var Outputs3 = Collisions.CollisionFuntions.ElectronCaputre(Collisions.CollisionFuntions.AtomCreator(36,84), FRandom.Seed(1, 1));
            Assert.AreEqual("Bromine", Outputs3.Item1.Name);
            Assert.AreEqual(35, Outputs3.Item1.AtomicNumber);
            Assert.AreEqual(84, Outputs3.Item1.MassNumber);
            Assert.AreEqual("Electron-Neutrino", Outputs1.Item2.Name);
        }
        [TestMethod]
        public void Edgecase_WIP() 
        {
            var Outputs = Collisions.CollisionFuntions.ElectronCaputre(Collisions.CollisionFuntions.AtomCreator(1, 1), FRandom.Seed(1, 1));
            Assert.AreEqual(1, Outputs.Item1.MassNumber);
            Assert.AreEqual(0, Outputs.Item1.AtomicNumber);
            var Outputs2 = Collisions.CollisionFuntions.ElectronCaputre(Collisions.CollisionFuntions.AtomCreator(118, 293), FRandom.Seed(1, 1));
            Assert.AreEqual("Tennessine", Outputs2.Item1.Name);
            Assert.AreEqual(117, Outputs2.Item1.AtomicNumber);
            Assert.AreEqual(293, Outputs2.Item1.MassNumber);
        }
    }
}
