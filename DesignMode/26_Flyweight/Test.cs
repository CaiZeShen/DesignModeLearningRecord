using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._26_Flyweight {
    class Test {
        public static void Test1() {
            WebsiteFactory factory = new WebsiteFactory();

            Website blog1= factory.GetWebsite("博客");
            blog1.Use(new User("小菜"));

            Website blog2 = factory.GetWebsite("博客");
            blog2.Use(new User("大鸟"));

            Website blog3 = factory.GetWebsite("博客");
            blog3.Use(new User("大叔"));

            Website d1 = factory.GetWebsite("产品展示");
            d1.Use(new User("包总"));

            Website d2 = factory.GetWebsite("产品展示");
            d2.Use(new User("王总"));

            Console.WriteLine("网站实例数量："+factory.WebsiteCount);

        }
    }
}
