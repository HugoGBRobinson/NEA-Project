﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle
{
    public class Top : Quark
    {
        public bool ClassCompleted { get; set; }
        public Top()
        {
            ClassCompleted = false;
        }
    }
}
