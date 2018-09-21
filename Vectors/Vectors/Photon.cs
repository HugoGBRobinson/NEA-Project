using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    public class Photon
    {
        public double Energy { get; set; }
        public double Velocity { get; set; }
        public Photon(double energy)
        {
            Velocity = 3 * Math.Pow(10, 8);
            Energy = energy;

        }
    }
}
