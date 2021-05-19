using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLib
{
    public abstract class Shape3D: IShape
    {
        protected ICoordinate m_coordinate;

        public Shape3D(ICoordinate coordinate)
        {
            m_coordinate = coordinate;
        }

        public abstract ICoordinate GetCoordinate();
    }
}
