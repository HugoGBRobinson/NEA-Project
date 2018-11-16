using System;
using System.Collections.Generic;
using Particle;
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
            bool Continue = true;
            while (Continue)
            {
                Console.WriteLine("Please choose which collision you would like to see:");
                Console.WriteLine("1.Annihilation");
                Console.WriteLine("2.Electron capture");
                Console.WriteLine("20. Exit Program");
                int UserAnswer = Convert.ToInt32(Console.ReadLine());
                switch (UserAnswer)
                {
                    case 1:
                        Console.WriteLine("Input what particle you wish to collide and its velocity"); // Impliment the changes so it is no longer just a proton - antiproton colission and open it up to the rest of the particles
                        int P1 = Convert.ToInt32(Console.ReadLine());

                        int P2 = Convert.ToInt32(Console.ReadLine());

                        var FunctionOutput1 = Collisions.CollisionFunctions.Annialation(new Proton(100), new Antiproton(100, true));

                        Console.WriteLine(FunctionOutput1.Item1);
                        Console.WriteLine("The energy of the photon is " + FunctionOutput1.Item1.Energy + " J");
                        Console.WriteLine("The velocity of the photon is " + FunctionOutput1.Item1.Velocity + " m/s");
                        Console.WriteLine("");
                        Console.WriteLine(FunctionOutput1.Item2);
                        Console.WriteLine("The energy of the photon is " + FunctionOutput1.Item2.Energy + " J");
                        Console.WriteLine("The velocity of the photon is " + FunctionOutput1.Item2.Velocity + " m/s");
                        Console.WriteLine("");
                        Console.WriteLine("The basic Fynmann Diagram for this interaction is " + FunctionOutput1.Item3);
                        break;
                    case 2:
                        Console.WriteLine("Please enter the atomic number of the atom: ");
                        var atomicNumber = Console.ReadLine();
                        Console.WriteLine("Please enter the mass number of the atom: ");
                        var massNumber = Console.ReadLine();
                        var FunctionOutput2 = Collisions.CollisionFunctions.ElectronCaputre(Convert.ToInt32(atomicNumber), Convert.ToInt32(massNumber));
                        Console.WriteLine("The new atom is:");
                        Particle.Atom atomcreator = FunctionOutput2.Item1;
                        Console.WriteLine(atomcreator); //Later, check a periodic table for the actual name for the atom created
                        Console.WriteLine("With a new atomic number of " + atomcreator.AtomicNumber.Count);
                        Console.WriteLine("With a new neutron number of " + atomcreator.NeutronNumber.Count);
                        Console.WriteLine("Therefore with a mass number of " + atomcreator.MassNumber);
                        Console.WriteLine("The other particles produced are:");
                        Console.WriteLine(FunctionOutput2.Item2);
                        Console.WriteLine("");
                        Console.WriteLine("The basic Fynmann Diagram for this interaction is " + FunctionOutput2.Item3);
                        break;
                    case 20:
                        Continue = false;
                        break;


                }

                Console.ReadKey();
            }
            
        }

        






    }
}



            


        
    

