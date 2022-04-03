using System;

namespace ShapeCalculator
{
    public abstract class ShapeCreator
    {
        public abstract IAreaComputable Create();
    }
}