using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Shape
    {
        protected char symbol;
        protected int symbolColor;
        protected int color;
        protected string name;
        protected int symbolSideColor;

        public Shape(string circleName, char circleSymbol = 'X', int circleColor = 10, int catColor = 5, int symbolSC = 7)
        {
            symbol = circleSymbol;
            symbolColor = circleColor;
            color = catColor;
            name = circleName;
            symbolSideColor = symbolSC;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public virtual void Render()
        {
            Console.WriteLine("I'm a Shape");
        }
    }
}
