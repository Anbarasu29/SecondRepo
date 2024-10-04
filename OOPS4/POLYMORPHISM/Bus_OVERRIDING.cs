using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLYMORPHISM
{
    public class Bus_OVERRIDING
    {
        public int Wheel { get; set; }

        public Bus_OVERRIDING(int wheel)
        {
            Wheel = wheel;
        }

        public void BusCapacity()
        {
            Console.WriteLine($"bus capacity is : 40");
        }

        public virtual void BusDetails()
        {
            Console.WriteLine($"This bus have {Wheel} wheels");
        }
    }
}
