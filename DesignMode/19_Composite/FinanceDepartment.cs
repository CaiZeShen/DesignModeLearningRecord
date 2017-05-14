using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._19_Composite {
    /// <summary>
    /// 财务部
    /// </summary>
    class FinanceDepartment : Company {
        public FinanceDepartment(string name) : base(name) {
        }

        public override void Add(Company company) {
        }

        public override void LineOfDuty() {
            Console.WriteLine(Name + " 财政收支管理");
        }

        public override void Remove(Company company) {
        }
    }
}
