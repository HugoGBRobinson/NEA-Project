using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particles
{
   public abstract class Baryon : Particle
    {
        public int BaryonNumber { get; protected set; }
    }
}
