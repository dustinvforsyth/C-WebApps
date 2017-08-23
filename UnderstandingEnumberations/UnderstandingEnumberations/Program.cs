using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingEnumberations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            SuperHero myValue;
           // Console.WriteLine("Hello World!");
            //Console.ReadLine();

            Console.WriteLine("Type in Superhero's name to see his nickname: ");
            string userValue = Console.ReadLine();

            if (Enum.TryParse<SuperHero>(userValue, true, out myValue))
            {

                switch (myValue)
                {
                    case SuperHero.Batman:
                        Console.WriteLine("Caped Crusader");
                        break;
                    case SuperHero.Superman:
                        Console.WriteLine("Man of Steel");
                        break;
                    case SuperHero.GreenLantern:
                        Console.WriteLine("Emerald Knight");
                        break;
                    default:
                        Console.WriteLine("Does not Compute");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Does not Compute");
            }
            Console.ReadLine();
        }

    }
    enum SuperHero
    {
        Batman,
        Superman,
        GreenLantern
    }
}
