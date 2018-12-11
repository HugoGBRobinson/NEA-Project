using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Particles
{
    class Pion_ : Meson
    {
        public Pion_(double velocity, Vector3D position): base (velocity,position)
        {
            Quark = new Up();

        }
        public Pion_(double velocity): base(velocity)
        {
                
        }


    }
}
