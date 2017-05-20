using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._25_Mediator {
    class ConcreteColleague1 : Colleague {
        public ConcreteColleague1(Mediator mediator) : base(mediator) {
        }

        public override void GetNotification(string message) {
            Console.WriteLine("同事1接收到消息："+message);
        }
    }
}
