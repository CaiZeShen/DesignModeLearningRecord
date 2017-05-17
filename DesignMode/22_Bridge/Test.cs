using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._22_Bridge {
    class Test {
        public static void Test1() {
            HandsetBrand hb = new HandsetMBrand();
            hb.SetSoft(new HandsetGame());
            hb.Run();

            hb.SetSoft(new HandsetAdressList());
            hb.Run();

            hb = new HandsetNBrand();
            hb.SetSoft(new HandsetGame());
            hb.Run();

            hb.SetSoft(new HandsetAdressList());
            hb.Run();
        }
    }
}
