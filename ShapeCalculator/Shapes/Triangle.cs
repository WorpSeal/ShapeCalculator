using System;

namespace ShapeCalculator
{
    public class Triangle : IAreaComputable
    {
        public readonly double SideA;
        public readonly double SideB;
        public readonly double SideC;

        public readonly double[] Sides;

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            Sides = new double[] { SideA, SideB, SideC };
            foreach (double side in Sides)
            {
                if (side <= 0)
                    throw new ArgumentException("Side of a triangle cannot be 0 or less");
            }
            if ((SideA + SideB <= SideC) ||
                (SideB + SideC <= SideA) ||
                (SideA + SideC <= SideB))
                    throw new ArgumentException("Triangle can`t exist with such sides");
        }
        
        public double ComputeArea()
        {
            double p = (SideA + SideB + SideC)*0.5;
            return Math.Sqrt(p*(p-SideA)*(p-SideB)*(p-SideC));
        }
    }
}