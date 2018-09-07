using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle
{
     public abstract class Hadron : Baryon
    {
        public Quark Quark1 { get; set; } //Quark
        public Quark Quark2 { get; set; }//Quark
        public Quark Quark3 { get; set; }//Quark


    }
}
