using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models1
{
    public class Circle : Shape
    {
        public Circle(string circleName, char symbol, int symbolColor, int catColor, int symbolSC) : base(circleName, symbol, symbolColor, catColor, symbolSC)
        {
        }

        public override void Render()
        {
            int lines = 3;
            for (int i = 0; i < lines; i++)
            {
                Console.WriteLine();
            }

            //var paddingLeft = "\t\t";
            //Console.ForegroundColor = (ConsoleColor)color;
            //Console.WriteLine(paddingLeft + @"  /\_/\");
            //Console.Write(paddingLeft + " ( ");
            //Console.ForegroundColor = (ConsoleColor)symbolColor;
            //Console.Write($"{ symbol}.{symbol}");
            //Console.ForegroundColor = (ConsoleColor)color;
            //Console.WriteLine(" )");
            //Console.WriteLine(paddingLeft + "  > ^ <");
            //Console.WriteLine(paddingLeft + $"  {name}");

            var paddingLeft = "\t\t";
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(paddingLeft + $@"            {symbol} {symbol} {symbol}    {symbol} {symbol} {symbol}");
            //Console.Write(paddingLeft + $"      {symbol} {symbol} {symbol}              {symbol} {symbol} {symbol}");
            //Console.ForegroundColor = (ConsoleColor)symbolColor;
            //Console.Write(paddingLeft + $"      {symbol}{symbol}{symbol}              {symbol}{symbol}{symbol}");
            Console.WriteLine(paddingLeft + $@"      {symbol} {symbol} {symbol}               {symbol} {symbol} {symbol} ");
            Console.WriteLine(paddingLeft + $@"  {symbol} {symbol} {symbol}                       {symbol} {symbol} {symbol} ");
            Console.WriteLine(paddingLeft + $@" {symbol} {symbol} {symbol}                          {symbol} {symbol} {symbol} ");
            Console.WriteLine(paddingLeft + $@" {symbol} {symbol} {symbol}                          {symbol} {symbol} {symbol} ");
            Console.WriteLine(paddingLeft + $@" {symbol} {symbol} {symbol}                         {symbol} {symbol} {symbol} ");
            Console.WriteLine(paddingLeft + $@"    {symbol} {symbol} {symbol}                   {symbol} {symbol} {symbol} ");
            Console.WriteLine(paddingLeft + $@"          {symbol} {symbol} {symbol}      {symbol} {symbol} {symbol} ");
            Console.WriteLine(paddingLeft + $"  {name}");

        }
    }
}
