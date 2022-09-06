using System;

namespace FigureSquare
{

    public class Square
    { 
        static public double FindSquare(double R)
        {
            if (R < 0)
                throw new Exception("Incorrect values");
            return Math.PI * Math.Pow(R, 2);
        }

        static public double FindSquare(double A, double B, double C)
        {
            if (A < 0 || B < 0 || C < 0)
                throw new Exception("Incorrect values");
            bool isRT = C == Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2)) ? true : false;
            if (isRT)
            {
                return A * B / 2;
            }
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
