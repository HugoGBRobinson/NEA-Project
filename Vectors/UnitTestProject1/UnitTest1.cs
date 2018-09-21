using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vectors;
using System.Windows.Media.Media3D;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ProgramableRandomNumberGeneratortest()
        {
            Vectors.IRandomNumberGenerator RNG;
            RNG = new Vectors.ProgramableRandomeNumbergenerator(1);

            Vector3D EjectionAndPosition = new Protons(10, 5, 19, 1,1).Position + Vectors.Program.Ejection(RNG);

            var x = Math.Truncate(EjectionAndPosition.X);
            var y = Math.Truncate(EjectionAndPosition.Y);
            var z = Math.Truncate(EjectionAndPosition.Z);

            Assert.AreEqual(10,x);
            Assert.AreEqual(4,y);
            Assert.AreEqual(19,z);
        }
    }
}
