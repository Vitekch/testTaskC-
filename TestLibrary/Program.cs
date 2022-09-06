using System;
using FigureSquare;

namespace TestLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            double circleSquare = Square.FindSquare(2.3);
            double rTriangleSquare = Square.FindSquare(3, 4, 5);
            double triangleSquare = Square.FindSquare(6, 3, 4);

            Console.WriteLine(circleSquare);
            Console.WriteLine(rTriangleSquare);
            Console.WriteLine(triangleSquare);

            Console.Read();
        }
    }
}
