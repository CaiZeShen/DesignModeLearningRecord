using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._19_Composite {
    abstract class Company {
        public string Name { get; private set; }

        public Company(string name) {
            Name = name;
        }

        public abstract void Add(Company company);
        public abstract void Remove(Company company);
        public abstract void LineOfDuty();
        public virtual void Display(int death) {
            Console.WriteLine(new string('-', death) + Name);
        }
    }
}
