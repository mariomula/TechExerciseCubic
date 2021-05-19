using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesLib
{


    public enum CartesianPlane
    {
        XY,
        XZ,
        YZ
    }

    /**
     * This is the class were isolated functions are implemented
     * */
    public class Utils
    {


        /**
         * Find the rectangle proyected in a specific plane.
         * 
         * Remember that the coordinate of the cube is located in the center of itselft. However
         * in this method we want to get the rentangle (one face of the cube) with cartesian coordinate (x,y)
         * located at the bottom-left side. So this method does this transformation.
         * */
        public static Rectangle FindRectangle(Cube cube, CartesianPlane plane)
        {
            Coordinate3D coordi = (Coordinate3D)cube.GetCoordinate();
            DimensionCube dimen = (DimensionCube)cube.GetDimension();

            Rectangle rect = new Rectangle();
            if (plane == CartesianPlane.XY)
            {
                rect.X = (float)coordi.GetX() - (float)((float)dimen.Sidesize / (float)2);
                rect.Y = (float)coordi.GetY() - (float)((float)dimen.Sidesize / (float)2);
            }
            else if (plane == CartesianPlane.YZ)
            {
                rect.X = (float)coordi.GetZ() - (float)((float)dimen.Sidesize / (float)2);
                rect.Y = (float)coordi.GetY() - (float)((float)dimen.Sidesize / (float)2);
            }
            else if (plane == CartesianPlane.XZ)
            {
                rect.X = (float)coordi.GetX() - (float)((float)dimen.Sidesize / (float)2);
                rect.Y = (float)coordi.GetZ() - (float)((float)dimen.Sidesize / (float)2);
            }
            rect.Width = dimen.Sidesize;
            rect.Height = dimen.Sidesize;

            return rect;
        }
    }
}
