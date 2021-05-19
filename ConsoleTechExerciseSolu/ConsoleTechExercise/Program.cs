using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ShapesLib;

namespace ConsoleTechExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            _ = new Program();
        }

        public Program()
        {
            try
            {
                //
                ICoordinate coordiCubeA = UserInputCoordinate("cubeA");
                IDimension dimCubeA = UserInputDim("cubeA");
                IShape mycube1 = new Cube(coordiCubeA, dimCubeA);

                ICoordinate coordiCubeB = UserInputCoordinate("cubeB");
                IDimension dimCubeB = UserInputDim("cubeB");
                IShape mycube2 = new Cube(coordiCubeB, dimCubeB);

                //
                /*ICoordinate coordiCube1 = new Coordinate3D(10, 10, 10);
                IDimension dimenCube1 = new DimensionCube(2);
                IShape mycube1 = new Cube(coordiCube1, dimenCube1);

                ICoordinate coordiCube2 = new Coordinate3D(11, 11, 11);
                IDimension dimenCube2 = new DimensionCube(2);
                IShape mycube2 = new Cube(coordiCube2, dimenCube2);
                */

                ICollisionChecker colliChecker = new CollisionCheckerCube();
                bool res = colliChecker.IsCollision(mycube1, mycube2);


                if (res) Console.WriteLine("is collision");
                else Console.WriteLine("there is no collision");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Something went wrong: "+ex.Message);
            }
        }


        /**
         * 
         * */
         ICoordinate UserInputCoordinate(string customText)
        {
            
            Console.WriteLine($"Enter coodinates {customText} (x,y,z):");
            string input = Console.ReadLine();
            string[] txt = input.Split(',');
            if (txt.Length != 3) throw new Exception("Invalid coordintate");
            int Xval = Convert.ToInt32(txt[0]);
            int Yval = Convert.ToInt32(txt[1]);
            int Zval = Convert.ToInt32(txt[2]);

            ICoordinate coordinate = new Coordinate3D(Xval, Yval, Zval);
            return coordinate;
        }



        /**
         * 
         * */
        IDimension UserInputDim(string customText)
        {
            Console.WriteLine($"Enter {customText} dimension (integer number):");
            string input = Console.ReadLine();
            
            IDimension dim1 = new DimensionCube(Convert.ToInt32(input));
            return dim1;
        }
    }
}
