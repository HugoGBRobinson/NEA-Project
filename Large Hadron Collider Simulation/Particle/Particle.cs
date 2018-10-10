using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle
{
   public abstract  class Particle
    {
        public double RestMass { get;  protected set; }
        public int RelativeCharge { get; protected set; }
        public double Velocity { get;  protected set; }
        public bool Spin { get;  protected set; }  //Shuld change the type to "Left" and "Right" to minamise confusion

    }
}
