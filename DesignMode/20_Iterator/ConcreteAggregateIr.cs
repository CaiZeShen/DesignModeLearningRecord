using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._20_Iterator {
    class ConcreteAggregateIr : Iterator {
        private ConcreteAggregate aggregate;
        private int currentIndex;

        public ConcreteAggregateIr(ConcreteAggregate aggregate) {
            this.aggregate = aggregate;
            currentIndex = -1;
        }

        public override object Current {
            get {
                return aggregate[currentIndex];
            }
        }

        public override bool Netx() {
            currentIndex++;
            return currentIndex < aggregate.Count ? true : false;
        }

        public override void Reset() {
            currentIndex = -1;
        }
    }
}
