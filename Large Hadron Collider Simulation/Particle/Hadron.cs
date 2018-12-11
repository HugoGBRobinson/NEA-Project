using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Particles
{
     public abstract class Hadron : Baryon 
    {
        public Quark Quark1 { get; protected set; } //Quark
        public Quark Quark2 { get; protected set; }//Quark
        public Quark Quark3 { get; protected set; }//Quark
        public Hadron(double velocity, Vector3D position, double distance) : base (velocity, position, distance)
        {
                
        }
        public Hadron(double velocity, Vector3D position) : base(velocity, position)
        {

        }
        public Hadron(double velocity) : base(velocity)
        {

        }

    }
}
