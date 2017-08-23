using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please type something and press the enter key.");
            //string userValue;
            //userValue = Console.ReadLine();
            //Console.WriteLine("You typed: " + userValue);

            Console.WriteLine("Would you prefer what is behind door number 1, 2, or  3?");
            string userValue = Console.ReadLine();

            //String message = "";

            //if (userValue == "1")
            //    message = "You won a new car!";
            //else if (userValue == "2")
            //    message = "You won a new boat!";
            //else if (userValue == "3")
            //    message = "You won a new cat!";
            //else
            //    message = "Sorry, we didn't understand. You Lose!";

            //Console.WriteLine(message);
            string dog = "Dog (Koda dog)";

            string message = (userValue == "1") ? "Boat" : "strand of lint";
            Console.WriteLine("You won a {0} {1}", message, userValue);

            string message2 = (userValue == "3") ? "Baby" : "New computer";
            Console.WriteLine("You won a {0} {1}", message2, dog);
            Console.ReadLine();

            Console.WriteLine("Lets Play Rock paper or Scissors, What would you like to pick?");
            string userPick = Console.ReadLine();
            int computerPick = Random.Next(3);
        }
    }
}
