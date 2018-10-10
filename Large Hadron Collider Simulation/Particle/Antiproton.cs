using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle
{
    public class Antiproton : Hadron, AntiParticleInterface.IAntiparticle<Proton>
    {

        public Antiproton(double velocity, bool spin)
        {
            RestMass = 1.6726219 * Math.Pow(10, -27);
            RelativeCharge = -1;
            Velocity = velocity;
            Quark1 = new Anti_Up();
            Quark2 = new Anti_Up();
            Quark3 = new Anti_Down();

            Spin = spin;
            BaryonNumber = 1;

        }

    }
}
