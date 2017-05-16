using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._21_Singleton {
    /// <summary>
    /// 饿汉单例模式
    /// </summary>
    class Singleton1 {
        private static readonly Singleton1 instance=new Singleton1();

        public static Singleton1 Instance {
            get { return instance; }
        }

        private Singleton1() { }
    }
}
