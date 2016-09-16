using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    class Program
    {
        static void Main(string[] args)
        //övning1
        {
            Console.WriteLine("Mata in ett tal mellan 1 och 4");

            int tal = int.Parse(Console.ReadLine());
            switch (tal)
            {

                case 1: Console.WriteLine("Ett"); break;
                case 2: Console.WriteLine("Två"); break;
                case 3: Console.WriteLine("Tre"); break;
                case 4: Console.WriteLine("Fyra"); break;
                default: Console.WriteLine("Ogiltigt alternativ!"); break;

            }

            //övning2
            Console.WriteLine("Skriv en stor bokstav");

            string ltr = Console.ReadLine();
            switch (ltr)
            {
                case "N": Console.WriteLine("You walk north"); break;
                case "S": Console.WriteLine("You travel south"); break;
                case "E": Console.WriteLine("You wander east"); break;
                case "W": Console.WriteLine("You stroll west"); break;
                default: Console.WriteLine("I don't understand!"); break;


            }
        }
    }
}
