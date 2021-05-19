using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLib
{
    

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

            //Finding if there is collision in plane XY
            Rectangle r1 = Utils.FindRectangle(cube1, CartesianPlane.XY);
            Rectangle r2 = Utils.FindRectangle(cube2, CartesianPlane.XY);
            bool isCollisionXY = IsCollision(r1, r2);

            //Finding if there is collision in plane YZ
            r1 = Utils.FindRectangle(cube1, CartesianPlane.YZ);
            r2 = Utils.FindRectangle(cube2, CartesianPlane.YZ);
            bool isCollisionYZ = IsCollision(r1, r2);

            //Finding if there is collision in plane XZ
            r1 = Utils.FindRectangle(cube1, CartesianPlane.XZ);
            r2 = Utils.FindRectangle(cube2, CartesianPlane.XZ);
            bool isCollisionXZ = IsCollision(r1, r2);

            //If there is collision in the three planes at the same time for sure the is a physical collision between both 3D cubes
            if (isCollisionXY && isCollisionYZ && isCollisionXZ) return true;
            else return false;
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
