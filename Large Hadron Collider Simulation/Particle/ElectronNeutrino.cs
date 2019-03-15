using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Particles
{
   public class ElectronNeutrino : Lepton
    {
        public ElectronNeutrino(double velocity,  Vector3D position) : base(velocity,position)
        {
            Velocity = velocity;
            Position = position;
            FeynmanSymbol = "Ve";
            Name = "Electron-Neutrino";
        }
        public ElectronNeutrino(double velocity) : base(velocity)
        {
            Velocity = velocity;
            FeynmanSymbol = "Ve";
            Name = "Electron-Neutrino";
        }
    }
}
