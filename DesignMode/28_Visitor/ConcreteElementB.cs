using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._28_Visitor {
    class ConcreteElementB : Element {
        public override void Accept(Visitor visitor) {
            visitor.VisitconcreteElementB(this);
        }
    }
}
