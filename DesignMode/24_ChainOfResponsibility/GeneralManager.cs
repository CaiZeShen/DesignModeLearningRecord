using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._24_ChainOfResponsibility {
    /// <summary>
    ///  总经理
    /// </summary>
    class GeneralManager : Manager {
        public GeneralManager(string name) : base(name) {
        }

        public override void HandleRequest(Request request) {
            if (request.RequestType == Request.Type.Leave) {
                Console.WriteLine(string.Format("{0}批准了{1}{2}天的请求", name,request.Content,request.Number));
            } else if (request.RequestType==Request.Type.Raises) {
                if (request.Number <= 500) {
                    Console.WriteLine(string.Format("{0}批准了{1}{2}块的请求", name, request.Content, request.Number));
                } else {
                    Console.WriteLine(string.Format("{0}拒绝了{1}{2}块的请求", name, request.Content, request.Number));
                }
            }
        }
    }
}
