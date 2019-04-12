using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Particles
{
    public class Antiproton : Hadron, AntiParticleInterface.IAntiparticle<Proton>
    {

        public Antiproton(double velocity, Vector3D position) : base(velocity, position)
        {
            RestMass = 1.6726219E-27;
            RelativeCharge = -1;
            Quark1 = new Anti_Up();
            Quark2 = new Anti_Up();
            Quark3 = new Anti_Down();
            BaryonNumber = 1;
            FeynmanSymbol = "AP";
        }

        public Antiproton(double velocity) : base(velocity)
        {
            RestMass = 1.6726219E-27;
            RelativeCharge = -1;
            Quark1 = new Anti_Up();
            Quark2 = new Anti_Up();
            Quark3 = new Anti_Down();
            BaryonNumber = 1;
            FeynmanSymbol = "AP";
        }

    }
}
