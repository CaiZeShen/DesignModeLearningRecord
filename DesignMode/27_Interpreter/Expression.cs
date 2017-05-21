using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._27_Interpreter {
    /// <summary>
    /// 表达式基类
    /// </summary>
    abstract class Expression {

        public void Interpret(PlayContext context) {
            if (context.Text.Length==0) {
                return;
            } else {
                string playKey = context.Text.Substring(0, 1);
                context.Text = context.Text.Substring(2);
                double playValue = Convert.ToDouble(context.Text.Substring(0, context.Text.IndexOf(" ")));
                context.Text = context.Text.Substring(context.Text.IndexOf(" ")+1);

                Excute(playKey, playValue);
            }
        }

        public abstract void Excute(string key, double value);

    }
}
