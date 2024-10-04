using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    //Parent class=Bass class=Super class
    public class company
    {
        //members-->class inside int and stings are called members,-->cut and paste the company class file

        // {get;set;}-->Getter and Setter
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Location { get; set; }




        // * Constructor and Multiple Constructor-->above one constructore is called multiple constructore
        // * constructore
        public company(int companyid, string companyname, string location)
        {
            CompanyId = companyid;
            CompanyName = companyname;
            Location = location;
        }

        public void displaycompanydetails()
        {
            Console.WriteLine($"CompanyId:{CompanyId} and CompanyName:{CompanyName} and Location:{Location}");
        }
        public void displaydata()
        {
            Console.WriteLine($" Id:{CompanyId} and Name:{CompanyName}");
        }


    }
}
