using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "BMW";
            myCar.Model = "745li";
            myCar.Color = "Black";
            myCar.Year = 2005;

            printVehicleDetails(myCar);
            

            Truck mytruck = new Truck();

            mytruck.Make = "Ford";
            mytruck.Model = "F150";
            mytruck.Color = "White";
            mytruck.Year = 2012;
            mytruck.TowingCapacity = "12000 LBS";

            printVehicleDetails(mytruck);

            Console.ReadLine();   
        }
        
        private static void printVehicleDetails(Vehicle car1)
        {
            Console.WriteLine("Here are the Car's details: {0}", car1.FormatMe());    
        }

     abstract class Vehicle
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public string Color { get; set; }

            public abstract string FormatMe();

        }
    class Car : Vehicle
        {

            
            public override string FormatMe()
            {
                return String.Format("{0} - {1} - {2} - {3}", this.Make, this.Model, this.Color, this.Year);
            }
        }
        sealed class Truck : Vehicle
        {
            public string TowingCapacity { get; set; }

            public override string FormatMe()
            {
                return String.Format("{0} - {1} - {2} Towing Units - {3}", this.Make, this.Model, this.TowingCapacity, this.Year);
            }

        }

    }
}
