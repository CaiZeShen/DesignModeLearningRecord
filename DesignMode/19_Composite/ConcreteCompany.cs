using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._19_Composite {
    class ConcreteCompany : Company {
        private List<Company> childrenCompanys;

        public ConcreteCompany(string name) : base(name) {
            childrenCompanys = new List<Company>();
        }

        public override void Add(Company company) {
            childrenCompanys.Add(company);
        }

        public override void Display(int death) {
           Console.WriteLine(new string('-',death)+Name);

            foreach (Company children in childrenCompanys) {
                children.Display(death + 2);
            }
        }

        public override void LineOfDuty() {
            foreach (Company children in childrenCompanys) {
                children.LineOfDuty();
            }
        }

        public override void Remove(Company company) {
            childrenCompanys.Remove(company);
        }
    }
}
