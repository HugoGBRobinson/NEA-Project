using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle
{
    public class Atom
    {
        public  int MassNumber { get; protected set; }
        public  List<Proton> AtomicNumber { get; protected set; }
        public  List<Neutron> NeutronNumber { get; protected set; }

        public Atom(List<Proton> atomicnumber,List<Neutron> neutronnumber, int massnumber)
        {
            MassNumber = massnumber;
            AtomicNumber = atomicnumber;
            NeutronNumber = neutronnumber;
        }
    }
}
