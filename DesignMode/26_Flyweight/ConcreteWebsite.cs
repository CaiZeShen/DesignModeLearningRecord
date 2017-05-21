using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._26_Flyweight {
    class ConcreteWebsite :Website{
        private string name;

        public string Name { get { return name; } }

        public ConcreteWebsite(string name) {
            this.name = name;
        }

        public override void Use(User user) {
            Console.WriteLine("网站分类："+name+" 用户名："+user.Name);
        }
    }
}
