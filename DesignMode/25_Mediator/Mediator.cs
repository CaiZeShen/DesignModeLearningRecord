using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._25_Mediator {
    abstract class Mediator {
        public abstract void SendMessage(string message, Colleague colleague);
    }
}
