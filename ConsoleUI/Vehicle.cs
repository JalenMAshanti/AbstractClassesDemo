using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int Year { get; set; } = 0000;
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "F150";


        public abstract void DriveAbstract();

        public virtual void DriveVirtual() 
        {
            Console.WriteLine("Driving a Vehicle");
        
        }
        


    }
}
