using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._20_Iterator {
    public abstract class Aggregate {
        public abstract Iterator CreateIterator();
    }
}
