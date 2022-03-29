using System;

namespace Triangles.Model
{
    //   IsoscelesTriangle
    public class ITriangle : TTriangle
    {
        public ITriangle(int n)
        {
            Random random = new Random();
            SideA = random.Next(2, n);
            SideB = SideA;
            do
            {
                SideC = random.Next(1, (int)(SideA * 2) - 1);
            } while (SideC == SideA);
            
            calculateCuts();
            TType = "Рівнобедрений";
        }

        public override double Square()
        {
            double L = Math.Sqrt(SideA * SideA - SideB * SideB / 4);
            Console.WriteLine(L);
            return Math.Round(0.5 * SideA * L, 3);
        }

        public override double Perimeter()
        {
            return 2 * SideA + SideC;
        }
        
        public override string ToString()
        {
            return $"{base.ToString()}";
        }
    }
}