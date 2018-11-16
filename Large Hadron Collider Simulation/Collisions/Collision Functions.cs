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


        public static Tuple<Photon, Photon,string> Annialation(Particle Particle, Particle AntiParticle) // Simple collision     
        {
            var InputList = new List<Particle.Particle>();
            InputList.Add(Particle);
            InputList.Add(AntiParticle);
            var TotalRestMass = Particle.RestMass + AntiParticle.RestMass;
            var TotalParticleVelocity = Particle.Velocity + AntiParticle.Velocity;

            var TotalEnergy = MassToEnergy(TotalRestMass) + VelocityToEnergy(TotalParticleVelocity, TotalRestMass); //This energy will be split between the two photons

            //var Ejection = Vectors.Program.Ejection(Vectors.IRandomNumberGenerator);

            var P1 = new Particle.Photon(TotalEnergy / 2);
            var P2 = new Particle.Photon(TotalEnergy / 2);

            var EjectedPhotonList = new List<Particle.Particle>();
            EjectedPhotonList.Add(P1);  //Need to create a new list to add it to to become functional 
            EjectedPhotonList.Add(P2);

            var Products = new Tuple<Photon, Photon, string>//(P1, P2, FeynmanDiagram(1,InputList,EjectedPhotonList));
            return Products;  //Should return a tuple<Photon,Photon>

        }
        public static Tuple<Atom,ElectronNeutrino,string> ElectronCaputre(int atomicNumber,int massNumber)
        {
            var FeynmanInputList = new List<Particle.Particle>();
            FeynmanInputList.Add(new Proton(1));
            FeynmanInputList.Add(new Electron(1));
            var FeynmanOutputList = new List<Particle.Particle>();
            FeynmanOutputList.Add(new Neutron(1, true));
            FeynmanOutputList.Add(new ElectronNeutrino());
            var NewAtom = AtomCreator(atomicNumber -1, massNumber);
            var LeptonOutput = new Particle.ElectronNeutrino();
            var Products = new Tuple<Atom, ElectronNeutrino,string>(NewAtom, LeptonOutput, FeynmanDiagram(2,FeynmanInputList,FeynmanOutputList));

            return Products;  //Returns a tuple<Atom,ElectronNutrino>

        }

        public static string FeynmanDiagram(int CollisionNumber, List<Particle.Particle> InputList, List<Particle.Particle> OutputList) //This needs to be changed so it is less hardcoded and can generate diagrams by itself
        {    //This currently wirtes streight to the console but uses the classes to do so
            string outputString = "";
            switch (CollisionNumber)
            {
                case 1:
                    outputString = InputList[0].FeynmanSymbol + " + " + InputList[1].FeynmanSymbol + " --> " + OutputList[0].FeynmanSymbol + " + " + OutputList[1].FeynmanSymbol;
                    break;
                case 2:
                    outputString = new Proton(1).FeynmanSymbol + " + " + new Electron(1).FeynmanSymbol + " --> " + new Neutron(1, true).FeynmanSymbol + " + " + new ElectronNeutrino().FeynmanSymbol;
                    break;
            }

            return outputString;
        }

        public static Atom AtomCreator(int AtomicNumber, int MassNumber)
        {

            var AtomicNumberList = new List<Particle.Proton>();
            var NeutronNumberList = new List<Particle.Neutron>();

            for (int i = 0; i < AtomicNumber; i++)
            {
                AtomicNumberList.Add(new Proton(0));
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
