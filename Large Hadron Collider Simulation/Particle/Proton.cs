using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle
{
    public class Proton : Hadron
    {

        public Proton(double velocity,bool spin)
        {
            RestMass = 1.6726219 * Math.Pow(10, -27);
            RelativeCharge = 1;
            Velocity = velocity;
            Quark1 = new Up();
            Quark2 = new Up();
            Quark3 = new Down();
            Spin = spin;
            BaryonNumber = 1;

        }


    }
}
