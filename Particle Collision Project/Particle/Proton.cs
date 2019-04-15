using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Particles
{
    public class Proton : Hadron
    {

        public Proton(double velocity,Vector3D position ) : base (velocity, position)
        {
            RestMass = 1.6726219 * Math.Pow(10, -27);
            RelativeCharge = 1;
            Quark1 = new Up();
            Quark2 = new Up();
            Quark3 = new Down();
            BaryonNumber = 1;
            FeynmanSymbol = "P";
            Velocity = velocity;
            Position = position;
            Charge = 19 * Math.Pow(10, -19);

        }
        public Proton(double velocity, Vector3D position, double distance) : base(velocity, position, distance)
        {
            RestMass = 1.6726219 * Math.Pow(10, -27);
            RelativeCharge = 1;
            Quark1 = new Up();
            Quark2 = new Up();
            Quark3 = new Down();
            BaryonNumber = 1;
            FeynmanSymbol = "P";
            Velocity = velocity;
            Position = position;
            Distance = distance;
            Charge = 19 * Math.Pow(10, -19);

        }

        public Proton(double velocity)  : base(velocity)
        {
            RestMass = 1.6726219 * Math.Pow(10, -27);
            RelativeCharge = 1;
            Quark1 = new Up();
            Quark2 = new Up();
            Quark3 = new Down();
            BaryonNumber = 1;
            FeynmanSymbol = "P";
            Velocity = velocity;
            Charge = 19 * Math.Pow(10, -19);
        }


    }
}
