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
            ClassCompleted = false;
        }
    }
}
