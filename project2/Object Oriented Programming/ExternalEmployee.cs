using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    public class ExternalEmployee:company
    {
        public int EmpId { get; set; }

        public string EmpName { get; set; }

        public double EmpSalary { get; set; }

        public ExternalEmployee(int empId,string empName,double empSalary,int companyId,
            string companyName,string location):base(companyId,companyName,location)
        {
            EmpId = empId;
            EmpName = empName;
            EmpSalary = empSalary;
        
        }
        public void ExternalEmployeeDetails()
        {
            Console.WriteLine($"EmpName:{EmpName} and EmpSalary:{EmpSalary}");
        }
    }
}
