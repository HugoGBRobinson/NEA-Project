using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Particles
{
   public abstract class Baryon : Particle
    {
        public int BaryonNumber { get; protected set; }
        public Baryon(double velocity,Vector3D position ) : base (velocity,position)
        {
                
        }
        public Baryon(double velocity, Vector3D position, double distance) : base(velocity, position, distance)
        {

        }

        public Baryon(double velocity) : base (velocity)
        {

        }
    }
}
