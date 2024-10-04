using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Heirachical Inheritence-more than 1 child
             * ex: company-parent
             * employee-child
             * externalemployee-child
             * 
             * 
             * 
             * 
             */








            //////                   OBJECT ORIENTED PROGRAMMING
            ////// * Class and Object
            ////// * Constructor
            ////// * Multiple Constructor
            ////// * Getter and Setter

            ////// * Class and Object
            //////(class name) (object name) = (new-key) (class name ();)
            ////company dataobj = new company(1, "insta", "ireland");
            ////dataobj.displaycompanydetails();


            ////company nameobj = new company(2, "gb", "pakistan");
            ////nameobj.displaycompanydetails();

            //Employee googleemployee = new Employee(101, "smith", "chennai", 40000, 1, "facebook", "india");
            //// Base class function
            //// Parent company function
            //googleemployee.displaycompanydetails();
            ////Derived class function
            ////Child employee function
            //googleemployee.EmployeeCompanyDetails();
            //googleemployee.EmployeeDetails();
            ////Interface
            //googleemployee.SalaryDetails();

            //Boss appleboss = new Boss(02, "sam", "kallakurichi", 80000, 5, "apple", "america");
            ////Company
            //appleboss.displaycompanydetails();
            ////Parent Employee
            //appleboss.EmployeeCompanyDetails();
            //appleboss.EmployeeDetails();
            ////Interface
            //appleboss.SalaryDetails();

            ExternalEmployee externalemployee = new ExternalEmployee(1002,"ansari",10000,102,"infosys","chennai");
            externalemployee.displaycompanydetails();
            externalemployee.ExternalEmployeeDetails();
        }
    }
}