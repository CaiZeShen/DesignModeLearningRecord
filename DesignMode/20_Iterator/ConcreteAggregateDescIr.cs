using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._20_Iterator {
    class ConcreteAggregateDescIr :Iterator {
        private ConcreteAggregate aggregate;
        private int currentIndex;

        public ConcreteAggregateDescIr (ConcreteAggregate aggregate) {
            this.aggregate = aggregate;
            currentIndex = aggregate.Count;
        }

        public override object Current {
            get {
                return aggregate[currentIndex];
            }
        }

        public override bool Netx() {
            currentIndex--;
            return currentIndex < 0 ? false : true;
        }

        public override void Reset() {
            currentIndex = aggregate.Count;
        }
    }
}
