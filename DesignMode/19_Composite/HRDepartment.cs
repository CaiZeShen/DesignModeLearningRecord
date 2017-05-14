using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._19_Composite {
    /// <summary>
    /// 人事部
    /// </summary>
    class HRDepartment : Company {
        public HRDepartment(string name) : base(name) {
        }

        public override void Add(Company company) {
        }

        public override void LineOfDuty() {
            Console.WriteLine(Name+" 人员招聘与培训管理。");
        }

        public override void Remove(Company company) {
        }
    }
}
