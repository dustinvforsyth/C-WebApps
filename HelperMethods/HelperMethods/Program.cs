using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            String myValue = superSecretFormula("Sunshine");
            Console.WriteLine(myValue);
            Console.ReadLine();
        }

        private static string superSecretFormula()
        {
            //Some cool stuff here
            return "Hello World!";
        }
        private static string superSecretFormula(string name)
        {
            return String.Format("Hello, {0}!", name);
        }
    }
}
