using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._20_Iterator {
    class Test {

        public static void Test1() {
            ConcreteAggregate passengers = new ConcreteAggregate();
            passengers[0] = "大鸟";
            passengers[1] = "小菜";
            passengers[2] = "歪果仁";
            passengers[3] = "美女";
            passengers[4] = "小偷";

            Iterator ticketSeller= passengers.CreateIterator();
            while (ticketSeller.Netx()) {
                Console.WriteLine(ticketSeller.Current+"请买票");
            }
        }
       
    }
}
