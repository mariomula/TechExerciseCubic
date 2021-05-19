using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLib
{
    /**
     * Interface to group types of shapes.
     * Remember: the coordinate of any shape is allocated at its center
     * 
     * */
    public interface IShape
    {
        ICoordinate GetCoordinate();
    }
}
