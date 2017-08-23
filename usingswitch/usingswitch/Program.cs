using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingswitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in a Super hero's name to see his nickname:");
            string userValue = Console.ReadLine();

            switch (userValue.ToUpper())
            {
                case "BATMAN":
                    Console.WriteLine("Caped Crusader");
                    break;
                case "SUPERMAN":
                    Console.WriteLine("Man of Steel");
                    break;
                case "GREENLANTERN":
                    Console.WriteLine("Emerald Knight");
                    break;
                default:
                    Console.WriteLine("Does not Compute");
                    break;
            }
            Console.ReadLine();
        }
    }
}
