using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vectors 
{
    public interface IRandomNumberGenerator
    {
        int Next(int Min, int Max);
    }

    public class TrueRandomeNumbergenerator : IRandomNumberGenerator
    {
        public Random TrueRNG { get; set; }

        public TrueRandomeNumbergenerator()
        {
            TrueRNG = new Random();
        }

        public int Next(int Min, int Max)
        {
            throw new NotImplementedException();
        }

        public static int[] RandomNumberArrayOutput()
        {
            Random random = new Random();
            var RandomNumberArray = new int[2] { random.Next(0, 360), random.Next(0, 360) };
            return RandomNumberArray;

        }
    }

    public class ProgramableRandomeNumbergenerator : IRandomNumberGenerator
    {
        public Random ProgramableRNG { get; set; }

        public ProgramableRandomeNumbergenerator(int seedNumber)
        {
            ProgramableRNG = new Random(seedNumber);
        }

        public int Next(int Min, int Max)
        {
            return ProgramableRNG.Next(Min, Max);
        }
        public  int[] RandomNumberArrayOutput()
        {
            var RandomNumberArray = new int[2] {  ProgramableRNG.Next(0, 360), ProgramableRNG.Next(0,360) };
            return RandomNumberArray;
        }

    }
}
