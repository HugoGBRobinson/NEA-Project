﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle
{
    public class Strange : Quark
    {
        public bool ClassCompleted { get; set; }
        public Strange()
        {
            Charge = -1 / 3;
            Strangeness = -1;
            ClassCompleted = true;
        }
    }
}