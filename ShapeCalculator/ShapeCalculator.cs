using System.Linq;

namespace ShapeCalculator
{
    public static class ShapeCalculator
    {
        public static double ComputeArea(IAreaComputable shape)
        {
            return shape.ComputeArea();
        }

        public static bool IsRightTriangle(Triangle triangle)
        {
            double longest = triangle.Sides.Max();
            double[] other = triangle.Sides.Except(new double[]{longest}).ToArray();

            return longest*longest == other[0]*other[0] + other[1]*other[1];
        }
    }
}