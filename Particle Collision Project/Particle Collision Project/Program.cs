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
            // Need to talk about error hadling, wether it should be in UI or in a seperate thing to seperate it from UI
                //Answer - User erros should be in the console UI 

            bool ContinueLoop = true;
            while (ContinueLoop)
            {
                Console.WriteLine("What collsision would you like to simulate?");

                Console.WriteLine("1: Annihilation (WIP)");
                Console.WriteLine("2: Electron capture");
                Console.WriteLine("3: Pair Production");
                Console.WriteLine("4: Velocity Selector");
                Console.WriteLine("5: Atom Intercations (WIP)");
                Console.WriteLine("6: Electrostatic Repulsion");
                Console.WriteLine("7: Cyclatron");
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
                        Console.Clear();
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

                                    Console.WriteLine(Collisions.CollisionFuntions.FeynmanDiagram(FList.New(new Proton(0).FeynmanSymbol, new Proton(0).FeynmanSymbol), FList.New(new Photon().FeynmanSymbol, new Photon().FeynmanSymbol)));
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
                                    Console.WriteLine("");
                                    Console.WriteLine(Collisions.CollisionFuntions.FeynmanDiagram(FList.New(new Electron(0).FeynmanSymbol, new Electron(0).FeynmanSymbol), FList.New(new Photon().FeynmanSymbol, new Photon().FeynmanSymbol)));
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
                        Console.Clear();
                        var ElectronCapture = Collisions.CollisionFuntions.ElectronCaputre(Collisions.CollisionFuntions.AtomCreator(UserInputAtomicNumber, UserInputMassNumber), FirstSeed);
                        Console.WriteLine("The new atom created is " + ElectronCapture.Item1.Name + ", and it has an atomic number of " + ElectronCapture.Item1.AtomicNumber + " And a mass number of " + ElectronCapture.Item1.MassNumber);
                        Console.WriteLine("The other particle produced was a " + ElectronCapture.Item2);
                        Console.WriteLine("");
                        break;

                    case 3:
                        Console.WriteLine("Please enter the Wavelength of the photon");
                        var UserWavelength = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter the Frequency of the photon");
                        var UserFrequency = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine(Collisions.CollisionFuntions.PairProductionPhoton(new Photon(UserWavelength, UserFrequency), FirstSeed).Item1);
                        Console.WriteLine(Collisions.CollisionFuntions.PairProductionPhoton(new Photon(UserWavelength, UserFrequency), FirstSeed).Item1.Velocity + " m/s");
                        Console.WriteLine("And its position is " + Collisions.CollisionFuntions.PairProductionPhoton(new Photon(UserWavelength, UserFrequency), FirstSeed).Item1.Position);
                        Console.WriteLine("");
                        Console.WriteLine(Collisions.CollisionFuntions.PairProductionPhoton(new Photon(UserWavelength, UserFrequency), FirstSeed).Item2);
                        Console.WriteLine(Collisions.CollisionFuntions.PairProductionPhoton(new Photon(UserWavelength, UserFrequency), FirstSeed).Item2.Velocity + " m/s");
                        Console.WriteLine("And its position is " + Collisions.CollisionFuntions.PairProductionPhoton(new Photon(UserWavelength, UserFrequency), FirstSeed).Item2.Position);
                        Console.WriteLine("");
                        Console.WriteLine(Collisions.CollisionFuntions.FeynmanDiagram(FList.New(new Photon().FeynmanSymbol, new Photon().FeynmanSymbol), FList.New(Collisions.CollisionFuntions.PairProductionPhoton(new Photon(UserWavelength, UserFrequency), FirstSeed).Item1.FeynmanSymbol, Collisions.CollisionFuntions.PairProductionPhoton(new Photon(UserWavelength, UserFrequency), FirstSeed).Item2.FeynmanSymbol)));
                        break;

                    case 4:
                        Console.WriteLine("What particle is bieng selected?  ");
                        Console.WriteLine("1: Protons");
                        Console.WriteLine("2: Electrons");
                        var answer4 = Console.ReadLine();
                        Console.WriteLine("How many particles are passing through the Velocity Selector? (Up to 1000)  ");
                        var NumberOfparticles = Console.ReadLine();
                        Console.WriteLine("Set the strength of the Electric Field E  ");
                        var E = Console.ReadLine();
                        Console.WriteLine("Set the strength of the Magnetic Field B  ");
                        var B = Console.ReadLine();
                        if (Convert.ToInt32(answer4) == 1)
                        {
                            var a = Collisions.CollisionFuntions.VelocitySelector(new Proton(0), Convert.ToInt32(NumberOfparticles), Convert.ToInt32(E), Convert.ToInt32(B), FirstSeed);
                            if (FList.Length(a) == 0)
                            {
                                Console.WriteLine("No particles were generated with this velocity");
                            }
                            else
                            {
                                Console.WriteLine("The number of particles output is " + FList.Length(a));
                            }
                        }
                        else
                        {
                            var a = Collisions.CollisionFuntions.VelocitySelector(new Electron(0), Convert.ToInt32(NumberOfparticles), Convert.ToInt32(E), Convert.ToInt32(B), FirstSeed);
                            if (FList.Length(a)  == 0)
                            {
                                Console.WriteLine("No particles were generated with this velocity");
                            }
                            else
                            {
                                Console.WriteLine("The number of particles output is " + FList.Length(a));
                            }
                        }
                        
                        
                       
                        break;

                    case 5:
                        Console.WriteLine("This segment lets you create an atom and the pass it through interactions to see how it is effected");
                        Console.WriteLine("First to create the atom, please input the following, in order");
                        Console.WriteLine("Atomic Number: ");
                        var AtomicNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("MassNumber");
                        var MassNumber =Convert.ToInt32(Console.ReadLine());
                        var Atom = Collisions.CollisionFuntions.AtomCreator(AtomicNumber, MassNumber);
                        Console.Clear();
                        while (true)
                        {
                            Console.WriteLine("For Beta-Plus Decay press 1");
                            Console.WriteLine("For Beta-Minus Decay press 2");
                            Console.WriteLine("For Electron capture press 3");
                            Console.WriteLine("For Alpha Decay press 4");


                            Console.WriteLine("To exit to main menu press 10");
                            var answer5 = Convert.ToInt32(Console.ReadLine());
                            if (answer5 == 1)
                            {
                                Console.WriteLine("");
                                Console.WriteLine(Collisions.CollisionFuntions.BetaPlusDecayAtom(Atom).Name);
                                Console.WriteLine(Collisions.CollisionFuntions.BetaPlusDecayAtom(Atom).AtomicNumber);
                                Console.WriteLine(Collisions.CollisionFuntions.BetaPlusDecayAtom(Atom).MassNumber);
                                Atom = Collisions.CollisionFuntions.BetaPlusDecayAtom(Atom);
                                Console.WriteLine(Collisions.CollisionFuntions.FeynmanDiagram(FList.New(Atom.Name), FList.New(Collisions.CollisionFuntions.BetaPlusDecayAtom(Atom).Name, new Particles.Positron(0).FeynmanSymbol)));
                                Console.WriteLine("");
                            }
                            else if (answer5 == 2)
                            {
                                Console.WriteLine("");
                                Console.WriteLine(Collisions.CollisionFuntions.BetaMinusDeacyAtom(Atom).Name);
                                Console.WriteLine(Collisions.CollisionFuntions.BetaMinusDeacyAtom(Atom).AtomicNumber);
                                Console.WriteLine(Collisions.CollisionFuntions.BetaMinusDeacyAtom(Atom).MassNumber);
                                Atom = Collisions.CollisionFuntions.BetaMinusDeacyAtom(Atom);
                                Console.WriteLine(Collisions.CollisionFuntions.FeynmanDiagram(FList.New(Atom.Name), FList.New(Collisions.CollisionFuntions.BetaMinusDeacyAtom(Atom).Name, new Particles.Electron(0).FeynmanSymbol)));
                                Console.WriteLine("");
                            }
                            else if (answer5 == 3)
                            {
                                Console.WriteLine("");
                                Console.WriteLine(Collisions.CollisionFuntions.ElectronCaputre(Atom, FirstSeed).Item1.Name);
                                Console.WriteLine(Collisions.CollisionFuntions.ElectronCaputre(Atom, FirstSeed).Item1.AtomicNumber);
                                Console.WriteLine(Collisions.CollisionFuntions.ElectronCaputre(Atom, FirstSeed).Item1.MassNumber);
                                Atom = Collisions.CollisionFuntions.ElectronCaputre(Atom, FirstSeed).Item1;
                                Console.WriteLine(Collisions.CollisionFuntions.FeynmanDiagram(FList.New(Atom.Name), FList.New(Collisions.CollisionFuntions.ElectronCaputre(Atom, FirstSeed).Item1.Name, new Particles.ElectronNeutrino(0).FeynmanSymbol)));
                                Console.WriteLine("");
                            }
                            else if (answer5 == 4)
                            {
                                Console.WriteLine("");
                                Console.WriteLine(Collisions.CollisionFuntions.AlphaDecay(Atom).Name);
                                Console.WriteLine(Collisions.CollisionFuntions.AlphaDecay(Atom).AtomicNumber);
                                Console.WriteLine(Collisions.CollisionFuntions.AlphaDecay(Atom).MassNumber);
                                Atom = Collisions.CollisionFuntions.AlphaDecay(Atom);
                                Console.WriteLine(Collisions.CollisionFuntions.FeynmanDiagram(FList.New(Atom.Name), FList.New(Collisions.CollisionFuntions.AlphaDecay(Atom).Name, Collisions.CollisionFuntions.AtomCreator(2,4).Name + " Nucleus")));
                                Console.WriteLine("");
                            }
                            else if (answer5 == 10)
                            {
                                break;
                            }
                        }
                        break;

                    case 6:

                        Console.WriteLine("Which two Particles are bieng simulated?");
                        Console.WriteLine("1: Two Protons");
                        Console.WriteLine("2: Two Electrons");
                        var answer6 = Convert.ToInt32(Console.ReadLine());
                        if (answer6 == 1)
                        {
                            Console.WriteLine("Please enter the velocity for the first particles");
                            var VP1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Now enter the x, y and z coordinates for the first particle");
                            var X1 = Convert.ToInt32(Console.ReadLine());
                            var Y1 = Convert.ToInt32(Console.ReadLine());
                            var Z1 = Convert.ToInt32(Console.ReadLine());
                            var StartPosition1 = new Vector3D(X1, Y1, Z1);
                            Console.WriteLine("Please enter the velocity for the second particles");
                            var VP2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Now enter the x, y and z coordinates for the second particle");
                            var X2 = Convert.ToInt32(Console.ReadLine());
                            var Y2 = Convert.ToInt32(Console.ReadLine());
                            var Z2 = Convert.ToInt32(Console.ReadLine());
                            var StartPosition2 = new Vector3D(X2, Y2, Z2);
                            Console.Clear();
                            Console.WriteLine("The first particle is ejected at (" + Collisions.CollisionFuntions.ElectrostaticRepulsion(new Proton(VP1), new Proton(VP2), FirstSeed, StartPosition1, StartPosition2).Item1.Position.X + "," + Collisions.CollisionFuntions.ElectrostaticRepulsion(new Proton(VP1), new Proton(VP2), FirstSeed, StartPosition1, StartPosition2).Item1.Position.Y + "," + Collisions.CollisionFuntions.ElectrostaticRepulsion(new Proton(VP1), new Proton(VP2), FirstSeed, StartPosition1, StartPosition2).Item1.Position.Z + ")");
                            Console.WriteLine("With a velocity of " + Collisions.CollisionFuntions.ElectrostaticRepulsion(new Proton(VP1), new Proton(VP2), FirstSeed, StartPosition1, StartPosition2).Item1.Velocity);
                            Console.WriteLine("");
                            Console.WriteLine("The second particle is ejected at (" + Collisions.CollisionFuntions.ElectrostaticRepulsion(new Proton(VP1), new Proton(VP2), FirstSeed, StartPosition1, StartPosition2).Item2.Position.X + "," + Collisions.CollisionFuntions.ElectrostaticRepulsion(new Proton(VP1), new Proton(VP2), FirstSeed, StartPosition1, StartPosition2).Item2.Position.Y + "," + Collisions.CollisionFuntions.ElectrostaticRepulsion(new Proton(VP1), new Proton(VP2), FirstSeed, StartPosition1, StartPosition2).Item2.Position.Z + ")");
                            Console.WriteLine("With a velocity of " + Collisions.CollisionFuntions.ElectrostaticRepulsion(new Proton(VP1), new Proton(VP2), FirstSeed, StartPosition1, StartPosition2).Item2.Velocity);
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("Please enter the velocity for the first particles");
                            var VP1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Now enter the x, y and z coordinates for the first particle");
                            var X1 = Convert.ToInt32(Console.ReadLine());
                            var Y1 = Convert.ToInt32(Console.ReadLine());
                            var Z1 = Convert.ToInt32(Console.ReadLine());
                            var StartPosition1 = new Vector3D(X1, Y1, Z1);
                            Console.WriteLine("Please enter the velocity for the second particles");
                            var VP2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Now enter the x, y and z coordinates for the second particle");
                            var X2 = Convert.ToInt32(Console.ReadLine());
                            var Y2 = Convert.ToInt32(Console.ReadLine());
                            var Z2 = Convert.ToInt32(Console.ReadLine());
                            var StartPosition2 = new Vector3D(X2, Y2, Z2);
                            Console.Clear();
                            Console.WriteLine("The first particle is ejected at (" + Collisions.CollisionFuntions.ElectrostaticRepulsion(new Electron(VP1), new Electron(VP2), FirstSeed, StartPosition1, StartPosition2).Item1.Position.X + "," + Collisions.CollisionFuntions.ElectrostaticRepulsion(new Electron(VP1), new Electron(VP2), FirstSeed, StartPosition1, StartPosition2).Item1.Position.Y + "," + Collisions.CollisionFuntions.ElectrostaticRepulsion(new Electron(VP1), new Electron(VP2), FirstSeed, StartPosition1, StartPosition2).Item1.Position.Z + ")");
                            Console.WriteLine("With a velocity of " + Collisions.CollisionFuntions.ElectrostaticRepulsion(new Electron(VP1), new Electron(VP2), FirstSeed, StartPosition1, StartPosition2).Item1.Velocity);
                            Console.WriteLine("");
                            Console.WriteLine("The second particle is ejected at (" + Collisions.CollisionFuntions.ElectrostaticRepulsion(new Electron(VP1), new Electron(VP2), FirstSeed, StartPosition1, StartPosition2).Item2.Position.X + "," + Collisions.CollisionFuntions.ElectrostaticRepulsion(new Electron(VP1), new Electron(VP2), FirstSeed, StartPosition1, StartPosition2).Item2.Position.Y + "," + Collisions.CollisionFuntions.ElectrostaticRepulsion(new Electron(VP1), new Electron(VP2), FirstSeed, StartPosition1, StartPosition2).Item2.Position.Z + ")");
                            Console.WriteLine("With a velocity of " + Collisions.CollisionFuntions.ElectrostaticRepulsion(new Electron(VP1), new Electron(VP2), FirstSeed, StartPosition1, StartPosition2).Item2.Velocity);
                            Console.WriteLine("");
                        }
                       
                        break;

                    case 7:
                        
                        Console.WriteLine("Please choose what particles are bieng accelerated");
                        Console.WriteLine("1: Protons");
                        Console.WriteLine("2: Electrons");
                        Console.WriteLine("3: Positrons");
                        Console.WriteLine("4: AntiProtons");
                        var answer7 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the electric field strength of the cyclatron");
                        var ElectricFielsStrength = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Enter the magnetic field strength of the cyclatron");
                        var MagneticFieldStrength = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("What is the target velocity?");
                        var TargetV = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        if (answer7 == 1)
                        {
                            
                            Console.WriteLine("The true speed ejected is " + Collisions.CollisionFuntions.Cyclatron(new Proton(1), ElectricFielsStrength, MagneticFieldStrength, TargetV).Velocity + " m/s");
                            Console.WriteLine("The distance it travled from the centre is " + Collisions.CollisionFuntions.Cyclatron(new Proton(1), ElectricFielsStrength, MagneticFieldStrength, TargetV).Position.Y + " m");
                        }
                        else if (answer7 == 2)
                        {
                            Console.WriteLine("The true speed ejected is " + Collisions.CollisionFuntions.Cyclatron(new Electron(1), ElectricFielsStrength, MagneticFieldStrength, TargetV).Velocity + " m/s");
                            Console.WriteLine("The distance it travled from the centre is " + Collisions.CollisionFuntions.Cyclatron(new Electron(1), ElectricFielsStrength, MagneticFieldStrength, TargetV).Position.Y + "m");
                        }
                        else if (answer7 == 3)
                        {
                            Console.WriteLine("The true speed ejected is " + Collisions.CollisionFuntions.Cyclatron(new Positron(1), ElectricFielsStrength, MagneticFieldStrength, TargetV).Velocity + " m/s");
                            Console.WriteLine("The distance it travled from the centre is " + Collisions.CollisionFuntions.Cyclatron(new Positron(1), ElectricFielsStrength, MagneticFieldStrength, TargetV).Position.Y + "m");
                        }
                        else if (answer7 == 4)
                        {
                            Console.WriteLine("The true speed ejected is " + Collisions.CollisionFuntions.Cyclatron(new Electron(1), ElectricFielsStrength, MagneticFieldStrength, TargetV).Velocity + " m/s");
                            Console.WriteLine("The distance it travled from the centre is " + Collisions.CollisionFuntions.Cyclatron(new Electron(1), ElectricFielsStrength, MagneticFieldStrength, TargetV).Position.Y + "m");
                        }
                        else
                        {
                            Console.WriteLine("Not a valid option, please choose again");   
                        }
                        

                        

                        break;
                    case 10:
                        ContinueLoop = false;
                            break;
                }
            }
        }
    }
}
