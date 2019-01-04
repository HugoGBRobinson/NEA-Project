using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particles
{
    public class ElementNames
    {
        public ElementNames()
        {

        }

        public static string FindNameOfElement(int AtomicNumber)
        {
            var a = NamesOFElements();
            int Count = 0;
            foreach (var item in a.Keys)
            {
                if (item == AtomicNumber)
                {
                    return a.ElementAt(Count).Value;
                }
                else
                {
                    Count += 1;
                }

            }
            return null;
        }


        public static  Dictionary<int,string> NamesOFElements()
        {
            //Dictionary used for finding element names to be changed later 

            var  elements = new Dictionary<int, String>();
            elements.Add(1, "Hydrogen");
            elements.Add(2, "Helium");
            elements.Add(3, "Lithium");
            elements.Add(4, "Beryllium");
            elements.Add(5, "Boron");
            elements.Add(6, "Carbon");
            elements.Add(7, "Nitrogen");
            elements.Add(8, "Oxygen");
            elements.Add(9, "Fluorine");
            elements.Add(10, "Neon");
            elements.Add(11, "Sodium");
            elements.Add(12, "Magnesium");
            elements.Add(13, "Aluminium");
            elements.Add(14, "Silicon");
            elements.Add(15, "Phosphorus");
            elements.Add(16, "Sulfur");
            elements.Add(17, "Chlorine");
            elements.Add(18, "Argon");
            elements.Add(19, "Potassium");
            elements.Add(20, "Calcium");
            elements.Add(21, "Scandium");
            
            return elements;
        }


    }
}
