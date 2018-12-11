using System;
using System.Collections.Generic;
using Particle;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Vectors
{
    class Program
    {
        static void Main(string[] args)
        {



        }

        static List<double> ParticleEjection(List<Particle.Particle> ListOfParticleOutputs)
        {
            var Ejections = new List<double>();

            for (int i = 0; i < ListOfParticleOutputs.Count; i++)
            {
                Ejections.Add(SingularEjection().Length);
            }
            double TotalMagnitude = 0;
            for (int i = 0; i < Ejections.Count; i++)
            {

            }

            if (true)
            {

            }


        }

        static List<double> AdditionToEjectionList()  //Recursion insted of a loop

        static Vector3D SingularEjection()
        {
            return new Vector3D(Math.Cos(GenerateRandomNumber(0, 360).Item1), Math.Sin(GenerateRandomNumber(-90, 90).Item1), Math.Sin(GenerateRandomNumber(0, 360).Item1));
        }

        public static Tuple<double, uint, uint> GenerateRandomNumber(int u, uint v)

        {

            int u2 = 36969 * (u & 65535) + (u >> 16);

            uint v2 = 18000 * (v & 65535) + (v >> 16);

            double r = ((u2 << 16) + v2 + 1.0) * 2.328306435454494e-10;

            return Tuple.Create(r, u2, v2);

        }
    }
}
