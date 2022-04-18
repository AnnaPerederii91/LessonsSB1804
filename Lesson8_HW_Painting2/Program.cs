using System;

namespace Lesson8_HW_Painting2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter bear nose: ");
                char bearNose = Console.ReadKey().KeyChar;
                Console.ReadLine();
                Console.WriteLine("Please enter bear eye: ");
                char bearEye = Console.ReadKey().KeyChar;
                Console.ReadLine();
                Console.WriteLine("Please enter your name: ");
                string userName = Console.ReadLine();

                if (userName == "Sergii")
                {
                    string padding = "\t\t\t\t";

                    var Lines = 12;
                    for (int i = 0; i < Lines; i++)
                    {
                        Console.WriteLine("");
                    }

                    Console.WriteLine($"{padding} __          __");
                    Console.WriteLine($@"{padding}/  \.-``` -./  \");
                    Console.WriteLine($@"{padding}\    -    -    /");
                    Console.WriteLine($@"{padding} |   {bearEye}    {bearEye}   |");
                    Console.WriteLine($@"{padding} \  .-'''-.  /");
                    Console.WriteLine($@"{padding}  '-\__{bearNose}__/-'");
                    Console.WriteLine($@"{padding}     `---`");
                    Console.WriteLine($"{padding}Thank you, " + userName + "!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Wrong! Please, enter your real name in the next loop");
                    continue;
                }
            }
        }
    }
}
