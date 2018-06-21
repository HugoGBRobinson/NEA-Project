using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Vectors
{
    class Protons
    {
        public int Charge { get; set; }
        public Vector3D Position { get; set;}

        public Protons(double x,double y,double z,int charge)
        {
             Position = new Vector3D(x, y, z);
            Charge = charge;
        }
    }
}
