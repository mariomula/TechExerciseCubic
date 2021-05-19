using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesLib
{
    public class VolumeCalcuCube : IVolumeCalculator
    {
        public float IntersecVolume(IShape shape1, IShape shape2)
        {
            Cube cube1 = (Cube)shape1;
            Cube cube2 = (Cube)shape2;

            //XY plane
            float areaIntersecXY = CalcIntersecArea(cube1, cube2, CartesianPlane.XY);
           

            //YZ plane
            float areaIntersecYZ = CalcIntersecArea(cube1, cube2, CartesianPlane.YZ);


            //XZ plane
            float areaIntersecXZ = CalcIntersecArea(cube1, cube2, CartesianPlane.XZ);


            return (areaIntersecXY * areaIntersecYZ * areaIntersecXZ);

        }



        private float CalcIntersecArea(Cube cube1, Cube cube2, CartesianPlane plane)
        {
            Rectangle rec1 = Utils.FindRectangle(cube1, plane);
            Point l1 = rec1.GetLeftPoint();
            Point r1 = rec1.GetRightPoint();

            Rectangle rec2 = Utils.FindRectangle(cube2, plane);
            Point l2 = rec2.GetLeftPoint();
            Point r2 = rec2.GetRightPoint();

            
            float areaIntersec = CalcIntersecArea(l1, r1, l2, r2);

            return areaIntersec;
        }




        /**
         * Returns the area of intersection of two rectangles, each one defined
         * by two points: the bottom-left one and the top-right one
         * 
         * */
        private float CalcIntersecArea(Point l1, Point r1, Point l2, Point r2)
        {
            // Area of 1st Rectangle. I think we don't need this
            //float area1 = Math.Abs(l1.X - r1.X) * Math.Abs(l1.Y - r1.Y);


            // Area of 2nd Rectangle. I think we don't need this
            //float area2 = Math.Abs(l2.X - r2.X) * Math.Abs(l2.Y - r2.Y);


            // Length of intersecting part i.e  
            // start from max(l1.x, l2.x) of  
            // x-coordinate and end at min(r1.x, 
            // r2.x) x-coordinate by subtracting  
            // start from end we get required  
            // lengths 

            //if ((E >= C) || (F >= D) || (A >= G) || (B >= H)) return 0;
            if ((l2.X >= r1.X) || (l2.Y >= r1.Y) || (l1.X >=r2.X) || (l1.Y >= r2.Y)) return 0;

            
            float areaIntersec = (Math.Min(r1.X, r2.X) - Math.Max(l1.X, l2.X)) * (Math.Min(r1.Y, r2.Y) - Math.Max(l1.Y, l2.Y));
            //float totalArea =  (area1 + area2 - areaIntersec);

            //This is the total area, I think we don't need it
            //return totalArea;
            return areaIntersec;
        }
    }
}
