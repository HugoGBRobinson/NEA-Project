using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particles
{
    public class Photon : Lepton
    {
        
        public double Energy { get; protected set; }
        public Photon(double energy)
        {
           
            Velocity = 3 * Math.Pow(10, 8);
            Energy = energy;
            FeynmanSymbol = "p";

        }

    }
}
