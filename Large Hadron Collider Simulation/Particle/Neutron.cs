using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle
{
    public class Neutron : Hadron
    {
        public Boolean ClassCompleted { get; set; }
        public Neutron(double restMass, double velocity, bool spin) //Need to find the acctual values of the rest masses for the hadrons
        {
            RestMass = restMass;
            RelativeCharge = 0;
            Velocity = velocity;
            Quark1 = new Up();
            Quark2 = new Down();
            Quark3 = new Down();
            ClassCompleted = true;
            Spin = spin; 
        }
    }
}
