using System;

namespace Triangles.Model
{
    public class TTriangle
    {
        private double a;
        private double b;
        private double c;
        private double A;
        private double B;
        private double C;
        private string type = "Різносторонній";

        public TTriangle() { }

        public TTriangle(int n)
        {
            Random random = new Random();
            SideA = random.Next(2, n);
            do 
            {
                SideB = random.Next(2, n);
                SideC = random.Next((int)Math.Abs(SideA - SideB), (int)(SideA + SideB));
            } while (SideA == SideB || SideB == SideC);
           
            calculateCuts();
        }

        public virtual double Square()
        {
            float p = (float)(a + b + c) / 2;
            float S = (float) Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("Площа трикутника: " + S);
            return Math.Round(S, 3);
        }
        
        public virtual double Perimeter()
        {
            double P = SideA + SideB + SideC;
            Console.WriteLine("Периметр трикутника: " + P);
            return Math.Round(P, 3);
        }

        public double SideA
        {
            get => a;
            set
            {
                if (value < 0)
                    throw new Exception("Довжина сторони 'а' не може бути меншою за 0"); 
                a = value;
            }
        }

        public double SideB
        {
            get => b;
            set
            {
                if (value < 0)
                    throw new Exception("Довжина сторони 'b' не може бути меншою за 0");
                b = value;
            }
        }

        public double SideC
        {
            get => c;
            set
            {
                if (value < 0)
                    throw new Exception("Довжина сторони 'c' не може бути меншою за 0");
                c = value;
            }
        }

        public double CornerA
        {
            get => A;
            set
            {
                if (value < 0)
                    throw new Exception("Кут А не може бути меншим за 0°");
                A = value;
            }
        }

        public double CornerB
        {
            get => B;
            set
            {
                if (value < 0)
                    throw new Exception("Кут В не може бути меншим за 0°");
                B = value;
            }
        }

        public double CornerC
        {
            get => C;
            set
            {
                if (value < 0)
                    throw new Exception("Кут С не може бути меншим за 0°");
                C = value;
            }
        }

        public string TType { get => type; set => type = value; }

        public override string ToString()
        {
            return $"{nameof(SideA)}: {SideA}, {nameof(SideB)}: {SideB}, {nameof(SideC)}: {SideC}, {nameof(CornerA)}: {CornerA}, {nameof(CornerB)}: {CornerB}, {nameof(CornerC)}: {CornerC}\n" +
                $", Square: {Square()}, Perimeter: {Perimeter()}";
        }

        private double CutBySides(double a, double b, double c)
        {
            double d = Math.Acos((a * a + b * b - c * c) / (2 * a * b));
            return Math.Round(d * 180 / Math.PI, 2);

        }

        public void calculateCuts()
        {
            CornerC = CutBySides(SideA, SideB, SideC);
            CornerA = CutBySides(SideB, SideC, SideA);
            CornerB = Math.Round(180 - (CornerA + CornerC), 2);
            //CornerB = CutBySides(SideC, SideA, SideB);
        }

    }
}