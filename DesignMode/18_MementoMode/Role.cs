using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._18_MementoMode {
    class Role {
        public int Attcak { get; set; }
        public int Defense { get; set; }
        public int Hp { get; set; }
        public int Mp { get; set; }


        public Role() {
            Attcak = 10;
            Defense = 5;
            Hp = 100;
            Mp = 100;
        }

        public void Figth() {
            Attcak = 10;
            Defense = 5;
            Hp = 0;
            Mp = 5;
        }

        public void ShowState() {
            Console.Write(" 攻击力:{0}\n 防御力:{1}\n 生命:{2}\n 魔法:{3}\n\n",Attcak,Defense,Hp,Mp);
        }

        public RoleStateMemento SaveState() {
            return new RoleStateMemento(Attcak,Defense,Hp,Mp);
        }

        public void ReadMemento(RoleStateMemento memento) {
            Attcak = memento.Attack;
            Defense = memento.Defense;
            Hp = memento.Hp;
            Mp = memento.Mp;
        }
    }
}
