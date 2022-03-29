using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles.Model
{
    // Straight cut Triangle
    class STriangle : TTriangle
    {
        public STriangle() { }

        public STriangle(int n)
        {
            Random random = new Random();
            SideA = random.Next(2, n);
            do
            {
                SideB = random.Next(2, n);
            } while (SideB == SideA);
            SideC = Math.Round(Math.Sqrt(SideA * SideA + SideB * SideB), 4);
            calculateCuts();
            TType = "Прямокутний";
        }

        public override double Square()
        {
            double S = 0.5 * SideA * SideB;
            Console.WriteLine(S);
            return Math.Round(S, 3);
        }

        public override string ToString()
        {
            return $"{base.ToString()}";
        }
    }
}
