using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;

            x = 7;
            y = x + 3;
            Console.WriteLine(y);

            Console.ReadLine();
            */

            //string myFirstName;
            // string myFirstName = "Dustin";
            //Console.WriteLine("Hello my name is " + myFirstName);

            //Comment this is equal to 75 because the 5 is a string
            int x = 7;
            //string y = "Bob";
            string y = "5";
            string myFirstTry = x.ToString() + y;

            //int mySecondTry = x + y;
            int mySecondTry = x + int.Parse(y);

            Console.WriteLine(myFirstTry);

            Console.ReadLine();
        }
    }
}
