using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collision  //To test an easy collision I will start with anialation (Particle + anti-particle = 2 photons)
{
    class Program
    {
        static void Main(string[] args)
        {



        }

        static void Anialation(Vectors.Protons Particle, Vectors.Anti_Proton AntiParticle) // Simple collision
        {
            var TotalRestMass = Particle.RestMass + AntiParticle.RestMass;
            var TotalParticleVelocity = Particle.Velocity + AntiParticle.Velocity;

            var TotalEnergy = MassToEnergy(TotalRestMass) + VelocityToEnergy(TotalParticleVelocity, TotalRestMass); //This energy will be split between the two photons



        }

        private static double VelocityToEnergy(double totalParticleVelocity, double totalRestMass) //Ke =0.5MV^2
        {
            return 0.5 * totalRestMass * Math.Pow(totalParticleVelocity, 2);
        }

        private static double MassToEnergy(double totalRestMass) //E=mc^2
        {
            return totalRestMass * Math.Pow(300000000, 2);
        }
    }
}
