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

                Console.WriteLine("1: Annihilation");
                Console.WriteLine("2: Electron capture");
                Console.WriteLine("3: Pair Production");
                Console.WriteLine("4: Velocity Selector");
                Console.WriteLine("5: Atom Intercations");
                Console.WriteLine("6: Electrostatic Repulsion");
                Console.WriteLine("7: Cyclatron");
                Console.WriteLine("10: Exit");
                int userinput = 0;
                try
                {

                     userinput = Convert.ToInt32(Console.ReadLine());
                    if (userinput > 7 || userinput < 1)
                    {
                        if (userinput != 10)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Number not offered as an option, please enter a number shown");
                            Console.WriteLine("");
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Invalid input, please try again");
                    Console.WriteLine("");
                }

                
                FRandom FirstSeed = FRandom.SeedFromClock(DateTime.Now);
                switch (userinput)
                {
                    case 1:
                        Console.WriteLine("What particle will you annihilate?");
                        Console.WriteLine("1: Proton and Anti-proton");
                        Console.WriteLine("2: Electron and positron");
                        var answer = 0;
                        try
                        {

                            answer = Convert.ToInt32(Console.ReadLine());
                            if (userinput != 1 && userinput != 2)
                            {
                                
                                    Console.WriteLine("");
                                    Console.WriteLine("Number not offered as an option, please enter a number shown");
                                    Console.WriteLine("");
                                break;
                               
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Invalid input, please try again");
                            Console.WriteLine("");
                            break;
                        }
                        bool BothParticlesEntered = false;
                        double VelocityP1 = -1;
                        double VelocityP2 = -1;
                        Console.WriteLine("Please enter the modules of the velocitys of the two particles");
                        
                            var Entered1 = false;
                            while (Entered1 == false)
                            {
                                Console.WriteLine("Particle 1:");

                                try
                                {
                                    VelocityP1 = Convert.ToDouble(Console.ReadLine());
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Invalid input");
                                    Console.WriteLine("");
                                    Entered1 = false;

                                }
                                if (VelocityP1 == -1)
                                {

                                }
                                else
                                {
                                    Entered1 = true;
                                }
                            }


                            var Entered2 = false;
                            while (Entered2 == false)
                            {
                                Console.WriteLine("Particle2:");
                                try
                                {
                                    VelocityP2 = Convert.ToDouble(Console.ReadLine());
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Invalid input");
                                    Console.WriteLine("");
                                    Entered2 = false;
                                }
                                if (VelocityP2 == -1)
                                {

                                }
                                else
                                {
                                    Entered2 = true;
                                }
                            }
                                        
                            
                        
                       
                         
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
                        int UserInputMassNumber = 0;
                        var MassNumberInput = false;
                        while (MassNumberInput == false)
                        {
                            Console.WriteLine("Please entre the mass number of the atom");
                             UserInputMassNumber = Convert.ToInt32(Console.ReadLine());
                            if (UserInputMassNumber < 1 || UserInputMassNumber > 295)
                            {
                                Console.WriteLine("Not a valid mass number");
                            }
                            else
                            {
                                MassNumberInput = true;
                            }
                        }
                        int UserInputAtomicNumber = 0;
                        var AtomicNumberInput = false;
                        while (AtomicNumberInput == false)
                        {
                            Console.WriteLine("Please entre the atomic number of the atom ");
                            UserInputAtomicNumber = Convert.ToInt32(Console.ReadLine());
                            if (UserInputAtomicNumber < 0 || UserInputAtomicNumber > 118)
                            {
                                Console.WriteLine("Not a valid atomic number");
                            }
                            else
                            {
                                AtomicNumberInput = true;
                            }
                        }
                        
                        Console.Clear();
                        var ElectronCapture = Collisions.CollisionFuntions.ElectronCaputre(Collisions.CollisionFuntions.AtomCreator(UserInputAtomicNumber, UserInputMassNumber), FirstSeed);
                        Console.WriteLine("The new atom created is " + ElectronCapture.Item1.Name + ", and it has an atomic number of " + ElectronCapture.Item1.AtomicNumber + " And a mass number of " + ElectronCapture.Item1.MassNumber);
                        Console.WriteLine("The other particle produced was a " + ElectronCapture.Item2);
                        Console.WriteLine("");
                        break;

                    case 3:
                        double UserWavelength = 0;
                        var WavelengthInput = false;
                        while (WavelengthInput == false)
                        {
                            Console.WriteLine("Please enter the Wavelength of the photon");
                            UserWavelength = Convert.ToDouble(Console.ReadLine());
                            if (UserWavelength < 0)
                            {
                                Console.WriteLine("Less than zero");
                            }
                            else
                            {
                                WavelengthInput = true;
                            }
                        }
                        double UserFrequency = 0;
                        var FrequencyInput = false;
                        while (FrequencyInput == false)
                        {
                            Console.WriteLine("Please enter the Frequency of the photon");
                            UserFrequency = Convert.ToDouble(Console.ReadLine());
                            if (UserFrequency < 0 )
                            {
                                Console.WriteLine("Less than zero");
                            }
                            else
                            {
                                FrequencyInput = true;
                            }
                        }
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine(Collisions.CollisionFuntions.PairProductionPhoton(new Photon(UserWavelength, UserFrequency), FirstSeed).Item1);
                        Console.WriteLine(Collisions.CollisionFuntions.PairProductionPhoton(new Photon(UserWavelength, UserFrequency), FirstSeed).Item1.Velocity + " m/s");
                        Console.WriteLine("And its ejection direction is " + Collisions.CollisionFuntions.PairProductionPhoton(new Photon(UserWavelength, UserFrequency), FirstSeed).Item1.Position);
                        Console.WriteLine("");
                        Console.WriteLine(Collisions.CollisionFuntions.PairProductionPhoton(new Photon(UserWavelength, UserFrequency), FirstSeed).Item2);
                        Console.WriteLine(Collisions.CollisionFuntions.PairProductionPhoton(new Photon(UserWavelength, UserFrequency), FirstSeed).Item2.Velocity + " m/s");
                        Console.WriteLine("And its ejection direction is " + Collisions.CollisionFuntions.PairProductionPhoton(new Photon(UserWavelength, UserFrequency), FirstSeed).Item2.Position);
                        Console.WriteLine("");
                        //Console.WriteLine(Collisions.CollisionFuntions.FeynmanDiagram(FList.New(new Photon().FeynmanSymbol, new Photon().FeynmanSymbol), FList.New(Collisions.CollisionFuntions.PairProductionPhoton(new Photon(UserWavelength, UserFrequency), FirstSeed).Item1.FeynmanSymbol, Collisions.CollisionFuntions.PairProductionPhoton(new Photon(UserWavelength, UserFrequency), FirstSeed).Item2.FeynmanSymbol)));
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

                        int AtomicNumber = 0;
                        var IsAtomicNumberInput = false;
                        while (IsAtomicNumberInput == false)
                        {
                            Console.WriteLine("Please entre the atomic number of the atom");
                            AtomicNumber = Convert.ToInt32(Console.ReadLine());
                            if (AtomicNumber < 0 || AtomicNumber > 118)
                            {
                                Console.WriteLine("Not a valid atomic number");
                            }
                            else
                            {
                                IsAtomicNumberInput = true;
                            }
                        }
                        int MassNumber = 0;
                        var IsMassNumberInput = false;
                        while (IsMassNumberInput == false)
                        {
                            Console.WriteLine("Please entre the mass number of the atom ");
                            MassNumber = Convert.ToInt32(Console.ReadLine());
                            if (MassNumber < 1 || MassNumber > 295)
                            {
                                Console.WriteLine("Not a valid mass number");
                            }
                            else
                            {
                               IsMassNumberInput = true;
                            }
                        }
                        var Atom = Collisions.CollisionFuntions.AtomCreator(AtomicNumber, MassNumber);
                        Console.Clear();
                        while (true)
                        {
                            
                            bool AllowedAnswer = false;
                            bool ShouldBreak = false;
                            while (AllowedAnswer == false)
                            {
                                Console.WriteLine("For Beta-Plus Decay press 1");
                                Console.WriteLine("For Beta-Minus Decay press 2");
                                Console.WriteLine("For Electron capture press 3");
                                Console.WriteLine("For Alpha Decay press 4");


                                Console.WriteLine("To exit to main menu press 10");
                                var answer5 = Convert.ToInt32(Console.ReadLine());


                                if (answer5 < 1 || answer5 > 4)
                                {

                                    if (answer5 != 10)
                                    {
                                        Console.WriteLine("Not a valid number, please choice from the menu");
                                    }
                                    else
                                    {
                                        ShouldBreak = true;
                                        break;
                                    }
                                    

                                }
                                else
                                {
                                    AllowedAnswer = true;
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
                                        Console.WriteLine(Collisions.CollisionFuntions.FeynmanDiagram(FList.New(Atom.Name), FList.New(Collisions.CollisionFuntions.AlphaDecay(Atom).Name, Collisions.CollisionFuntions.AtomCreator(2, 4).Name + " Nucleus")));
                                        Console.WriteLine("");
                                    }

                                }
                                if (ShouldBreak == true)
                                {
                                    break;
                                }

                            }
                            break;
                            
                        }
                        break;

                    case 6:

                        Console.WriteLine("Which two Particles are bieng simulated?");
                        Console.WriteLine("1: Two Protons");
                        Console.WriteLine("2: Two Electrons");
                        var answer6 = Convert.ToInt32(Console.ReadLine());
                        if (answer6 == 1)
                        {

                            var VP1Entered = false;
                            int VP1 = 0;
                            while (VP1Entered == false)
                            {
                                Console.WriteLine("Please enter the velocity for the first particles");
                                VP1 = Convert.ToInt32(Console.ReadLine());
                                if (VP1 < 0 || VP1 > 2.9E8)
                                {
                                    Console.WriteLine("Invalid velocity, please enter again");
                                }
                                else
                                {
                                    VP1Entered = true;
                                }
                            }
                            Console.WriteLine("Now enter the x, y and z coordinates for the first particle");
                            var X1 = Convert.ToInt32(Console.ReadLine());
                            var Y1 = Convert.ToInt32(Console.ReadLine());
                            var Z1 = Convert.ToInt32(Console.ReadLine());
                            var StartPosition1 = new Vector3D(X1, Y1, Z1);
                            

                            var VP2Entered = false;
                            int VP2 = 0;
                            while (VP2Entered == false)
                            {
                                Console.WriteLine("Please enter the velocity for the second particles");
                                VP2 = Convert.ToInt32(Console.ReadLine());
                                if (VP2 < 0 || VP2 > 2.9E8)
                                {
                                    Console.WriteLine("Invalid velocity, please enter again");
                                }
                                else
                                {
                                    VP2Entered = true;
                                }
                            }
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
                            var VP1Entered = false;
                            int VP1 = 0;
                            while (VP1Entered == false)
                            {
                                Console.WriteLine("Please enter the velocity for the first particles");
                                VP1 = Convert.ToInt32(Console.ReadLine());
                                if (VP1 < 0 || VP1 > 2.9E8)
                                {
                                    Console.WriteLine("Invalid velocity, please enter again");
                                }
                                else
                                {
                                    VP1Entered = true;
                                }
                            }
                            Console.WriteLine("Now enter the x, y and z coordinates for the first particle");
                            var X1 = Convert.ToInt32(Console.ReadLine());
                            var Y1 = Convert.ToInt32(Console.ReadLine());
                            var Z1 = Convert.ToInt32(Console.ReadLine());
                            var StartPosition1 = new Vector3D(X1, Y1, Z1);


                            var VP2Entered = false;
                            int VP2 = 0;
                            while (VP2Entered == false)
                            {
                                Console.WriteLine("Please enter the velocity for the second particles");
                                VP2 = Convert.ToInt32(Console.ReadLine());
                                if (VP2 < 0 || VP2 > 2.9E8)
                                {
                                    Console.WriteLine("Invalid velocity, please enter again");
                                }
                                else
                                {
                                    VP2Entered = true;
                                }
                            }
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
                        var ParticleSelected = false;
                        var answer7 = 0;
                        while (ParticleSelected == false)
                        {
                            Console.WriteLine("Please choose what particles are bieng accelerated");
                            Console.WriteLine("1: Protons");
                            Console.WriteLine("2: Electrons");
                            Console.WriteLine("3: Positrons");
                            Console.WriteLine("4: AntiProtons");
                            answer7 = Convert.ToInt32(Console.ReadLine());
                            if (answer7 <1 || answer7 > 4)
                            {
                                Console.WriteLine("Invalid answer, please choce a number from the table");
                            }
                            else
                            {
                                ParticleSelected = true;
                            }
                        }
                        
                        
                        var EFSEntred = false;
                        double ElectricFielsStrength = 0;
                        while (EFSEntred == false)
                        {
                            Console.WriteLine("Enter the electric field strength of the cyclatron");
                            ElectricFielsStrength = Convert.ToDouble(Console.ReadLine());
                            if (ElectricFielsStrength < 0)
                            {
                                Console.WriteLine("Invalid answer, the strength cannot be nagative");
                            }
                            else
                            {
                                EFSEntred = true;
                            }
                        }
                        Console.Clear();
                        
                        var MFSEntered = false;
                        double MagneticFieldStrength = 0;
                        while (MFSEntered == false)
                        {
                            Console.WriteLine("Enter the magnetic field strength of the cyclatron");
                            MagneticFieldStrength = Convert.ToDouble(Console.ReadLine());
                            if (MagneticFieldStrength < 0)
                            {
                                Console.WriteLine("Invalid answer, the strength cannot be negative");
                            }
                            else
                            {
                                MFSEntered = true;
                            }
                        }
                        Console.Clear();
                        
                        var TargetVelocitEnteredy = false;
                        double TargetV = 0;
                        while (TargetVelocitEnteredy == false)
                        {
                            Console.WriteLine("What is the target velocity?");
                            TargetV = Convert.ToDouble(Console.ReadLine());
                            if (TargetV < 0 || answer7 > 2.0E8)
                            {
                                Console.WriteLine("Invalid answer, enter again");
                            }
                            else
                            {
                                TargetVelocitEnteredy = true;
                            }
                        }
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
