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
            RestMass = 9.109E-31;
            Velocity = velocity;
            FeynmanSymbol = "e-";
            Charge = -1.6E-19;

        }

        public Electron(double velocity,Vector3D position) : base(velocity,position)
        {
            RelativeCharge = 1 / 2000;
            LeptonNumber = 1;
            RestMass = 9.109E-31;
            Velocity = velocity;
            FeynmanSymbol = "e-";
            Position = position;
            Charge = -1.6E-19;
        }
        public Electron(double velocity,Vector3D position, double distance): base(velocity, position, distance)
        {
            RelativeCharge = 1 / 2000;
            LeptonNumber = 1;
            RestMass = 9.109E-31;
            Velocity = velocity;
            FeynmanSymbol = "e-";
            Position = position;
            Charge = -1.6E-19;
            Distance = distance;
        }
        public Electron(double velocity, Vector3D position, double distance, double charge) : base(velocity, position, distance)
        {
            RelativeCharge = 1 / 2000;
            LeptonNumber = 1;
            RestMass = 9.109E-31;
            Velocity = velocity;
            FeynmanSymbol = "e-";
            Position = position;
            Charge = charge;
            Distance = distance;
        }

    }
}
