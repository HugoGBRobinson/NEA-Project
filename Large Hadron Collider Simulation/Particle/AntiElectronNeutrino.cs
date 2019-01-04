using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Particles
{
    public class AntiElectronNeutrino : Lepton, AntiParticleInterface.IAntiparticle<ElectronNeutrino>
    {
        public AntiElectronNeutrino(double velocity, Vector3D position) : base(velocity, position)
        {
            Velocity = velocity;
            Position = position;
            FeynmanSymbol = "Ve";
        }
        public AntiElectronNeutrino(double velocity) : base(velocity)
        {
            Velocity = velocity;
            FeynmanSymbol = "Ve";
        }
    }
}
