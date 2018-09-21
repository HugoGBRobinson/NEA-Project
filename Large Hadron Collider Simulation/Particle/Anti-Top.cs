using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle
{
    class Anti_Top : Quark
    {
        public bool ClassCompleted { get; set; }
        public Anti_Top()
        {
            Charge = - (2 / 3);
            Strangeness = 0;
            ClassCompleted = true;
        }
    }
}
