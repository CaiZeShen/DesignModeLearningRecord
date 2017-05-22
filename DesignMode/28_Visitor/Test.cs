using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._28_Visitor {
    class Test {
        public static void Test1() {
            ObjectStructure os = new ObjectStructure();
            os.Attach(new ConcreteElementA());
            os.Attach(new ConcreteElementB());

            Visitor v1 = new ConcreteVisitor1();
            Visitor v2 = new ConcreteVisitor2();

            os.Accept(v1);
            os.Accept(v2);
        }
    }
}
