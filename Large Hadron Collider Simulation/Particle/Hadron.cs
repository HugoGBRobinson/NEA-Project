using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particles
{
     public abstract class Hadron : Baryon
    {
        public Quark Quark1 { get; protected set; } //Quark
        public Quark Quark2 { get; protected set; }//Quark
        public Quark Quark3 { get; protected set; }//Quark


    }
}
