using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particles  //Need to rename to particles
{
   public abstract  class Particle
    {
        public double RestMass { get;  protected set; }
        public int RelativeCharge { get; protected set; }
        public double Velocity { get;  protected set; } 
        public string FeynmanSymbol { get; protected set; }
    }
}
