using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Particles
{
    public abstract class Lepton : Particle
    {
        public Lepton(double velocity, Vector3D position) : base(velocity, position)
        {
        }
        public Lepton(double velocity) :base(velocity)
        {              
        }
        public Lepton(double velocity, Vector3D position, double distance) : base(velocity, position, distance)
        {
        }
        public int LeptonNumber { get; protected set; }

       
    }
}
