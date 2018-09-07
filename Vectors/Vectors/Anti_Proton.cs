using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Vectors
{
    public class Anti_Proton
    {
        public int Charge { get; set; }
        public Vector3D Position { get; set; }
        public double RestMass { get; set; }
        public double Velocity { get; set; }

        public Anti_Proton(double x, double y, double z, int charge, double restMass, double velocity)
        {
            Position = new Vector3D(x, y, z);
            Charge = charge;
            RestMass = restMass;
            Velocity = velocity;

        }
    }
}
