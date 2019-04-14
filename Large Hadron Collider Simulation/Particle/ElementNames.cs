using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quadrivia.FunctionalLibrary;

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

            //return FList.New("Hydrogen", "Helium")  Need to change the dictionary to an flist and then create an element at function to find the name bassed on its atomic number 


            var  elements = new Dictionary<int, String>();
            elements.Add(0, "Neutron");
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
            elements.Add(22, "Titanium");
            elements.Add(23, "Vanadium");
            elements.Add(24, "Chromium");
            elements.Add(25, "Manganese");
            elements.Add(26, "Iron");
            elements.Add(27, "Cobalt");
            elements.Add(28, "Nickel");
            elements.Add(29, "Copper");
            elements.Add(30, "Zinc");
            elements.Add(31, "Gallium");
            elements.Add(32, "Germanium");
            elements.Add(33, "Arsenic");
            elements.Add(34, "Selenium");
            elements.Add(35, "Bromine");
            elements.Add(36, "Krypton");
            elements.Add(37, "Rubidium");
            elements.Add(38, "Strontium");
            elements.Add(39, "Yttrium");
            elements.Add(40, "Zirconium");
            elements.Add(41, "Niobium");
            elements.Add(42, "Molybdenum");
            elements.Add(43, "Technetium");
            elements.Add(44, "Ruthenium");
            elements.Add(45, "Rhodium");
            elements.Add(46, "Palladium");
            elements.Add(47, "Silver");
            elements.Add(48, "Cadmium");
            elements.Add(49, "Indium");
            elements.Add(50, "Tin");
            elements.Add(51, "Antimony");
            elements.Add(52, "Tellurium");
            elements.Add(53, "Iodine");
            elements.Add(54, "Xenon");
            elements.Add(55, "Caesium");
            elements.Add(56, "Barium");
            elements.Add(57, "Lanthanum");
            elements.Add(58, "Cerium");
            elements.Add(59, "Praseodymium");
            elements.Add(60, "Neodymium");
            elements.Add(61, "Promethium");
            elements.Add(62, "Samarium");
            elements.Add(63, "Europium");
            elements.Add(64, "Gadolinium");
            elements.Add(65, "Terbium");
            elements.Add(66, "Dysprosium");
            elements.Add(67, "Holmium");
            elements.Add(68, "Erbium");
            elements.Add(69, "Thulium");
            elements.Add(70, "Ytterbium");
            elements.Add(71, "Lutetium");
            elements.Add(72, "Hafnium");
            elements.Add(73, "Tantalum");
            elements.Add(74, "Tungsten");
            elements.Add(75, "Rhenium");
            elements.Add(76, "Osmium");
            elements.Add(77, "Iridium");
            elements.Add(78, "Platinum");
            elements.Add(79, "Gold");
            elements.Add(80, "Mercury");
            elements.Add(81, "Thallium");
            elements.Add(82, "Lead");
            elements.Add(83, "Bismuth");
            elements.Add(84, "Polonium");
            elements.Add(85, "Astatine");
            elements.Add(86, "Radon");
            elements.Add(87, "Francium");
            elements.Add(88, "Radium");
            elements.Add(89, "Actinium");
            elements.Add(90, "Thorium");
            elements.Add(91, "Protactinium");
            elements.Add(92, "Uranium");
            elements.Add(93, "Neptunium");
            elements.Add(94, "Plutonium");
            elements.Add(95, "Americium");
            elements.Add(96, "Curium");
            elements.Add(97, "Berkelium");
            elements.Add(98, "Californium");
            elements.Add(99, "Einsteinium");
            elements.Add(100, "Fermium");
            elements.Add(101, "Mendelevium");
            elements.Add(102, "Nobelium");
            elements.Add(103, "Lawrencium");
            elements.Add(104, "Rutherfordium");
            elements.Add(105, "Dubnium");
            elements.Add(106, "Seaborgium");
            elements.Add(107, "Bohrium");
            elements.Add(108, "Hassium");
            elements.Add(109, "Meitnerium");
            elements.Add(110, "Darmstadtium");
            elements.Add(111, "Roentgenium");
            elements.Add(112, "Copernicium");
            elements.Add(113, "Nihonium");
            elements.Add(114, "Flerovium");
            elements.Add(115, "Moscovium");
            elements.Add(116, "Livermorium");
            elements.Add(117, "Tennessine");
            elements.Add(118, "Oganesson");

            return elements;
        }


    }
}
