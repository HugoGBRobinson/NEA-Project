using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vectors;


namespace Particles_UI
{
    class Program
    {
        static void Main(string[] args)
        {

            IRandomNumberGenerator RNG;
            var UserInput = true;


            if (UserInput == true)
            {
                RNG = new ProgramableRandomeNumbergenerator(1);
            }else
            {
                RNG = new TrueRandomeNumbergenerator();
            }


            

        }
    }
}
