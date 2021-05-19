using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using ShapesLib;

namespace UnitTestPro
{
    [TestClass]
    public class UnitTest1
    {
        /*
         * Collision when both cubes are over the same coordinate and both
         * have same dimension
         * */
        [TestMethod]
        public void TestWithCollision()
        {
            ICoordinate coordiCube1 = new Coordinate3D(10, 10, 10);
            IDimension dimenCube1 = new DimensionCube(2);
            IShape mycube1 = new Cube(coordiCube1, dimenCube1);

            ICoordinate coordiCube2 = new Coordinate3D(11, 11, 11);
            IDimension dimenCube2 = new DimensionCube(2);
            IShape mycube2 = new Cube(coordiCube2, dimenCube2);

            ICollisionChecker colliChecker = new CollisionCheckerCube();
            bool actual = colliChecker.IsCollision(mycube1, mycube2);
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }




        /*
         * Collision when both cubes are over the same coordinate but they
         * have different dimensions
         * */
        [TestMethod]
        public void TestWithCollision2()
        {
            ICoordinate coordiCube1 = new Coordinate3D(10, 10, 10);
            IDimension dimenCube1 = new DimensionCube(2);
            IShape mycube1 = new Cube(coordiCube1, dimenCube1);

            ICoordinate coordiCube2 = new Coordinate3D(10, 10, 10);
            IDimension dimenCube2 = new DimensionCube(4);
            IShape mycube2 = new Cube(coordiCube2, dimenCube2);

            ICollisionChecker colliChecker = new CollisionCheckerCube();
            bool actual = colliChecker.IsCollision(mycube1, mycube2);
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }




        /*
         * Collision when cubes are on different coordinates but the dimension
         * are big enough to make them collide
         * */
        [TestMethod]
        public void TestWithCollision3()
        {
            ICoordinate coordiCube1 = new Coordinate3D(10, 10, 10);
            IDimension dimenCube1 = new DimensionCube(3);
            IShape mycube1 = new Cube(coordiCube1, dimenCube1);

            ICoordinate coordiCube2 = new Coordinate3D(12, 12, 12);
            IDimension dimenCube2 = new DimensionCube(2);
            IShape mycube2 = new Cube(coordiCube2, dimenCube2);

            ICollisionChecker colliChecker = new CollisionCheckerCube();
            bool actual = colliChecker.IsCollision(mycube1, mycube2);
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }



        /*
         * No collision because cubes are not in the same coordinate and
         * they both don't have big enough dimensions
         * */
        [TestMethod]
        public void TestWithNoCollision1()
        {
            ICoordinate coordiCube1 = new Coordinate3D(10, 10, 10);
            IDimension dimenCube1 = new DimensionCube(3);
            IShape mycube1 = new Cube(coordiCube1, dimenCube1);

            ICoordinate coordiCube2 = new Coordinate3D(14, 14, 14);
            IDimension dimenCube2 = new DimensionCube(2);
            IShape mycube2 = new Cube(coordiCube2, dimenCube2);

            ICollisionChecker colliChecker = new CollisionCheckerCube();
            bool actual = colliChecker.IsCollision(mycube1, mycube2);
            bool expected = false;

            Assert.AreEqual(expected, actual);
        }


        /*
         * No collision because cubes are side by side 
         * */
        [TestMethod]
        public void TestWithNoCollision2()
        {
            ICoordinate coordiCube1 = new Coordinate3D(10, 10, 10);
            IDimension dimenCube1 = new DimensionCube(2);
            IShape mycube1 = new Cube(coordiCube1, dimenCube1);

            ICoordinate coordiCube2 = new Coordinate3D(12, 12, 12);
            IDimension dimenCube2 = new DimensionCube(2);
            IShape mycube2 = new Cube(coordiCube2, dimenCube2);

            ICollisionChecker colliChecker = new CollisionCheckerCube();
            bool actual = colliChecker.IsCollision(mycube1, mycube2);
            bool expected = false;

            Assert.AreEqual(expected, actual);
        }

    }
}
