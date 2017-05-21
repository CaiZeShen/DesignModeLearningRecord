using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._26_Flyweight {
    class User {
        private string name;

        public string Name { get { return name; } }

        public User (string name) {
            this.name = name;
        }

    }
}
