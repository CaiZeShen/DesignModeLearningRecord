using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._18_MementoMode {
    class RoleStateMemento {
        private int attack;
        private int defense;
        private int hp;
        private int mp;

        public int Attack { get { return attack; } }
        public int Defense { get { return defense; } }
        public int Hp { get { return hp; } }
        public int Mp { get { return mp; } }

        public RoleStateMemento(int attack,int defense,int hp,int mp) {
            this.attack = attack;
            this.defense = defense;
            this.hp = hp;
            this.mp = hp;
        }
    }
}
