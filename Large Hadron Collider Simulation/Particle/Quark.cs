﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle
{
    public abstract class Quark
    {
        public double Charge { get; protected set; }
        public double Strangeness { get; protected set; }
    }
}
