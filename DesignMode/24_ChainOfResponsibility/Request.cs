using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._24_ChainOfResponsibility {
    class Request {
        public enum Type {
            Leave,      // 请假
            Raises,     // 加薪
        }
        public Type RequestType { get; set; }
        public string Content { get; set; }
        public int Number { get; set; }
    }
}
