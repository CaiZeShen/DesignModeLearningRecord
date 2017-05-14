using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._19_Composite {
    class Test {
        public static void Test1() {
            Company rootCompany = new ConcreteCompany("汕头总公司");
            rootCompany.Add(new HRDepartment("总公司人力部"));
            rootCompany.Add(new FinanceDepartment("总公司财务部"));

            Company company1 = new ConcreteCompany("深圳分公司");
            company1.Add(new HRDepartment("深圳分公司人力部"));
            company1.Add(new FinanceDepartment("深圳分公司财务部"));
            rootCompany.Add(company1);

            Company agency = new ConcreteCompany("罗湖办事处");
            agency.Add(new HRDepartment("罗湖办事处人力部"));
            agency.Add(new FinanceDepartment("罗湖办事处财务部"));
            company1.Add(agency);

            Company company2 = new ConcreteCompany("南京分公司");
            company2.Add(new HRDepartment("南京分公司人力部"));
            company2.Add(new FinanceDepartment("南京分公司人力部"));
            rootCompany.Add(company2);

            Console.WriteLine("公司结构：\n");
            rootCompany.Display(1);

            Console.WriteLine("\n各部门职责：\n");
            rootCompany.LineOfDuty();
        }
    }
}
