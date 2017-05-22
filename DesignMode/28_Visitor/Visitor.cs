using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._28_Visitor {
    abstract class Visitor {
        public abstract void VisitConcreteElementA(ConcreteElementA elementA);
        public abstract void VisitconcreteElementB(ConcreteElementB elementB);
    }
}
