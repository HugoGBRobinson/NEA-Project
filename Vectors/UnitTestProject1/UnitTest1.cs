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
        public void TestMethod1()
        {
            Vectors.IRandomNumberGenerator RNG;
            RNG = new Vectors.ProgramableRandomeNumbergenerator(1);

           
        }
    }
}
