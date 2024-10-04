using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENCAPSULATION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student(02,"Prasath");
            Student student = new Student();
            student.Id = 03;
            student.Name = "ANSARI";

            student.StudentDetails();


        }
    }
}
