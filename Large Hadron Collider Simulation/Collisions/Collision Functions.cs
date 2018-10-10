using System;
using System.Collections.Generic;
using Particle;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collisions
{
    public static class CollisionFunctions
    {
        public static void Main(string[] args)
        {

        }


        public static Tuple<Photon, Photon> Annialation(Particle.Proton Particle, Particle.Antiproton AntiParticle) // Simple collision     
        {
            var TotalRestMass = Particle.RestMass + AntiParticle.RestMass;
            var TotalParticleVelocity = Particle.Velocity + AntiParticle.Velocity;

            var TotalEnergy = MassToEnergy(TotalRestMass) + VelocityToEnergy(TotalParticleVelocity, TotalRestMass); //This energy will be split between the two photons

            //var Ejection = Vectors.Program.Ejection(Vectors.IRandomNumberGenerator);

            var P1 = new Particle.Photon(TotalEnergy / 2);
            var P2 = new Particle.Photon(TotalEnergy / 2);

            var EjectedPhotonList = new Particle.Photon[2] { P1, P2 };
            var Products = new Tuple<Photon, Photon>(P1, P2);
            return Products;  //Should return a tuple<Photon,Photon>

        }
        public static Tuple<Atom,ElectronNeutrino> ElectronCaputre(int atomicNumber,int massNumber)
        {
            var NewAtom = AtomCreator(atomicNumber -1, massNumber);



            var LeptonOutput = new Particle.ElectronNeutrino();

            var Products = new Tuple<Atom, ElectronNeutrino>(NewAtom, LeptonOutput);

            return Products;  //Returns a tuple<Atom,ElectronNutrino>

        }

        


        public static Atom AtomCreator(int AtomicNumber, int MassNumber)
        {

            var AtomicNumberList = new List<Particle.Proton>();
            var NeutronNumberList = new List<Particle.Neutron>();

            for (int i = 0; i < AtomicNumber; i++)
            {
                AtomicNumberList.Add(new Proton(0, true));
            }
            for (int i = 0; i < (MassNumber - AtomicNumber); i++)
            {
                NeutronNumberList.Add(new Neutron(0, true));
            }


            return new Atom(AtomicNumberList, NeutronNumberList, AtomicNumberList.Count + NeutronNumberList.Count);

        }

        private static double VelocityToEnergy(double totalParticleVelocity, double totalRestMass) //Ke =0.5MV^2    Works for low speeds but will need to change to special relativity for very fast speeds 
        {
            var VelocityToEnergyOutput = 0.5 * totalRestMass * Math.Pow(totalParticleVelocity, 2);
            return VelocityToEnergyOutput;
        }

        private static double MassToEnergy(double totalRestMass) //E=mc^2
        {
            var MassToEnergyOutput = totalRestMass * Math.Pow(300000000, 2);
            return MassToEnergyOutput;
        }
    }
}
