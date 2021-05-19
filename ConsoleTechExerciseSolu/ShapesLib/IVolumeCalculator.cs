using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesLib
{
    public interface IVolumeCalculator
    {
        /**
         * Returns the intersection volue of two shapes
         * 
         * */
        float IntersecVolume(IShape shape1, IShape shape2);
    }
}
