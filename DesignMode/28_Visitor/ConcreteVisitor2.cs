using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._28_Visitor {
    class ConcreteVisitor2 : Visitor {
        public override void VisitConcreteElementA(ConcreteElementA elementA) {
            Console.WriteLine("{0}被{1}访问", elementA.GetType().Name, this.GetType().Name);
        }

        public override void VisitconcreteElementB(ConcreteElementB elementB) {
            Console.WriteLine("{0}被{1}访问", elementB.GetType().Name, this.GetType().Name);
        }
    }
}
