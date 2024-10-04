using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(102,"ANSARI","BOSS","Google","Search");
            employee.CompanyDetails();
            employee.EmployeeSalaryDetails();
            employee.Salary();
        }
    }
}
