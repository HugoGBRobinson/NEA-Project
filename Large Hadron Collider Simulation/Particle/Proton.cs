using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle
{
    public class Proton : Hadron
    {
        public Boolean ClassCompleted { get; set; }
        public Proton(double restMass, double velocity,bool spin)
        {
            RestMass = restMass;
            RelativeCharge = 1;
            Velocity = velocity;
            Quark1 = new Up();
            Quark2 = new Up();
            Quark3 = new Down();
            ClassCompleted = true;
            Spin = spin;

        }


    }
}
