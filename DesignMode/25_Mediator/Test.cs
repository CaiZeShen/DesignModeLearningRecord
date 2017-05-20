using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._25_Mediator {
    class Test {
        public static void Test1() {
            ConcreteMediator m1 = new ConcreteMediator();
            ConcreteColleague1 c1 = new ConcreteColleague1(m1);
            ConcreteColleague2 c2 = new ConcreteColleague2(m1);

            m1.Colleague1 = c1;
            m1.Colleague2 = c2;

            c1.SendMessage("吃饭没");
            c2.SendMessage("额");
        }
    }
}
