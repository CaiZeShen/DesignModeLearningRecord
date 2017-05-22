using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._28_Visitor {
    class ObjectStructure {
        private List<Element> elements = new List<Element>();

        public void Attach(Element element) {
            elements.Add(element);
        }

        public void Detach(Element element) {
            elements.Remove(element);
        }

        public void Accept(Visitor vistor) {
            foreach (Element ele in elements) {
                ele.Accept(vistor);
            }
        }
    }
}
