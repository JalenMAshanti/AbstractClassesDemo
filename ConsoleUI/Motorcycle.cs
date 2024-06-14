using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; }
        public bool HasThreeWheels { get; set; }

        public Motorcycle() 
        { 
        }

        public Motorcycle(bool hasSideCart, bool hasThreeWheels) 
        { 
           HasSideCart = hasSideCart;
           HasThreeWheels = hasThreeWheels;
        }

        public override void DriveAbstract()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Driving a Motorcycle");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Driving a Motorcyle.. but virutally");
        }
    }
}
