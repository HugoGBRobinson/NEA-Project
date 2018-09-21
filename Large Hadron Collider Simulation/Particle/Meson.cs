using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle
{
    public abstract class Meson : Baryon
    {
        public Quark Quark { get; set; } //Quark
        public Quark AntiQuark { get; set; }//Quark
        public int Strangness { get; set; }
        public int UnkonownPropety { get; set; }

    }
}
