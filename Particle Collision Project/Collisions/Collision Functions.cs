using System;
using System.Collections.Generic;
using Particles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quadrivia.FunctionalLibrary;
using System.Windows.Media.Media3D;

namespace Collisions
{
    //Must be a Pure Class
    public class CollisionFuntions
    {
        public static void Main(string[] args)
        {
        }
        //Pure
        public static Tuple<Photon, Photon> Annialation(Particles.Particle Particle, Particles.Particle AntiParticle, FRandom Rand) // Simple collision     
        {
            return (VectorFunctions.OppositeEjections(CreateAnnialationPhoton(Particle, AntiParticle), CreateAnnialationPhoton(Particle, AntiParticle), Rand));
        }
        //Pure
        public static Photon CreateAnnialationPhoton(Particle Particle, Particle AntiParticle)
        {
            // This is all one line, it has been split onto multiple lines for readability 
            return new Photon(EnergyToWavelength(MassToEnergy(TotalRestmass(FList.Map(GetRestMass, FList.New<Particles.Particle>(Particle, AntiParticle)))) + VelocityToEnergy(TotalVelocity(FList.Map(GetVelocity, FList.New<Particles.Particle>(Particle, AntiParticle))), TotalRestmass(FList.Map(GetRestMass, FList.New<Particles.Particle>(Particle, AntiParticle)))) / 2), EnergyToFrequency(MassToEnergy(TotalRestmass(FList.Map(GetRestMass, FList.New<Particles.Particle>(Particle, AntiParticle)))) + VelocityToEnergy(TotalVelocity(FList.Map(GetVelocity, FList.New<Particles.Particle>(Particle, AntiParticle))), TotalRestmass(FList.Map(GetRestMass, FList.New<Particles.Particle>(Particle, AntiParticle)))) / 2));
        }

        //Pure
        public static Tuple<Particle, Particle> PairProductionPhoton(Photon Photon, FRandom Rand)
        {
            //This is all one line, it has been split onto multiple lines for readability
            return WavelengthToEnergy(Photon) >= MassToEnergy(new Proton(1, new Vector3D(1, 1, 1)).RestMass) ? VectorFunctions.OppositeEjections(CreatePairproductionOutputGreaterThanProtonRestMass(Photon), CreatePairproductionOutputGreaterThanProtonRestMass(Photon), Rand): VectorFunctions.OppositeEjections(CreatePairproductionOutputLessThanProtonRestMass(Photon), CreatePairproductionOutputLessThanProtonRestMass(Photon), Rand);
        }

        public static Proton CreatePairproductionOutputGreaterThanProtonRestMass(Photon Photon)
        {
            return new Proton(EnergyToVelocity((WavelengthToEnergy(Photon) + MassToEnergy(new Proton(1).RestMass)) / 2, GetRestMass(new Proton(1))));
        }

        public static Electron CreatePairproductionOutputLessThanProtonRestMass(Photon Photon)
        {
            return new Electron(EnergyToVelocity((WavelengthToEnergy(Photon) + MassToEnergy(new Electron(1).RestMass)) / 2, GetRestMass(new Electron(1))));
        }


        //Pure
        public static Tuple<Atom, Particle> ElectronCaputre(Atom Atom, FRandom Rand)
        {
            return new Tuple<Atom, Particle>(AtomCreator(Atom.AtomicNumber - 1, Atom.MassNumber), VectorFunctions.SingularEjection(new ElectronNeutrino(1), Rand));
        }


        //Cyclatron
        public static Particle Cyclatron<T>(T P, double E, double B, double RequiredV) where T: Particle
        {
            return ElectricFiledToFindV(E, P, P.Velocity) >= RequiredV ? (T)Activator.CreateInstance(typeof(T), ElectricFiledToFindV(E, P, P.Velocity), new Vector3D(0, MagneticFieldToFindR(B, ElectricFiledToFindV(E, P, P.Velocity), P), 0)) : (T)Activator.CreateInstance(typeof(T), Cyclatron((T)Activator.CreateInstance(typeof(T), E, B, ElectricFiledToFindV(E, P, P.Velocity)),E,B,RequiredV).Velocity ,RequiredV);
        }

        //r = vm/Be
        private static double MagneticFieldToFindR<T>(double B, double v, T P) where T: Particle
        {
            return (v * P.RestMass) / (B * P.Charge);
        }
        //v = EeL/mv
        private static double ElectricFiledToFindV<T>(double E, T P,double InitialV) where T: Particle 
        {
            return (E * P.Charge * 0.01) / (P.RestMass * InitialV);
        }

        //Velocity Selector 
        //v=E/B
        //E = Electric field strength
        //B = Magnetic Field strength 

        //Need to stress this fucntion as it has a lot going for it
        public static FList<Particles.Particle> VelocitySelector<T>(T Particle, int NumberOfparticles, double E, double B, FRandom Rand) where T : Particle
        {
            return FList.Length(FList.Filter((x) => x.Velocity == Devide(E, B), GenerateListOfParticlesWithRandomVelocity(Particle, NumberOfparticles, Rand))) != 0  ? FList.Filter((x) => x.Velocity == Devide(E, B), GenerateListOfParticlesWithRandomVelocity(Particle, NumberOfparticles, Rand)) : null;
        }

        public static FList<Particles.Particle> GenerateListOfParticlesWithRandomVelocity<T>(T particle, int numberOfInputParticles, FRandom Rand) where T : Particle
        {
            return numberOfInputParticles != 1 ? FList.New(GenerateParticleWithRandomVelocity(particle, Rand), GenerateListOfParticlesWithRandomVelocity(GenerateParticleWithRandomVelocity(particle, FRandom.Next(Rand, 0, 100)), numberOfInputParticles - 1, FRandom.Next(Rand, 0, 100))) : FList.New(GenerateParticleWithRandomVelocity(particle, Rand));
        }

        public static Particle GenerateParticleWithRandomVelocity<T>(T particle, FRandom rand) where T : Particle
        {
            return (T)Activator.CreateInstance(particle.GetType(), particle.Velocity + RandomiseVelocity(rand).Number, particle.Position, particle.Distance);
        }

        //public static double Calculator(double restMass, int velocity, double fluxDensity, double charge)
        //{
        //    return ((restMass * velocity) / fluxDensity * charge);
        //}

        public static FRandom RandomiseVelocity(FRandom Rand)
        {
            return FRandom.Next(Rand, Convert.ToInt32(Math.Pow(1, 3)), Convert.ToInt32(Math.Pow(2.9, 8)));
        }

        public static Tuple<Neutron, Positron, ElectronNeutrino> BetaPlusDecayIndividual(Proton P)
        {
            return new Tuple<Neutron, Positron, ElectronNeutrino>(new Neutron(0), new Positron(0), new ElectronNeutrino(0));
        }

        public static Tuple<Proton, Electron, AntiElectronNeutrino> BetaMinusDecayIndividual(Neutron N)
        {
            return new Tuple<Proton, Electron, AntiElectronNeutrino>(new Proton(0), new Electron(0), new AntiElectronNeutrino(0));
        }

        public static Atom BetaPlusDecayAtom(Atom A)
        {
            return AtomCreator(A.AtomicNumber - 1, A.MassNumber);
        }

        public static Atom BetaMinusDeacyAtom(Atom A)
        {
            return AtomCreator(A.AtomicNumber + 1, A.MassNumber);
        }

        public static Atom AlphaDecay (Atom A)
        {
            return AtomCreator(A.AtomicNumber - 2, A.MassNumber - 4);
        }
        //Need to add proton decay 

        public static Tuple<Particle,Particle> ElectrostaticRepulsion <T>(T P1, T P2, FRandom Rand, Vector3D StartingPositionParticle1, Vector3D StartingPositionParticle2) where T : Particle
        {
            return new Tuple<Particle, Particle>((T)Activator.CreateInstance(P1.GetType(), VectorFunctions.AcelerationOfParticlesFromElectrostaticForce(P1, P2, StartingPositionParticle1, StartingPositionParticle2), VectorFunctions.CreateOpposite(VectorFunctions.VectorBetween(StartingPositionParticle1, StartingPositionParticle2)).Item2), (T)Activator.CreateInstance(P2.GetType(), VectorFunctions.AcelerationOfParticlesFromElectrostaticForce(P2, P1, StartingPositionParticle1, StartingPositionParticle2), VectorFunctions.VectorBetween(StartingPositionParticle1, StartingPositionParticle2)));
        }

        



        //Pure, lambda for readability and reusablitiy 
        public static Func<Particles.Particle, double> GetRestMass = x => x.RestMass;
        public static Func<Particles.Particle, double> GetVelocity = x => x.Velocity;
        public static Func<double, double, double> add = (x, y) => x + y;
        public static Func<double, double, double> Devide = (x, y) => x / y;

        //Pure
        public static double TotalRestmass(FList<Double> ListOfMasses)
        {
            return FList.FoldL(add, 0, ListOfMasses);
        }
        public static double TotalVelocity(FList<double> ListOfVelocity)
        {
            return FList.FoldL(add, 0, ListOfVelocity);
        }
        public static double WavelengthToEnergy (Photon Photon)
        {
            return 6.63E-34 * 3E8 / Photon.Wavelength;

        }
        public static double FrequencyToEnergy (Photon Photon)
        {
            return 6.63E-34 * Photon.Frequency;
        }
        public static double EnergyToVelocity(double energy, double mass)
        {
            return Math.Sqrt(energy / 0.5 * mass);
        }
        private static double VelocityToEnergy(double totalParticleVelocity, double totalRestMass) //Ke =0.5MV^2    Works for low speeds but will need to change to special relativity for very fast speeds 
        {
            return 0.5 * totalRestMass * Math.Pow(totalParticleVelocity, 2);
        }
        private static double MassToEnergy(double totalRestMass) //E=mc^2
        {
            return totalRestMass * Math.Pow(300000000, 2);
        }
        public static double EnergyToWavelength(double energy) //hc/E
        {
            return (6.63E-34 * 300000000) / energy;
        }
        public static double EnergyToFrequency(double energy)
        {
            return energy / 6.63E-34;
        }


        //Pure
        public static string FeynmanDiagram(FList<String> Inputs, FList<String> Outputs)
        {
            return PartialFeynmanDiagram(Inputs) + " ---> " + PartialFeynmanDiagram(Outputs);
        }

        public static string PartialFeynmanDiagram(FList<string> List)
        {
            return FList.Length(List) == 1 ? FList.Head(List) : FList.Head(List) + " + " + PartialFeynmanDiagram(FList.Tail(List));
        }
        //Pure
        public static Atom AtomCreator(int AtomicNumber, int MassNumber)
        {
            return  new Atom(CreateProtonList(AtomicNumber, FList.Empty<Proton>()), CreateNeutronList((MassNumber - AtomicNumber), FList.Empty<Neutron>()));
        }


        // genral case, edge case 
        //Pure
        public static FList<Proton> CreateProtonList(int AtomicNumber, FList<Proton> AtomicNumberList)
        {
            return AtomicNumber == FList.Length(AtomicNumberList) ? AtomicNumberList : CreateProtonList(AtomicNumber, FList.Prepend(new Proton(0),AtomicNumberList));
        }
        //Pure
        public static FList<Neutron> CreateNeutronList(int NeutronNumber, FList<Neutron> NeutronNumberList)
        {
            return NeutronNumber == FList.Length(NeutronNumberList) ? NeutronNumberList : CreateNeutronList(NeutronNumber, FList.Prepend(new Neutron(0), NeutronNumberList));
        }

    }

    public static class VectorFunctions 
    {
        //Pure
        public static Particle SingularEjection<T>(T p, FRandom Rand) where T : Particle 
        {
            return (T)Activator.CreateInstance(typeof(T), p.Velocity, new Vector3D(Convert.ToDouble(FRandom.Next(Rand, 0, 360).Number), Convert.ToDouble(FRandom.Next(Rand, -90, 90).Number), Convert.ToDouble(FRandom.Next(FRandom.Next(Rand, 0, 360), 0, 360).Number))); // The values for x,y,z will be replaced by the random function to find a vector and then calculate the relative position of it from (0,0,0)
        }
        //Pure
        public static Photon SingularEjection(Photon p, FRandom Rand)  //Overloded function for photons 
        {
            return new Photon(p.Wavelength, p.Frequency, new Vector3D(Convert.ToDouble(FRandom.Next(Rand, 0, 360).Number), Convert.ToDouble(FRandom.Next(Rand, -90, 90).Number), Convert.ToDouble(FRandom.Next(FRandom.Next(Rand,0,360), 0, 360).Number)));
        }
        //Dirty
        public static Tuple<Particle,Particle> OppositeEjections<T> (T P1, T P2, FRandom Rand) where T : Particle
        {
            Vector3D v = new Vector3D(Convert.ToDouble(FRandom.Next(Rand, 0, 360).Number), Convert.ToDouble(FRandom.Next(Rand, -90, 90).Number), Convert.ToDouble(FRandom.Next(FRandom.Next(Rand, 0, 360), 0, 360).Number));  // Dirty need to look into for a better solution 
            return new Tuple<Particle,Particle>((T)Activator.CreateInstance(typeof(T),P1.Velocity, v), (T)Activator.CreateInstance(typeof(T),P2.Velocity, CreateOpposite(v).Item2));
        }
        public static Tuple<Photon,Photon> OppositeEjections(Photon P1, Photon P2, FRandom Rand)
        {
            Vector3D v = new Vector3D(Convert.ToDouble(FRandom.Next(Rand, 0, 360).Number), Convert.ToDouble(FRandom.Next(Rand, -90, 90).Number), Convert.ToDouble(FRandom.Next(FRandom.Next(Rand, 0, 360), 0, 360).Number));  // Dirty need to look into for a better solution 
            return new Tuple<Photon, Photon>(new Photon(P1.Wavelength,P1.Frequency,v), new Photon(P2.Wavelength,P2.Frequency, CreateOpposite(v).Item2));
        }
        //Pure
        public static Tuple<Vector3D,Vector3D> CreateOpposite (Vector3D V)
        {
            return new Tuple<Vector3D, Vector3D>(new Vector3D(V.X,V.Y,V.Z), new Vector3D(V.X * -1, V.Y * -1, V.Z * -1));
        }

        public static Particle DistanceEjected<T> (T Particle) where T : Particle
        {
            return EdgeOFContainmentChecker((T)Activator.CreateInstance(typeof(T), Particle.Velocity, Particle.Position, (Convert.ToDouble(Particle.LifeSpan) * Particle.Velocity))); 
        }
        public static Photon DistanceEjected(Photon Particle) 
        {
            return EdgeOFContainmentChecker( new Photon(Particle.Wavelength,Particle.Frequency,Particle.Position,(Particle.LifeSpan * Particle.Velocity)));
        }
        public static Particle EdgeOFContainmentChecker<T> (T Particle) where T : Particle
        {
            return Particle.Distance >= 10 ? (T)Activator.CreateInstance(typeof(T), Particle.Velocity, Particle.Position, 10) : (T)Activator.CreateInstance(typeof(T), Particle.Velocity, Particle.Position, Particle.Distance);
        }
        public static Photon EdgeOFContainmentChecker (Photon Particle)
        {
            return Particle.Distance >= 10 ? new Photon(Particle.Wavelength, Particle.Frequency, Particle.Position,10) : new Photon(Particle.Wavelength, Particle.Frequency, Particle.Position, Particle.Distance);
        }


        public static Particle AdditionOfVectorsForRepulsion <T>(Vector3D StartingPosition,T P1, T P2) where T : Particle
        {
            return (T)Activator.CreateInstance(P1.GetType(),P1.Velocity , Vector3D.Add(StartingPosition,Vector3D.Add(P1.Position, P2.Position)));  //Not dealing with genircs, but dealing with the acctual type passed in 
        }

        public static double AcelerationOfParticlesFromElectrostaticForce<T>(T Particle1, T Particle2, Vector3D StartingPositionParticle1, Vector3D StartingPositionParticle2) where T : Particle
        {
            //F = ma
            //F = Qq/4Pi8.85E-12r^2
            return ((Particle1.Charge * Particle2.Charge) / (4 * Math.PI * 8.85E-12 * VectorBetween(StartingPositionParticle1, StartingPositionParticle2).LengthSquared)) / CollisionFuntions.GetRestMass(Particle1);
        }

        public static Vector3D VectorBetween(Vector3D StartingPositionParticle1, Vector3D StartingPositionParticle2)
        {
            return new Vector3D(StartingPositionParticle2.X - StartingPositionParticle1.X, StartingPositionParticle2.Y - StartingPositionParticle1.Y, StartingPositionParticle2.Z - StartingPositionParticle1.Z);
        }

    }

}
