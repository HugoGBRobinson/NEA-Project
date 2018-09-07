using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle
{
   public  class Electron : Lepton
    {
        public bool ClassCompleted { get; set; }
        public Electron()
        {
            ClassCompleted = false;
        }
    }
}
