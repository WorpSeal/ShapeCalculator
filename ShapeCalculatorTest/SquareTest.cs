using System;
using ShapeCalculator;

namespace ShapeCalculatorTest
{
    class SquareCreatorTest : ShapeCreator
    {
        public double Side;

        public SquareCreatorTest()
        {
            Side = 1;
        }

        public SquareCreatorTest(double side)
        {
            Side = side;
        }

        public override IAreaComputable Create()
        {
            return new SquareTest(Side);
        }
    }

    class SquareTest : IAreaComputable
    {
        public double Side
        {
            get { return m_side; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Square side can`t be less or equal to 0");
                }
                m_side = value;
            }
        }

        private double m_side;

        public SquareTest(double side)
        {
            Side = side;
        }

        public double ComputeArea()
        {
            return m_side * m_side;
        }
    }
}
