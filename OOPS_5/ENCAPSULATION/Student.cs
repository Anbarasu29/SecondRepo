using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENCAPSULATION
{
    public class Student
    {

        private int id { get; set; }

        private string name { get; set; }


        public int Id 
        {
            get 
            {
                return id;
            }
            set 
            {
                id = value;
            }
        }
        public string Name
        {
            get 
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        //public Student(int id,string name)
        //{
        //    Id = id;
        //    Name = name;
        //}

        public void StudentDetails()
        {
            Console.WriteLine($"Id:{Id} and Name:{Name}");
        }




    }
}
