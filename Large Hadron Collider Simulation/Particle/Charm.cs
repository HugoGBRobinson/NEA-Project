using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle
{
   public class Charm : Quark
    {
        public Boolean ClassCompleted { get; set; }
        public Charm()
        {
            Charge = 2 / 3;
            Strangeness = 0;

            ClassCompleted = true;
        }
    }
}
