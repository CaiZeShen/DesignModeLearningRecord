using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._25_Mediator {
    abstract class Colleague {
        protected Mediator mediator;
        
        public Colleague(Mediator mediator) {
            this.mediator = mediator;
        }

        public void SendMessage(string message) {
            mediator.SendMessage(message, this);
        }

        public abstract void GetNotification(string message);
    }
}
