using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Vectors
{
    public class Protons
    {
        public int Charge { get; set; }
        public Vector3D Position { get; set;}
        public double RestMass { get; set; }
        public double Velocity { get; set; }


        public Protons(double x,double y,double z,int charge, double veloctiy )
        {
             Position = new Vector3D(x, y, z);
            Charge = charge;
            RestMass = 1.6726219 * Math.Pow(10, -27);
            Velocity = veloctiy;
        }

    }
}
