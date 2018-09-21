using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Interface
{
    public class Program
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
                var ParticleArray = Collision.Program.Anialation(new Vectors.Protons(1,1,1,20,20), new Vectors.Anti_Proton(1, 1, 1, 20, 20));
                foreach (var item in ParticleArray)
                {
                    Console.WriteLine(item);
                    Console.WriteLine("The energy of the particle is " + item.Energy + " J");
                    Console.WriteLine("The velocity of the particle is" + item.Velocity + " m/s");
                    Console.WriteLine("");
                }

            }
            else if (userChoice == 2)
            {
                RNG = new Vectors.ProgramableRandomeNumbergenerator(1);
            }
            Console.ReadKey();
        }
    }
}
