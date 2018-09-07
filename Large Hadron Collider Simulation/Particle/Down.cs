using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle
{
    public class Down : Quark
    {
        public Boolean ClassCompleted { get; set; }

        public Down()
        {
            ClassCompleted = false;
            Charge = -(1 / 3);
            Strangeness = 0;

        }
    }
}
