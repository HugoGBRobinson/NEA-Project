using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle
{
   public  class Electron : Lepton
    {
       
        public Electron(double velocity)
        {
           
            RelativeCharge = 1 / 2000;
            LeptonNumber = 1;
            RestMass = 9.109 * Math.Pow(10, -31);
            Velocity = velocity;
        }
    }
}
