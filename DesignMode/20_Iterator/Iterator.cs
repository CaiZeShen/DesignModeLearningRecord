using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._20_Iterator {
    public abstract class Iterator {
        public abstract bool Netx();
        public abstract Object Current { get; }
        public abstract void Reset();
    }
}
