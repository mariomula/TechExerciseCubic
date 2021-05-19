using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLib
{
    public class Rectangle
    {
       
        public float X
        {
            set;get;
        }

        public float Y
        {
            set;get;
        }

        public int Width
        {
            set;get;
        }

        public int Height
        {
            set;get;
        }


        /**
         * Return the botom-left point of this rectangle
         * */
        public Point GetLeftPoint()
        {
            Point p = new Point
            {
                X = X,
                Y = Y
            };

            return p;
        }



        /**
         * Returns the top-Right point of this rectangle
         * */
        public Point GetRightPoint()
        {
            Point p = new Point
            {
                X = X + Width,
                Y = Y + Height
            };

            return p;
        }

    }
}
