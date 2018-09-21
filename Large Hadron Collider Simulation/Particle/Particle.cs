using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle
{
   public abstract  class Particle
    {
        public double RestMass { get;  set; }
        public int RelativeCharge { get;  set; }
        public double Velocity { get;  set; }
        public bool Spin { get;  set; }  //Shuld change the type to "Left" and "Right" to minamise confusion

    }
}
