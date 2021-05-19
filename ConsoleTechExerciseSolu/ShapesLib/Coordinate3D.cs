using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLib
{
    /**
     * Keeps the coordinates of a 3D shape.
     * Remember: the coordinate defines the location at the center of the object
     * 
     * */
    public class Coordinate3D: ICoordinate
    {
        private int x, y, z;

        public Coordinate3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        
        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        public int GetZ()
        {
            return z;
        }
    }
}
