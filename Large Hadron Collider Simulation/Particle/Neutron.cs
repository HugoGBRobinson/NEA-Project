using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Particles
{
    public class Neutron : Hadron
    {

        public Neutron(double velocity, Vector3D position) : base(velocity, position)//Need to find the acctual values of the rest masses for the hadrons
        {
            RestMass = 1.674929 * Math.Pow(10,-27);
            RelativeCharge = 0;
            Velocity = velocity;
            Quark1 = new Up();
            Quark2 = new Down();
            Quark3 = new Down();

            BaryonNumber = 1;
            FeynmanSymbol = "N";
        }

        public Neutron(double velocity) : base(velocity)
        {
                
        }
    }
}
