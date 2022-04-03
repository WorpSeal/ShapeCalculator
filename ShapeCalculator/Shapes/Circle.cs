using System;

namespace ShapeCalculator
{
    public class Circle : IAreaComputable
    {
        public readonly double Radius;
        
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius of a circle cannot be 0 or less");
            Radius = radius;
        }
        
        public double ComputeArea()
        {
            return Math.PI*2*Radius;
        }
    }
}