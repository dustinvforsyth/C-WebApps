using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace understandingScope
{
    class Program
    {
        //private static string k = "";
        static void Main(string[] args)
        {
            //    string j = "";
            //    for (int i = 0; i < 10; i++)
            //    {
            //        j = i.ToString();
            //        k = i.ToString();
            //        Console.WriteLine(i);
            //        if (i == 9)
            //        {
            //            string l = i.ToString();
            //        }
            //       // Console.WriteLine("L: " + l);
            //    }
            //    //Console.WriteLine(i);
            //    //Console.ReadLine();

            //    Console.WriteLine("Outside of the for: " + j);
            //    // Console.WriteLine("k: " + k);
            //    helperMethod();

            Car car = new Car();
            car.DoSomething();

            Console.ReadLine();


        }
    class Car
        {
            public void DoSomething()
            {
                Console.WriteLine(helperMethod());
            }

            private string helperMethod()
            {
                return "Hello world!";
            }
        }
        //static void helperMethod()
        //{
        //    Console.WriteLine("k from the helpermethod: " + k);
        //}
    }
}
