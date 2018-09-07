using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle
{
    public class Strange : Quark
    {
        public bool ClassCompleted { get; set; }
        public Strange()
        {
            ClassCompleted = false;
        }
    }
}
