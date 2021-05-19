using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLib
{
    public class DimensionCube: IDimension
    {
        //In a cube all sides are equal.
        protected int sideSize;

        public DimensionCube(int sideSize)
        {
            this.sideSize = sideSize;
        }

        public int Sidesize
        {
            get
            {
                return sideSize;
            }
        }

    }
}
