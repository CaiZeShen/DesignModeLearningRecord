using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._23_Command {
    class Waiter {
        private IList<Command> commandList=new List<Command>();

        public void AddOrder(Command command) {
            if (command.GetType() == typeof(BakeChickenWingCommand)) {
                Console.WriteLine("服务员：鸡翅没有了");
            } else {
                Console.WriteLine("增加订单："+ command.ToString()+" 时间："+DateTime.Now);
                commandList.Add(command);
            }
            
        }

        public void RemoveOrder(Command command) {
            Console.WriteLine("取消订单：" + command.ToString() + " 时间：" + DateTime.Now);
            commandList.Remove(command);
        }

        public void Notify() {
            foreach (Command command in commandList) {
                command.Execute();
            }
        }
    }
}
