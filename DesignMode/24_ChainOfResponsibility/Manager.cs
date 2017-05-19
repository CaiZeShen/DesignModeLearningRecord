using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._24_ChainOfResponsibility {
    abstract class Manager {
        protected string name;
        protected Manager superior;

        public Manager(string name) {
            this.name = name;
        }

        public void SetSuperior(Manager superior) {
            this.superior = superior;
        }

        public abstract void HandleRequest(Request request);
    }
}
