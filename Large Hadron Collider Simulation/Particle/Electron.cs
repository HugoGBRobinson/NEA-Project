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
        public int Charge { get; set; }
        public Electron(double velocity) : base (velocity)
        {
            Charge = -1;
            RelativeCharge = 1 / 2000;
            LeptonNumber = 1;
            RestMass = 9.109 * Math.Pow(10, -31);
            Velocity = velocity;
            FeynmanSymbol = "e-";
  
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
        }
    }
}
