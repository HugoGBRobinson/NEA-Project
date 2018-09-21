using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle
{
    class Anti_Up : Quark
    {
        public bool ClassCompleted { get; set; }
        public Anti_Up()
        {
            Charge = -(2 / 3);
            Strangeness = 0;
            ClassCompleted = true;
        }
    }
}
