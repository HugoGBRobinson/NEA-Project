using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Particl Collider Simulation");

            Console.WriteLine("1. True Random Number Generator");
            Console.WriteLine("2. Programable Random Number Generator");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            Vectors.IRandomNumberGenerator RNG;
            if (userChoice == 1)
            {
                RNG = new Vectors.TrueRandomeNumbergenerator();
            }
            else if (userChoice == 2)
            {
                RNG = new Vectors.ProgramableRandomeNumbergenerator(1);
            }
            Console.ReadKey();
        }
    }
}
