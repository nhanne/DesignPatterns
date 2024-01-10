using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public abstract class Prototype
    {
        public abstract Prototype Clone();
    }
    // How to use
    public class ConcretePrototype1 : Prototype {
        public override Prototype Clone()
        {
            return (Prototype) this.MemberwiseClone();
        }
    }
    public class ConcretePrototype2 : Prototype
    {
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
