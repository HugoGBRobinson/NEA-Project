using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle
{
    public class Botton : Quark
    {
        public Boolean ClassCompleted { get; set; }
        public Botton()
        {
            Charge = -1 / 3;
            Strangeness = 0;
            ClassCompleted = true;
        }
    }
}
