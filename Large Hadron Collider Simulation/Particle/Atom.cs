using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quadrivia.FunctionalLibrary;

namespace Particles
{
    public class Atom
    {
        public  int MassNumber { get; protected set; }
        public  FList<Proton> AtomicNumberList { get; protected set; }
        public  FList<Neutron> NeutronNumberList { get; protected set; }
        public int AtomicNumber { get; protected set; }
        public string Name { get; protected set; }

        public Atom(FList<Proton> atomicnumberlist,FList<Neutron> neutronnumberlist)
        {
            AtomicNumberList = atomicnumberlist;
            NeutronNumberList = neutronnumberlist;
            MassNumber =   FList.Length(NeutronNumberList) +  FList.Length(AtomicNumberList);
            AtomicNumber = FList.Length(AtomicNumberList);
            Name = ElementNames.FindNameOfElement(AtomicNumber);
        }
    }

    //public class Atom
    //{
    //    public int MassNumber { get; protected set; }
    //    public FList<Proton> AtomicNumberList { get; protected set; }
    //    public FList<Neutron> NeutronNumberList { get; protected set; }
    //    public int AtomicNumber { get; protected set; }

    //    public Atom(FList<Proton> atomicnumberlist, FList<Neutron> neutronnumberlist, int i)
    //    {
    //        AtomicNumberList = atomicnumberlist;
    //        NeutronNumberList = neutronnumberlist;
    //        MassNumber = FList.Length(NeutronNumberList) - FList.Length(AtomicNumberList);
    //        AtomicNumber = FList.Length(AtomicNumberList);
    //    }
    }
