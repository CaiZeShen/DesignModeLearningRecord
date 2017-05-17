using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._22_Bridge {
    /// <summary>
    /// 手机品牌类
    /// </summary>
   abstract class HandsetBrand {
        protected HandsetSoft handsetSoft;

        public void SetSoft(HandsetSoft soft) {
            this.handsetSoft = soft;
        }

        public abstract void Run();
    }
}
