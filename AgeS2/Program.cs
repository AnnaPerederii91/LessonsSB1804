using System;

namespace AgeS2
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Please enter your gender: F - female, M - male, Q - to exit");
                char userGender = Console.ReadKey().KeyChar;
                Console.WriteLine("");
                if (userGender == 'M')
                {
                    Console.WriteLine("Please enter your name");
                    string userName = Console.ReadLine();
                    Console.WriteLine("Hello Mister " + userName);
                }
                else if (userGender == 'F')
                {
                    Console.WriteLine("Please enter your name");
                    string userName = Console.ReadLine();
                    Console.WriteLine("Please enter your age");
                    var userAgeText = Console.ReadLine();
                    int userAge = 0;

                    if (userAgeText != null)
                    {
                        userAge = Convert.ToInt32(userAgeText);
                        if (userAge > 40)
                        {
                            Console.WriteLine("Hello Mrs. " + userName);
                        }
                        else if (userAge <= 40)
                        {
                            Console.WriteLine("Hello Miss. " + userName);
                        }
                    }

                }
                else if (userGender == 'Q')
                {
                    break;
                }
                // If user didn't enter F, M or Q
                else
                {
                    Console.WriteLine("You entered wrong symbol");
                    continue;
                }
            }


        }
    }
}