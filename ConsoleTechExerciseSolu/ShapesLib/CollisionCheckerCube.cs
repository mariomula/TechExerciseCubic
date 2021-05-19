using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLib
{
    enum CartesianPlane
    {
        XY,
        XZ,
        YZ
    }

    public class CollisionCheckerCube : ICollisionChecker
    {
        public bool IsCollision(IShape shape1, IShape shape2)
        {
            if ((shape1 is Cube == false) || (shape2 is Cube == false))
            {
                throw new Exception("Invalid param, must be a cube");
            }

            

            Cube cube1 = (Cube)shape1;
            Cube cube2 = (Cube)shape2;

            Coordinate3D coordiCube1 = (Coordinate3D)cube1.GetCoordinate();
            DimensionCube dimenCube1 = (DimensionCube)cube1.GetDimension();

            Coordinate3D coordiCube2 = (Coordinate3D)cube2.GetCoordinate();
            DimensionCube dimenCube2 = (DimensionCube)cube2.GetDimension();

            //Finding if there is collision in plane XY
            Rectangle r1 = FindRectangle(cube1, CartesianPlane.XY);
            Rectangle r2 = FindRectangle(cube2, CartesianPlane.XY);
            bool isCollisionXY = IsCollision(r1, r2);

            //Finding if there is collision in plane YZ
            r1 = FindRectangle(cube1, CartesianPlane.YZ);
            r2 = FindRectangle(cube2, CartesianPlane.YZ);
            bool isCollisionYZ = IsCollision(r1, r2);

            //Finding if there is collision in plane XZ
            r1 = FindRectangle(cube1, CartesianPlane.XZ);
            r2 = FindRectangle(cube2, CartesianPlane.XZ);
            bool isCollisionXZ = IsCollision(r1, r2);

            //If there is collision in the three planes at the same time for sure the is a physical collision between both 3D cubes
            if (isCollisionXY && isCollisionYZ && isCollisionXZ) return true;
            else return false;
        }





        /**
         * Find the rectangle proyected in a specific plane.
         * 
         * Remember that the coordinate of the cube is located in the center of itselft. However
         * in this method we want to get the rentangle (one face of the cube) with cartesian coordinate (x,y)
         * located at the bottom-left side. So this method does this transformation.
         * */
        private Rectangle FindRectangle(Cube cube, CartesianPlane plane)
        {
            Coordinate3D coordi = (Coordinate3D)cube.GetCoordinate();
            DimensionCube dimen = (DimensionCube)cube.GetDimension();

            Rectangle rect = new Rectangle();
            if (plane == CartesianPlane.XY) 
            { 
                rect.X = (float)coordi.GetX() - (float)(dimen.Sidesize / 2);
                rect.Y = (float)coordi.GetY() - (float)(dimen.Sidesize / 2);
            }
            else if (plane == CartesianPlane.YZ)
            {
                rect.X = (float)coordi.GetZ() - (float)(dimen.Sidesize / 2);
                rect.Y = (float)coordi.GetY() - (float)(dimen.Sidesize / 2);
            }
            else if (plane == CartesianPlane.XZ)
            {
                rect.X = (float)coordi.GetX() - (float)(dimen.Sidesize / 2);
                rect.Y = (float)coordi.GetZ() - (float)(dimen.Sidesize / 2);
            }
            rect.Width = dimen.Sidesize;
            rect.Height = dimen.Sidesize;

            return rect;
        }



        /**
         * Returns true if there is collision between both rectangles in a cartesian plane,
         * otherwise returns false
         * 
         * */
        bool IsCollision(Rectangle r1, Rectangle r2)
        {
            if (r1.X < r2.X + r2.Width &&
               r1.X + r1.Width > r2.X &&
               r1.Y < r2.Y + r2.Height &&
               r1.Y + r1.Height > r2.Y)
            {
                // collision detected in this plane
                return true;
            }
            else
            {
                //No collision
                return false;
            }
        }
    }
}
