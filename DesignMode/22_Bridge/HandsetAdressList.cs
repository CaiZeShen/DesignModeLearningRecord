using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._22_Bridge {
    /// <summary>
    /// 手机通讯录
    /// </summary>
    class HandsetAdressList : HandsetSoft {
        public override void Run() {
            Console.WriteLine("运行手机通讯录");
        }
    }
}
