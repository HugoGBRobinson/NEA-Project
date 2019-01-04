using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Particles
{
   public  class Electron : Lepton
    {
        public Electron(double velocity) : base (velocity)
        {
            RelativeCharge = -1;
            LeptonNumber = 1;
            RestMass = 9.109 * Math.Pow(10, -31);
            Velocity = velocity;
            FeynmanSymbol = "e-";
            Charge = -19 * Math.Pow(10, -19);

        }

        public Electron(double velocity,Vector3D position) : base(velocity,position)
        {
            Charge = -1;
            RelativeCharge = 1 / 2000;
            LeptonNumber = 1;
            RestMass = 9.109 * Math.Pow(10, -31);
            Velocity = velocity;
            FeynmanSymbol = "e-";
            Position = position;
            Charge = -19 * Math.Pow(10, -19);
        }
    }
}
