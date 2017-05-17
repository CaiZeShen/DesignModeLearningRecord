using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._22_Bridge {
    /// <summary>
    /// 手机N品牌
    /// </summary>
    class HandsetNBrand : HandsetBrand {
        public override void Run() {
            Console.Write("N品牌手机");
            handsetSoft.Run();
        }
    }
}
