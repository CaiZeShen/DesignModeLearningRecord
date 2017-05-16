using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._21_Singleton {
    // 懒汉单例模式
    class Singleton2 {
        private static Singleton2 instance;
        private static Object lockO = new Object();

        public static Singleton2 Instance {
            get {
                // 双重锁定
                if (instance == null) {
                    lock (lockO) {
                        if (instance == null) {
                            instance = new Singleton2();
                        }
                    }
                }

                return instance;
            }
        }

        private Singleton2() { }
    }
}
