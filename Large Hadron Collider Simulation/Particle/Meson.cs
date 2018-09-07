using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle
{
    public abstract class Meson : Baryon
    {
        public int Quark { get; set; } //Quark
        public int AntiQuark { get; set; }//Quark
        public Meson(double restMass, int relativeCharge, double velocity)
        {
            RestMass = restMass;
            RelativeCharge = relativeCharge;
            Velocity = velocity;
        }
    }
}
