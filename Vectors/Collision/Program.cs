using System;
using System.Windows.Media.Media3D;

namespace Collision  //To test an easy collision I will start with anialation (Particle + anti-particle = 2 photons)
{
    public class Program
    {
        static void Main(string[] args)
        {



        }

        public static Vectors.Photon[] Anialation(Vectors.Protons Particle, Vectors.Anti_Proton AntiParticle) // Simple collision
        {
            var TotalRestMass = Particle.RestMass + AntiParticle.RestMass;
            var TotalParticleVelocity = Particle.Velocity + AntiParticle.Velocity;

            var TotalEnergy = MassToEnergy(TotalRestMass) + VelocityToEnergy(TotalParticleVelocity, TotalRestMass); //This energy will be split between the two photons

            //var Ejection = Vectors.Program.Ejection(Vectors.IRandomNumberGenerator);

            var P1 = new Vectors.Photon(TotalEnergy / 2);
            var P2 = new Vectors.Photon(TotalEnergy / 2);

            var EjectedParticleList = new Vectors.Photon[2] { P1, P2 };
            return EjectedParticleList;

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
