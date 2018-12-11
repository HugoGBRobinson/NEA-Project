using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Media3D;
using System.Threading.Tasks;

namespace Particles
{
    public class Positron : Lepton
    {
        public int Charge { get; set; }

        public Positron(double velocity, Vector3D position) : base (velocity,position)
        {
            Charge = 1;
            RelativeCharge = 1 / 2000;
            LeptonNumber = 1;
            RestMass = 9.109 * Math.Pow(10, -31);
            FeynmanSymbol = "e-";
        }
        public Positron(double velocity) : base (velocity)
        {
            Charge = 1;
            RelativeCharge = 1 / 2000;
            LeptonNumber = 1;
            RestMass = 9.109 * Math.Pow(10, -31);
            FeynmanSymbol = "e-";
        }

    }
}
