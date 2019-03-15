using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Particles  
{
   public abstract  class Particle
    {
        public double RestMass { get;  protected set; }
        public int RelativeCharge { get; protected set; }
        public double Velocity { get;  protected set; } 
        public string FeynmanSymbol { get; protected set; }
        public Vector3D Position { get;  set; }
        public double Wavelength { get; protected set; }
        public double Frequency { get; protected set; }
        public double LifeSpan { get; protected set; }
        public double Distance { get; protected set; }
        public double Charge { get; protected set; }
        public string Name { get; protected set; }

        public Particle(double velocity, Vector3D position)
        {
            Velocity = velocity;
            Position = position;
        }
        public Particle(double velocity)
        {
            Velocity = velocity;
        }
        public Particle(double velocity, Vector3D position, double distance)
        {
            Velocity = velocity;
            Position = position;
            Distance = distance;
        }




    }
}
