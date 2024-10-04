        using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLYMORPHISM
{
    public class MiniBus : SmallBus_OVERRIDING
    {
        public MiniBus(int wheel) : base(wheel)
        { 

        }
        public override void BusDetails()
        {
            Console.WriteLine($"This minibus have {Wheel} wheels");
        }


    }
}
