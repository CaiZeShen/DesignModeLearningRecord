using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._22_Bridge {
    /// <summary>
    /// 手机M品牌
    /// </summary>
    class HandsetMBrand:HandsetBrand {
        public override void Run() {
            Console.Write("M品牌手机");
            handsetSoft.Run();
        }
    }
}
