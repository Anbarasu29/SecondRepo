using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLYMORPHISM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// OVERLOADING

            //Calculator calculator = new Calculator();
            //calculator.Add(15, 20);
            //calculator.Add(10,20,30);
            //calculator.Subraction(50,30);

            // OVERRIDING

            //Bus_OVERRIDING bus = new Bus_OVERRIDING(10);
            //bus.BusDetails();


            SmallBus_OVERRIDING smallbus = new SmallBus_OVERRIDING(5);
            smallbus.BusDetails();
            smallbus.BusCapacity();

            //Bus_OVERRIDING smallbus = new SmallBus_OVERRIDING(8);
            //smallbus.BusDetails();

            //MiniBus bus = new MiniBus(16);
            //bus.BusDetails();



        }
    }
}
