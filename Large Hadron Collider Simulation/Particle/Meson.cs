using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle
{
    public abstract class Meson : Baryon
    {
        public Quark Quark { get; protected set; } //Quark
        public Quark AntiQuark { get; protected set; }//Quark
        public int Strangness { get; protected set; }
        public int UnkonownPropety { get; protected set; }

    }
}
