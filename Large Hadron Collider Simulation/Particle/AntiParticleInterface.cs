using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle
{
    public class AntiParticleInterface
    {
        public interface IAntiparticle<T> where T : Particle { }

    }
}
