using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quadrivia.FunctionalLibrary;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class CyclatronTests
    {
        [TestMethod]
        public void Electron1000()
        {
            var Outputs = Collisions.CollisionFuntions.Cyclatron(new Particles.Electron(0), 100, 1000, FRandom.Seed(1,1), 3E-48, 7E-47);
            Assert.AreEqual(810, FList.Length(Outputs));

        }
        [TestMethod]
        public void Proton1000()
        {
            var Outputs = Collisions.CollisionFuntions.Cyclatron(new Particles.Proton(0), 100, 1000, FRandom.Seed(1, 1), 3E-48, 7E-47);
            Assert.AreEqual(1, FList.Length(Outputs));

        }
        [TestMethod]
        public void GenerateListOFParticlesElectronTestListOf3()
        {
            var OutPuts = Collisions.CollisionFuntions.GenerateListOfParticlesWithRandomVelocity(new Particles.Electron(0), 3, FRandom.Seed(1, 1));
            Assert.AreEqual(3, FList.Length(OutPuts));
        }
        [TestMethod]
        public void GenerateListOFParticlesElectronTestListOf10()
        {
            var OutPuts = Collisions.CollisionFuntions.GenerateListOfParticlesWithRandomVelocity(new Particles.Electron(0), 10, FRandom.Seed(1, 1));
            Assert.AreEqual(10, FList.Length(OutPuts));
        }
        [TestMethod]
        public void GenerateListOFParticlesElectronTestListOf100()
        {
            var OutPuts = Collisions.CollisionFuntions.GenerateListOfParticlesWithRandomVelocity(new Particles.Electron(0), 100, FRandom.Seed(1, 1));
            Assert.AreEqual(100, FList.Length(OutPuts));
        }
        [TestMethod]
        public void GenerateListOFParticlesProtonTestListOf3()
        {
            var OutPuts = Collisions.CollisionFuntions.GenerateListOfParticlesWithRandomVelocity(new Particles.Electron(0), 3, FRandom.Seed(1, 1));
            Assert.AreEqual(3, FList.Length(OutPuts));
        }
        [TestMethod]
        public void GenerateListOFParticlesProtonTestListOf10()
        {
            var OutPuts = Collisions.CollisionFuntions.GenerateListOfParticlesWithRandomVelocity(new Particles.Electron(0), 10, FRandom.Seed(1, 1));
            Assert.AreEqual(10, FList.Length(OutPuts));
        }
        [TestMethod]
        public void GenerateListOFParticlesProtonTestListOf100()
        {
            var OutPuts = Collisions.CollisionFuntions.GenerateListOfParticlesWithRandomVelocity(new Particles.Electron(0), 100, FRandom.Seed(1, 1));
            Assert.AreEqual(100, FList.Length(OutPuts));
        }
        [TestMethod]
        public void FindRangeOfVelocitiesFromGapWidth()
        {
            var Outputs = Collisions.CollisionFuntions.FindRangeForVelocitiesFromGapWidth(1E-10, 2E-10, new Particles.Electron(0), 10);
            Assert.AreEqual(-176, Outputs.Item1);
            Assert.AreEqual(-351, Outputs.Item2);
        }
        [TestMethod]
        public void TestCalculateVFromR()
        {
            var Outputs = Collisions.CollisionFuntions.CalculateVFromR(3E-35, new Particles.Electron(0), 10);
            Assert.AreEqual(2, Outputs);
        }
    }
}
