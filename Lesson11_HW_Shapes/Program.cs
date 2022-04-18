using System;
using Models;

namespace Lesson11_HW_Shapes
{
    public static class Programm
    {

        const int shapeCount = 4;
        static void Main(string[] args)
        {

            Shape[] shapes = new Shape[shapeCount];
            for (int i = 0; i < shapeCount; i++)
            {
                var symbolColor = GetRandomNumber(0, 14);
                var circleColor = GetRandomNumber(0, 14);
                var symbolSC = GetRandomNumber(0, 14);
                Shape shape;
                if (i < 2)
                {
                    shape = new Circle("Circle " + i, '%', symbolColor, circleColor, symbolSC);

                }

                else
                {
                    shape = new Square("Square " + i, 'X', symbolColor, circleColor, symbolSC);
                }

                shapes[i] = shape;

            }

            foreach (var shape in shapes)
            {
                shape.Render();
            }

            Console.ReadLine();
        }

        private static readonly Random getrandom = new Random();

        public static int GetRandomNumber(int min, int max)
        {
            lock (getrandom) // synchronize
            {
                return getrandom.Next(min, max);
            }
        }
    }
}