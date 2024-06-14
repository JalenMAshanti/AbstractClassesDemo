using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties: Year, Make, and Model
             * Set the defaults of the properties to something generic in the Vehicle class
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             

             * Set the properties values with object initializer syntax
             */

            Car car = new Car(false, true) { Make = "Ferrari", Model = "250 GTO", Year = 1963};
            Motorcycle motorcycle = new Motorcycle(true, true) { Make = "Harley", Model = "T40", Year = 2025 };

            Vehicle car2 = new Car(true, false) {Make = "Doge", Model ="Viper GTS", Year = 1997 };
            Vehicle motorcycle2 = new Motorcycle(true, false) { Make = "Honda", Model = "Cbr500r", Year = 2022 };

            
            
            
            VehicleLot.vehicles.Add(car);
            VehicleLot.vehicles.Add(motorcycle);
            VehicleLot.vehicles.Add(car2);
            VehicleLot.vehicles.Add(motorcycle2);




            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */

            foreach (var vehicle in VehicleLot.vehicles) 
            { 
                Console.WriteLine(vehicle.Model);
                Console.WriteLine(vehicle.Make);
                Console.WriteLine(vehicle.Year);
                Console.WriteLine("-----------------");             
                      
            }

            // Call each of the drive methods for one car and one motorcycle

            car.DriveAbstract();
            car.DriveVirtual();

            motorcycle .DriveVirtual();
            motorcycle.DriveAbstract();

            #endregion            
            Console.ReadLine();
        }
    }
}
