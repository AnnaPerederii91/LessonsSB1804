using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Square : Shape
    {
        public Square(string circleName, char symbol, int symbolColor, int catColor, int symbolSC) : base(circleName, symbol, symbolColor, catColor, symbolSC)
        {
        }

        public override void Render()
        {
            var lines = 3;
            for (var i = 0; i < lines; i++)
            {
                Console.WriteLine();
            }
            //var paddingLesft = "\t\t";

            //Console.ForegroundColor = (ConsoleColor)color;
            //Console.WriteLine(paddingLesft + @"  /^ ^\");
            //Console.Write(paddingLesft + @" / ");
            //Console.ForegroundColor = (ConsoleColor)symbolColor;
            //Console.Write($"{symbol} {symbol}");
            //Console.ForegroundColor = (ConsoleColor)color;
            //Console.WriteLine(" \\");

            //Console.WriteLine(paddingLesft + @" V\ Y /V");
            //Console.WriteLine(paddingLesft + @"  / - \");
            //Console.WriteLine(paddingLesft + @" /    |");
            //Console.WriteLine(paddingLesft + @"V__) ||");
            //Console.WriteLine(paddingLesft + $"  {name}");

            var paddingLeft = "\t\t";
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(paddingLeft + $@" ---------");
            Console.ForegroundColor = (ConsoleColor)symbolSideColor;
            Console.WriteLine(paddingLeft + $@"|         |");
            Console.WriteLine(paddingLeft + $@"|         |");
            Console.WriteLine(paddingLeft + $@"|         |");
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(paddingLeft + $@" ---------");

            Console.WriteLine(paddingLeft + $"  {name}");
          
        }
    }
}
