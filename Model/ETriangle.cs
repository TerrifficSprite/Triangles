using System;

namespace Triangles.Model
{
    // EquilateralTriangle
    public class ETriangle : TTriangle
    {
        public ETriangle(int n)
        {
            SideA = new Random().Next(2, n);
            SideB = SideA;
            SideC = SideB;
            calculateCuts();
            TType = "Рівносторонній";
        }

        public override double Square()
        {
            double S = Math.Pow(SideA, 2) * Math.Sqrt(3)
                   / 4;
            Console.WriteLine(S);
            return Math.Round(S, 3);
        }

        public override double Perimeter()
        {
            double P = SideA * 3;
            Console.WriteLine("Периметр трикутника: " + P);
            return P;
        }

            public override string ToString()
            {
                return $"{base.ToString()}";
            }
    }
}