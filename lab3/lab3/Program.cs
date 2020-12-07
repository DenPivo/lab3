using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Points
    {
        private int X;
        private int Y;
        private char symb;
        public void SetX(int X)
        {
            if (X >= 0)
                this.X = X;
            else
                throw new Exception("X не может быть отрицательным");
        }
        public void SetY(int Y)
        {
            if (Y >= 0)
                this.Y = Y;
            else
                throw new Exception("Y не может быть отрицательным");
        }
        public void SetSymb(char symb)
        {
            this.symb = symb;
        }
        public void Draw(int X, int Y)
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(symb);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Points one = new Points();
            one.SetSymb('(');
            one.Draw(-10, 8);
            Points two = new Points();
            two.SetSymb(')');
            two.Draw(-11, 8);
            Points three = new Points();
            three.SetSymb('(');
            three.Draw(13, 8);
            Points four = new Points();
            four.SetSymb(')');
            four.Draw(14, 8);
            Points five = new Points();
            five.SetSymb('/');
            five.Draw(11, 9);
            Points six = new Points();
            six.SetSymb('\\');
            six.Draw(13, 9);
            Console.ReadKey();
        }
    }
}
