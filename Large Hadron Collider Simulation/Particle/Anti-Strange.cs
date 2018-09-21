using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle
{
    class Anti_Strange : Quark
    {
        public bool ClassCompleted { get; set; }
        public Anti_Strange()
        {
            Charge = 1 / 3;
            Strangeness = 1;
            ClassCompleted = true;
        }
    }
}
