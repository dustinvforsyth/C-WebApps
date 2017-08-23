using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car mycar = new Car();

            //Set properties

            Car myOtherCar = mycar;

            myOtherCar = null;
            mycar = null;
            Car.myMethod();


        }
    }
    class Car
    {
        public string Make { get; set;}
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public double originalPrice { get; set; }

        public Car()
        {
            //You could use this from a configuration file, a Database, etc.
            //I'll just hardcode this instance
            this.Make = "Nissan";
            this.Model = "GTR";
            this.Year = 2013;
            this.Color = "Silver";
        }

        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }
        /*
        public Car(String carMake, string model, int year, string color)
        {
            Make = carMake;
            Model = model;
            Year = year;
            Color = color;
        }
        */

        public static void myMethod()
        {

        }
        }
}
