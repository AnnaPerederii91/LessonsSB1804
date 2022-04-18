using System;

namespace Lesson8_Practics_Paint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter cat eye shape: ");
            char catEye = Console.ReadKey().KeyChar;
            string padding = "\t\t\t\t\t\t\t";
            
            var Lines = 14;
            for (int i = 0; i < Lines; i++)
            {
                Console.WriteLine("");
            }

            Console.WriteLine(@$"{padding} /\_/\");
            Console.WriteLine($"{padding}( {catEye}.{catEye} )");
            Console.WriteLine($"{padding} > ^ <");
            Console.ReadLine();
        }
    }
}
