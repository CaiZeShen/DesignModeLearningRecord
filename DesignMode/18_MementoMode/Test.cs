using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._18_MementoMode {
    class Test {
       public static void Test1() {
            Role player = new Role();
            player.ShowState();

            // 保存记录
            RoleStateCaretaker caretaker = new RoleStateCaretaker();
            caretaker.Memento = player.SaveState();

            player.Figth();
            player.ShowState();

            // 恢复记录
            player.ReadMemento(caretaker.Memento);
            player.ShowState();
        }
    }
}
