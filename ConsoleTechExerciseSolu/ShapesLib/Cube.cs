using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLib
{
    public class Cube: Shape3D
    {
        protected IDimension dimension;

        public Cube(ICoordinate coordinate, IDimension dimension): base(coordinate)
        {
            this.dimension = dimension;
        }

        public override ICoordinate GetCoordinate()
        {
            return m_coordinate;
        }

        public IDimension GetDimension()
        {
            return dimension;
        }
    }
}
