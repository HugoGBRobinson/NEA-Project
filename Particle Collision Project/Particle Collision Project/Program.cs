using System;
using Particles;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quadrivia.FunctionalLibrary;
using System.Windows.Media.Media3D;

namespace Particle_Collision_Project
{
    class UI
    {
        //Dirty
        static void Main(string[] args)
        {
            bool ContinueLoop = true;
            while (ContinueLoop)
            {
                Console.WriteLine("What collsision would you like to simulate?");

                Console.WriteLine("1: Annihilation (WIP)");
                Console.WriteLine("2: Electron capture");
                Console.WriteLine("3: Pair Production");
                Console.WriteLine("4: Cyclatron (WIP)");
                Console.WriteLine("5: Atom Intercations (WIP)");
                Console.WriteLine("6: Electrostatic Repulsion (WIP)");
                Console.WriteLine("7: Experiment with gold to find the proton simulator??");
                Console.WriteLine("10: Exit");
                int userinput = Convert.ToInt32( Console.ReadLine());
                FRandom FirstSeed = FRandom.SeedFromClock(DateTime.Now);
                switch (userinput)
                {
                    case 1:
                        Console.WriteLine("What particle will you annihilate?");
                        Console.WriteLine("1: Proton and Anti-proton");
                        Console.WriteLine("2: Electron and positron");

                        var answer = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter the modules of the velocitys of the two particles");
                        Console.WriteLine("Particle 1:");
                        var VelocityP1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Particle2:");
                        var VelocityP2 = Convert.ToDouble(Console.ReadLine());
                        Tuple<Photon,Photon> AnihilationOutput = null;
                        switch (answer)
                        {
                            case 1:
                                
                                if (VelocityP1 > 300000000 || VelocityP2 > 300000000)
                                {
                                    Console.WriteLine("That is faster than the speed of light, which is not allowed");
                                }else if(VelocityP1 < 0 || VelocityP2 < 0)
                                {
                                    Console.WriteLine("That is less than zero, modules means the positive version of the same number");
                                }
                                else
                                {
                                    AnihilationOutput = Collisions.CollisionFuntions.Annialation(new Proton(VelocityP1), new Antiproton(VelocityP2), FirstSeed);
                                    Console.WriteLine("The particle is a " + AnihilationOutput.Item1);
                                    Console.WriteLine("It's velocity is " + AnihilationOutput.Item1.Velocity);
                                    Console.WriteLine("It's energy is " + Collisions.CollisionFuntions.WavelengthToEnergy(AnihilationOutput.Item1));
                                    Console.WriteLine("And its ejection direction is " + AnihilationOutput.Item1.Position);
                                    Console.WriteLine("");

                                    Console.WriteLine("The particle is a " + AnihilationOutput.Item2);
                                    Console.WriteLine("It's velocity is " + AnihilationOutput.Item2.Velocity);
                                    Console.WriteLine("It's energy is " + Collisions.CollisionFuntions.WavelengthToEnergy(AnihilationOutput.Item2));
                                    Console.WriteLine("And its ejection direction is " + AnihilationOutput.Item2.Position);
                                    Console.WriteLine("");
                                }

                                Console.WriteLine("");
                                break;

                            case 2:
                                if (VelocityP1 > 300000000 || VelocityP2 > 300000000)
                                {
                                    Console.WriteLine("That is faster than the speed of light, which is not allowed");
                                }
                                else if (VelocityP1 < 0 || VelocityP2 < 0)
                                {
                                    Console.WriteLine("That is less than zero, modules means the positive version of the same number");
                                }
                                else
                                {
                                    AnihilationOutput = Collisions.CollisionFuntions.Annialation(new Electron(VelocityP1), new Positron(VelocityP2), FirstSeed);
                                    Console.WriteLine("The particle is a " + AnihilationOutput.Item1);
                                    Console.WriteLine("It's velocity is " + AnihilationOutput.Item1.Velocity);
                                    Console.WriteLine("It's energy is " + Collisions.CollisionFuntions.WavelengthToEnergy(AnihilationOutput.Item1));
                                    Console.WriteLine("");

                                    Console.WriteLine("The particle is a " + AnihilationOutput.Item2);
                                    Console.WriteLine("It's velocity is " + AnihilationOutput.Item2.Velocity);
                                    Console.WriteLine("It's energy is " + Collisions.CollisionFuntions.WavelengthToEnergy(AnihilationOutput.Item2));
                                }
                                
                                
                                break;

                            default:
                                break;
                        }

                        break;

                    case 2:
                        Console.WriteLine("Please entre the mass number of the atom");
                        int UserInputMassNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please entre the atomic number of the atom ");
                        int UserInputAtomicNumber = Convert.ToInt32(Console.ReadLine());
                        var ElectronCapture = Collisions.CollisionFuntions.ElectronCaputre(Collisions.CollisionFuntions.AtomCreator(UserInputAtomicNumber, UserInputMassNumber), FirstSeed);
                        Console.WriteLine("The new atom created is " + Collisions.CollisionFuntions.AtomCreator(UserInputAtomicNumber,UserInputMassNumber).Name + ", and it has an atomic number of " + ElectronCapture.Item1.AtomicNumber + " And a mass number of " + ElectronCapture.Item1.MassNumber);
                        Console.WriteLine("The other particle produced was a " + ElectronCapture.Item2);
                        Console.WriteLine("");
                        break;

                    case 3:
                        Console.WriteLine("Please enter the Wavelength of the photon");
                        var UserWavelength = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter the Frequency of the photon");
                        var UserFrequency = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine(Collisions.CollisionFuntions.PairProductionPhoton(new Photon(UserWavelength, UserFrequency), FirstSeed).Item1);
                        Console.WriteLine(Collisions.CollisionFuntions.PairProductionPhoton(new Photon(UserWavelength, UserFrequency), FirstSeed).Item1.Velocity + " m/s");
                        Console.WriteLine("And its position is " + Collisions.CollisionFuntions.PairProductionPhoton(new Photon(UserWavelength, UserFrequency), FirstSeed).Item1.Position);
                        Console.WriteLine("");
                        Console.WriteLine(Collisions.CollisionFuntions.PairProductionPhoton(new Photon(UserWavelength, UserFrequency), FirstSeed).Item2);
                        Console.WriteLine(Collisions.CollisionFuntions.PairProductionPhoton(new Photon(UserWavelength, UserFrequency), FirstSeed).Item2.Velocity + " m/s");
                        Console.WriteLine("And its position is " + Collisions.CollisionFuntions.PairProductionPhoton(new Photon(UserWavelength, UserFrequency), FirstSeed).Item2.Position);
                        Console.WriteLine("");
                        break;

                    case 4:

                        var a = Collisions.CollisionFuntions.Cyclatron(new Electron(0), 100, 1000, FirstSeed,3E-48 ,7E-47);
                        for (int i = 0; i < FList.Length(a); i++)
                        {
                            Console.WriteLine(FList.Head(a));
                            FList.Take(i, a);
                        }
                        Console.WriteLine(FList.Length(a));
                        //Console.WriteLine("This segment generates either protons or electrons of random velcoity and then outputs a single velocity");
                        //Console.WriteLine("1: Protons");
                        //Console.WriteLine("2: Electrons");
                        //var answer4 = Convert.ToInt32(Console.ReadLine());
                        //Console.WriteLine("Please enter the value of the field strength");
                        //var FieldStrength = Convert.ToDouble(Console.ReadLine());
                        //Console.WriteLine("Please enter the number of particles to be generated");
                        //int n = Convert.ToInt32(Console.ReadLine());
                        //Console.WriteLine("");
                        //for (int i = 0; i < FList.Length(Collisions.CollisionFuntions.Cyclatron(new Proton(0), 20, 100, FirstSeed)); i++)
                        //{
                        //    //Console.WriteLine(FList.Take(i, 
                        //    Console.WriteLine(Collisions.CollisionFuntions.Cyclatron(new Proton(0), 20, 100, FirstSeed));
                        //}
                        //Console.WriteLine("");
                        break;

                    case 5:
                        Console.WriteLine("This segment lets you create an atom and the pass it through interactions to see how it is effected");
                        Console.WriteLine("First to create the atom, please input the following, in order");
                        Console.WriteLine("Atomic Number: ");
                        var AtomicNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("MassNumber");
                        var MassNumber =Convert.ToInt32(Console.ReadLine());
                        var Atom = Collisions.CollisionFuntions.AtomCreator(AtomicNumber, MassNumber);
                        while (true)
                        {
                            Console.WriteLine("For Beta-Plus Decay press 1");
                            Console.WriteLine("For Beta-Minus Decay press 2");
                            Console.WriteLine("For Electron capture press 3");


                            Console.WriteLine("To exit to main menu press 10");
                            var answer6 = Convert.ToInt32(Console.ReadLine());
                            if (answer6 == 1)
                            {
                                Console.WriteLine("");
                                Console.WriteLine(Collisions.CollisionFuntions.BetaPlusDecayAtom(Atom).Name);
                                Console.WriteLine(Collisions.CollisionFuntions.BetaPlusDecayAtom(Atom).AtomicNumber);
                                Console.WriteLine(Collisions.CollisionFuntions.BetaPlusDecayAtom(Atom).MassNumber);
                                Atom = Collisions.CollisionFuntions.BetaPlusDecayAtom(Atom);
                                Console.WriteLine("");
                            }
                            else if (answer6 == 2)
                            {
                                Console.WriteLine("");
                                Console.WriteLine(Collisions.CollisionFuntions.BetaMinusDeacyAtom(Atom).Name);
                                Console.WriteLine(Collisions.CollisionFuntions.BetaMinusDeacyAtom(Atom).AtomicNumber);
                                Console.WriteLine(Collisions.CollisionFuntions.BetaMinusDeacyAtom(Atom).MassNumber);
                                Atom = Collisions.CollisionFuntions.BetaMinusDeacyAtom(Atom);
                                Console.WriteLine("");
                            }
                            else if (answer6 == 3)
                            {
                                Console.WriteLine("");
                                Console.WriteLine(Collisions.CollisionFuntions.ElectronCaputre(Atom, FirstSeed).Item1.Name);
                                Console.WriteLine(Collisions.CollisionFuntions.ElectronCaputre(Atom, FirstSeed).Item1.AtomicNumber);
                                Console.WriteLine(Collisions.CollisionFuntions.ElectronCaputre(Atom, FirstSeed).Item1.MassNumber);
                                Atom = Collisions.CollisionFuntions.ElectronCaputre(Atom, FirstSeed).Item1;
                                Console.WriteLine("");
                            }
                            else if (answer6 == 4)
                            {
                                Console.WriteLine("");
                                Console.WriteLine(Collisions.CollisionFuntions.AlphaDecay(Atom).Name);
                                Console.WriteLine(Collisions.CollisionFuntions.AlphaDecay(Atom).AtomicNumber);
                                Console.WriteLine(Collisions.CollisionFuntions.AlphaDecay(Atom).MassNumber);
                                Atom = Collisions.CollisionFuntions.AlphaDecay(Atom);
                                Console.WriteLine("");
                            }
                            else if (answer6 == 10)
                            {
                                break;
                            }
                        }
                        break;

                    case 6:
                        Console.WriteLine("");
                        Console.WriteLine(Collisions.CollisionFuntions.ElectrostaticRepulsion(new Proton(10), new Proton(10), FirstSeed, new Vector3D(-10, 0, 0), new Vector3D(10, 0, 0)).Item1.Position);
                        Console.WriteLine(Collisions.CollisionFuntions.ElectrostaticRepulsion(new Proton(10), new Proton(10), FirstSeed, new Vector3D(-10, 0, 0), new Vector3D(10, 0, 0)).Item2.Position);
                        Console.WriteLine("");
                        break;

                    case 10:
                        ContinueLoop = false;
                            break;
                }
            }
        }
    }
}
