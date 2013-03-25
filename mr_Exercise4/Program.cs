using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mr_Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int intGetal;
            int intInput;

            Console.WriteLine("Kies een getal tussen de 0 en 9");

            do
            {
                Random randNummer = new Random();
                intGetal = randNummer.Next(10);

                intInput = Int16.Parse(Console.ReadLine());

                if (intGetal != intInput)
                {
                    Console.WriteLine("Helaas, ik had " + intGetal + " in gedachten");
                }
            }
            while (intGetal != intInput);

            Console.WriteLine("Correct!");
            Console.ReadLine();
        }
    }
}
