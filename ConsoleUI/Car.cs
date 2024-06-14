using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
         public bool IsManual { get; set; }
         public bool IsTwoSeater { get; set; }

        public Car() 
        { 
        
        }

        public Car(bool isManual, bool isTwoSeater) 
        { 
           IsManual = isManual;
           IsTwoSeater = isTwoSeater;        
        }

        public override void DriveAbstract()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Driving a Car");
        }
    }
}
