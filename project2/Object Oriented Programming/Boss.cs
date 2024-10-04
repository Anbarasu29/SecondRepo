using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    public class Boss : Employee
    {
        public Boss(int employeeid,string employeeName,string address,double salary,int companyId,
            string companyName,string location) : base(employeeid,employeeName,address,salary,companyId,
        companyName,location)
        {

        
        }
    }
}
