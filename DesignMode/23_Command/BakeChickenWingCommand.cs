using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._23_Command {
    class BakeChickenWingCommand : Command {
        public BakeChickenWingCommand(Barbecuer receiver) : base(receiver) {
        }

        public override void Execute() {
            receiver.BakeChickenWing();
        }

        public override string ToString() {
            return "烤鸡翅命令";
        }
    }
}
