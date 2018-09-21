using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Large_Hadron_Collider_Simulation
{
    class Program
    {
        static void Main(string[] args) //Basic UI
        {
            Console.WriteLine("Welcome to the Large Hadron Collider Simulation");
            Console.WriteLine("Please choose which collision you would like to see:");
            Console.WriteLine("1.Anilliation");
            int UserAnswer = Convert.ToInt32(Console.ReadLine());
            switch (UserAnswer)
            {
                case 1:
                    var Output = Collisions.Program.Anialation(new Particle.Proton(100,false), new Particle.Antiproton(100,true));
                    foreach (var item in Output)
                    {
                        Console.WriteLine(item);
                        Console.WriteLine("The energy of the photon is " + item.Energy + " J");
                        Console.WriteLine("The velocity of the photon is " + item.Velocity + " m/s");
                        Console.WriteLine("");
                    }
                    break;
            }

            Console.ReadKey();
        }
    }
}
