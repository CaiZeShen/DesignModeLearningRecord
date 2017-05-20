using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._25_Mediator {
    
    class ConcreteMediator :Mediator{
        private ConcreteColleague1 colleague1;
        private ConcreteColleague2 colleague2;

        public ConcreteColleague1 Colleague1 { set { colleague1 = value; } }
        public ConcreteColleague2 Colleague2 { set { colleague2 = value; } }

        public override void SendMessage(string message, Colleague colleague) {
            if (colleague == colleague1) {
                colleague2.GetNotification(message);
            }else if(colleague == colleague2) {
                colleague1.GetNotification(message);
            }
        }
    }
}
