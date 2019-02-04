using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Collision_Functions_Backup
//{
//    //Must be a Pure Class
//    public class CollisionFuntions
//    {
//        public static void Main(string[] args)
//        {


//        }
//        //Pure
//        public static Tuple<Photon, Photon> Annialation(Particles.Particle Particle, Particles.Particle AntiParticle) // Simple collision     
//        {
//            //var Ejection = Vectors.Program.Ejection(Vectors.IRandomNumberGenerator);
//            return new Tuple<Photon, Photon>
//                (new Photon(MassToEnergy(TotalRestmass(FList.Map(GetRestMass, FList.New<Particles.Particle>(Particle, AntiParticle)))) + VelocityToEnergy(TotalVelocity(FList.Map(GetVelocity, FList.New<Particles.Particle>(Particle, AntiParticle))), TotalRestmass(FList.Map(GetRestMass, FList.New<Particles.Particle>(Particle, AntiParticle)))) / 2)
//                , new Photon(MassToEnergy(TotalRestmass(FList.Map(GetRestMass, FList.New<Particles.Particle>(Particle, AntiParticle)))) + VelocityToEnergy(TotalVelocity(FList.Map(GetVelocity, FList.New<Particles.Particle>(Particle, AntiParticle))), TotalRestmass(FList.Map(GetRestMass, FList.New<Particles.Particle>(Particle, AntiParticle)))) / 2));
//        }


//        //Pure
//        public static Tuple<Atom, ElectronNeutrino> ElectronCaputre(int atomicNumber, int massNumber)
//        {
//            return new Tuple<Atom, ElectronNeutrino>(AtomCreator(atomicNumber - 1, massNumber), new ElectronNeutrino()); //FeynmanDiagram(2, FeynmanInputList, FeynmanOutputList));
//                                                                                                                         //var FeynmanInputList = new List<Particle.Particle>();
//                                                                                                                         //FeynmanInputList.Add(new Proton(1));
//                                                                                                                         //FeynmanInputList.Add(new Electron(1));
//                                                                                                                         //var FeynmanOutputList = new List<Particle.Particle>();
//                                                                                                                         //FeynmanOutputList.Add(new Neutron(1));
//                                                                                                                         //FeynmanOutputList.Add(new ElectronNeutrino());
//                                                                                                                         //Returns a tuple<Atom,ElectronNutrino>

//        }


//        //Pure, lambda for readability and reusablitiy 
//        static Func<Particles.Particle, double> GetRestMass = x => x.RestMass;
//        static Func<Particles.Particle, double> GetVelocity = x => x.Velocity;
//        static Func<double, double, double> add = (x, y) => x + y;
//        //Pure
//        public static double TotalRestmass(FList<Double> ListOfMasses)
//        {
//            return FList.FoldL(add, 0, ListOfMasses);
//        }

//        public static double TotalVelocity(FList<double> ListOfVelocity)
//        {
//            return FList.FoldL(add, 0, ListOfVelocity);
//        }

//        //Pure
//        public static Atom AtomCreator(int AtomicNumber, int MassNumber)
//        {
//            return new Atom(CreateProtonList(AtomicNumber, FList.Empty<Proton>()), CreateNeutronList((MassNumber - AtomicNumber), FList.Empty<Neutron>()));
//        }

//        // genral case, edge case 
//        //Pure
//        public static FList<Proton> CreateProtonList(int AtomicNumber, FList<Proton> AtomicNumberList)
//        {
//            return Convert.ToBoolean(AtomicNumber = FList.Length(AtomicNumberList)) ? AtomicNumberList : FList.Prepend(new Proton(0), CreateProtonList(AtomicNumber, AtomicNumberList));

//        }
//        //Pure
//        public static FList<Neutron> CreateNeutronList(int NeutronNumber, FList<Neutron> NeutronNumberList)
//        {
//            return Convert.ToBoolean(NeutronNumber = FList.Length(NeutronNumberList)) ? NeutronNumberList : FList.Prepend(new Neutron(0), CreateNeutronList(NeutronNumber, NeutronNumberList));

//        }




//        //Pure
//        private static double VelocityToEnergy(double totalParticleVelocity, double totalRestMass) //Ke =0.5MV^2    Works for low speeds but will need to change to special relativity for very fast speeds 
//        {
//            return 0.5 * totalRestMass * Math.Pow(totalParticleVelocity, 2);
//        }
//        //Pure
//        private static double MassToEnergy(double totalRestMass) //E=mc^2
//        {
//            return totalRestMass * Math.Pow(300000000, 2);

//        }



//    }

//}
