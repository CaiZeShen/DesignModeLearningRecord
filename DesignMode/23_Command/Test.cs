using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._23_Command {
    class Test {
        public static void Test1() {
            Barbecuer boy = new Barbecuer();
            Waiter girl = new Waiter();
            Command command1 = new BakeChickenWingCommand(boy);
            Command command2 = new BakeMuttonCommand(boy);
            Command command3 = new BakeMuttonCommand(boy);

            girl.AddOrder(command1);
            girl.AddOrder(command2);
            girl.AddOrder(command3);
            girl.RemoveOrder(command3);

            girl.Notify();

        }
    }
}
