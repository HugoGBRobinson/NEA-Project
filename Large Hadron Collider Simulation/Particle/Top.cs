using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle
{
    public class Top : Quark
    {
        public bool ClassCompleted { get; set; }
        public Top()
        {
            Charge = 2 / 3;
            Strangeness = 0;
            ClassCompleted = true;
        }
    }
}
