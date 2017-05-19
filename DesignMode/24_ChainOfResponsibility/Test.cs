using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._24_ChainOfResponsibility {
    class Test {
        public static void Test1() {
            Manager m1 = new GeneralManager("王总经理");
            Manager m2 = new Majordomo("李总监");
            Manager m3 = new CommonManager("谢经理");
            m3.SetSuperior(m2);
            m2.SetSuperior(m1);

            Request q1 = new Request() { RequestType = Request.Type.Leave, Number = 3, Content = "小蔡请假" };
            Request q2 = new Request() { RequestType = Request.Type.Leave, Number = 5, Content = "小蔡请假" };
            Request q3 = new Request() { RequestType = Request.Type.Raises, Number = 500, Content = "小蔡申请加薪" };
            Request q4 = new Request() { RequestType = Request.Type.Raises, Number = 1000, Content = "小蔡申请加薪" };

            m3.HandleRequest(q1);
            m3.HandleRequest(q2);
            m3.HandleRequest(q3);
            m3.HandleRequest(q4);
        }
    }
}
