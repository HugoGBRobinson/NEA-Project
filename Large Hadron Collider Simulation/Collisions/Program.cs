using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collisions
{
    public class Program
    {
        static void Main(string[] args)
        {


        }

        public static Particle.Photon[] Anialation(Particle.Proton Particle, Particle.Antiproton AntiParticle) // Simple collision     
        {
            var TotalRestMass = Particle.RestMass + AntiParticle.RestMass;
            var TotalParticleVelocity = Particle.Velocity + AntiParticle.Velocity;

            var TotalEnergy = MassToEnergy(TotalRestMass) + VelocityToEnergy(TotalParticleVelocity, TotalRestMass); //This energy will be split between the two photons

            //var Ejection = Vectors.Program.Ejection(Vectors.IRandomNumberGenerator);

            var P1 = new Particle.Photon(TotalEnergy / 2);
            var P2 = new Particle.Photon(TotalEnergy / 2);

            var EjectedPhotonList = new Particle.Photon[2] { P1, P2 };
            return EjectedPhotonList;

        }

        private static double VelocityToEnergy(double totalParticleVelocity, double totalRestMass) //Ke =0.5MV^2    Works for low speeds but will need to change to special relativity for very fast speeds 
        {
            return 0.5 * totalRestMass * Math.Pow(totalParticleVelocity, 2);
        }

        private static double MassToEnergy(double totalRestMass) //E=mc^2
        {
            return totalRestMass * Math.Pow(300000000, 2);
        }
    }
}
