using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLYMORPHISM
{
    public class SmallBus_OVERRIDING:Bus_OVERRIDING
    {
        public SmallBus_OVERRIDING(int wheel):base(wheel)
        { 
        
        }

        public new void BusCapacity()
        {
            Console.WriteLine($"bus capacity is : 20");
        }

        // sealed -using this can not using multilevel inheritence
        // public sealed override void BusDEtails()
        public override void BusDetails()
        {
            Console.WriteLine($"This smallbus have {Wheel} wheels");
        }

    }
}
