using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._23_Command {
    class Barbecuer {
        public void BakeMutton() {
            Console.WriteLine("烤羊肉");
        }

        public void BakeChickenWing() {
            Console.WriteLine("烤鸡翅");
        }
    }
}
