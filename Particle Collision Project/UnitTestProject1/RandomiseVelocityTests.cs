using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quadrivia.FunctionalLibrary;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class RandomiseVelocityTests
    {
        [TestMethod]
        public void HappyCase()
        {
            //Testing to make sure deterministic randomness
            var a = Collisions.CollisionFuntions.RandomiseVelocity(FRandom.Seed(1, 1));
            Assert.AreEqual(2822, a.Number);
            var b = Collisions.CollisionFuntions.RandomiseVelocity(FRandom.Seed(1, 1));
            Assert.AreEqual(2822, b.Number);
        }
        [TestMethod]
        public void EdgeCase()
        {
            //Checkes to make sure the randomiser only produces numbers within the boundries. 
            for (int i = 0; i < 100; i++)
            {
                if (Collisions.CollisionFuntions.RandomiseVelocity(FRandom.Seed(1, 1)).Number > 2.9E8 
                    || Collisions.CollisionFuntions.RandomiseVelocity(FRandom.Seed(1, 1)).Number < 1E3)
                {
                    Assert.Fail();
                }

            }
            Assert.IsTrue(1 == 1);

        }
    }
}
