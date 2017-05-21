using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._27_Interpreter {
    class Test {
        public static void Test1() {
            PlayContext context = new PlayContext();
            // 音乐 上海滩
            Console.WriteLine("上海滩:");
            context.Text = "T 500 O 2 E 0.5 G 0.5 A 3 E 0.5 G 0.5 D 3 E 0.5 G 0.5 A 0.5 ";
            Expression expression = null;
            try {
                while (context.Text.Length>0) {
                    string str = context.Text.Substring(0, 1);
                    switch (str) {
                        case "O":
                            expression = new Scale();
                            break;
                        case "T":
                            expression = new Speed();
                            break;
                        case "C":
                        case "D":
                        case "E":
                        case "F":
                        case "G":
                        case "A":
                        case "B":
                        case "P":
                            expression = new Note();
                            break;
                    }
                    expression.Interpret(context);
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
