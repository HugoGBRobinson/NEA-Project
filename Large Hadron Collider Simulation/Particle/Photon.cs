using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle
{
    public class Photon : Lepton
    {
        public bool ClassCompleted { get; set; }
        public Photon()
        {
            ClassCompleted = false;
        }

    }
}
