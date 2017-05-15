using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._20_Iterator {
    class ConcreteAggregate : Aggregate {
        private List<object> objectList=new List<object>();

        public override Iterator CreateIterator() {
            //Iterator ret = new ConcreteAggregateIr(this);
            Iterator ret = new ConcreteAggregateDescIr(this);
            return ret;
        }

        public Object this[int index] {
            get {
                return objectList[index];
            }
            set {
                objectList.Insert(index, value);
            }
        }

        public int Count {
            get {
                return objectList.Count;
            }
        }
    }
}
