using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Vectors  //Vectors and randomised ejection
{
    public class Program
    {
        static void Main(string[] args)
        {
            var ProtonList = new List<Protons>();

            ProtonList.Add(new Protons(2, 3, 1, 1,1.1,1));
            ProtonList.Add(new Protons(4, -2, 2, 1,1.1,1));

            var CompVectors = DistanceBetweenTwoPoints(ProtonList);
            Console.WriteLine(CompVectors);

            Console.ReadKey();
        }
        

        static double DistanceBetweenTwoPoints(List<Protons> ProtonList) //Takes in two vectors and finds the distance between two points
        {
            var Proton1 = ProtonList[0];
            var Proton2 = ProtonList[1];

            
            var NewVectorStructure = new Vector3D(Proton1.Position.X + Proton2.Position.X, Proton1.Position.Y + Proton2.Position.Y, Proton1.Position.Z + Proton2.Position.Z);
            var LengthOfNewvectorStructure = NewVectorStructure.Length;
            var LengthOfNewvectorStructure2 = (Proton1.Position - Proton2.Position).Length;
            return LengthOfNewvectorStructure2;
        }

        public static Vector3D Ejection(IRandomNumberGenerator RNG)
        {
            var EjectionDirection = new Vector3D();

            var Theta = RNG.Next(0, 360);
            var Phi = RNG.Next(-90, 90);

            EjectionDirection.X = Math.Cos(Theta);
            EjectionDirection.Y = Math.Sin(Phi);
            EjectionDirection.Z = Math.Sin(Theta);

            return EjectionDirection;
        }
    }
}
