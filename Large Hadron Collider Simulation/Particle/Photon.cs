﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Media.Media3D;

namespace Particles
{
    public class Photon : Lepton
    {
        public Photon(double wavelength, double frequency) : base (3 * Math.Pow(10, 8))
        {
            Wavelength = wavelength;
            Frequency = frequency;
            FeynmanSymbol = "p";
            LifeSpan = 10000000000000000000; //To reresent infinaty 
        }

        public Photon() : base(3 * Math.Pow(10, 8))
        {
            LifeSpan = 10000000000000000000;
        }
        public Photon(double wavelength, double frequency, Vector3D position) : base(3 * Math.Pow(10, 8),position)
        {
            Wavelength = wavelength;
            Frequency = frequency;
            FeynmanSymbol = "p";
            LifeSpan = 10000000000000000000;
        }
        public Photon(double wavelength, double frequency, Vector3D position,double distance) : base(3 * Math.Pow(10, 8), position, distance)
        {
            Wavelength = wavelength;
            Frequency = frequency;
            FeynmanSymbol = "p";
            Distance = distance;
            LifeSpan = 10000000000000000000;
        }
    }
}
