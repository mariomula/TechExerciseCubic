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




        /*
         * 
         * */
        [TestMethod]
        public void TestVolume1()
        {
            ICoordinate coordiCube1 = new Coordinate3D(10, 10, 10);
            IDimension dimenCube1 = new DimensionCube(1);
            IShape mycube1 = new Cube(coordiCube1, dimenCube1);

            ICoordinate coordiCube2 = new Coordinate3D(10, 10, 10);
            IDimension dimenCube2 = new DimensionCube(1);
            IShape mycube2 = new Cube(coordiCube2, dimenCube2);

            IVolumeCalculator voluCalculator = new VolumeCalcuCube();
            var actual = voluCalculator.IntersecVolume(mycube1, mycube2);
            var expected = 1.0f;

            Assert.AreEqual(expected, actual);
        }



        /*
         *  Complete overlap test between both objects
         *  
         * */
        [TestMethod]
        public void TestVolume2()
        {
            ICoordinate coordiCube1 = new Coordinate3D(10, 10, 10);
            IDimension dimenCube1 = new DimensionCube(2);
            IShape mycube1 = new Cube(coordiCube1, dimenCube1);

            ICoordinate coordiCube2 = new Coordinate3D(10, 10, 10);
            IDimension dimenCube2 = new DimensionCube(2);
            IShape mycube2 = new Cube(coordiCube2, dimenCube2);

            IVolumeCalculator voluCalculator = new VolumeCalcuCube();
            var actual = voluCalculator.IntersecVolume(mycube1, mycube2);
            var expected = 64.0f;

            Assert.AreEqual(expected, actual);
        }



        /*
         * Half-size overlap between both objects
         * 
         * */
        [TestMethod]
        public void TestVolume3()
        {
            ICoordinate coordiCube1 = new Coordinate3D(10, 10, 10);
            IDimension dimenCube1 = new DimensionCube(2);
            IShape mycube1 = new Cube(coordiCube1, dimenCube1);

            ICoordinate coordiCube2 = new Coordinate3D(11, 11, 11);
            IDimension dimenCube2 = new DimensionCube(2);
            IShape mycube2 = new Cube(coordiCube2, dimenCube2);

            IVolumeCalculator voluCalculator = new VolumeCalcuCube();
            var actual = voluCalculator.IntersecVolume(mycube1, mycube2);
            var expected = 1.0f;

            Assert.AreEqual(expected, actual);
        }


        /*
         * Side by side object. No volume of intersection
         * */
        [TestMethod]
        public void TestVolume4()
        {
            ICoordinate coordiCube1 = new Coordinate3D(10, 10, 10);
            IDimension dimenCube1 = new DimensionCube(2);
            IShape mycube1 = new Cube(coordiCube1, dimenCube1);

            ICoordinate coordiCube2 = new Coordinate3D(12, 12, 12);
            IDimension dimenCube2 = new DimensionCube(2);
            IShape mycube2 = new Cube(coordiCube2, dimenCube2);

            IVolumeCalculator voluCalculator = new VolumeCalcuCube();
            var actual = voluCalculator.IntersecVolume(mycube1, mycube2);
            var expected = 0.0f;

            Assert.AreEqual(expected, actual);
        }


        /*
         * This time the second object located at the left of the first object
         * */
        [TestMethod]
        public void TestVolume5()
        {
            ICoordinate coordiCube1 = new Coordinate3D(12, 12, 12);
            IDimension dimenCube1 = new DimensionCube(2);
            IShape mycube1 = new Cube(coordiCube1, dimenCube1);

            ICoordinate coordiCube2 = new Coordinate3D(11, 11, 11);
            IDimension dimenCube2 = new DimensionCube(2);
            IShape mycube2 = new Cube(coordiCube2, dimenCube2);

            IVolumeCalculator voluCalculator = new VolumeCalcuCube();
            var actual = voluCalculator.IntersecVolume(mycube1, mycube2);
            var expected = 1.0f;

            Assert.AreEqual(expected, actual);
        }



        /*
         * With negative coordinate for the z axis
         * */
        [TestMethod]
        public void TestVolume6()
        {
            ICoordinate coordiCube1 = new Coordinate3D(12, 12, -12);
            IDimension dimenCube1 = new DimensionCube(2);
            IShape mycube1 = new Cube(coordiCube1, dimenCube1);

            ICoordinate coordiCube2 = new Coordinate3D(11, 11, -11);
            IDimension dimenCube2 = new DimensionCube(2);
            IShape mycube2 = new Cube(coordiCube2, dimenCube2);

            IVolumeCalculator voluCalculator = new VolumeCalcuCube();
            var actual = voluCalculator.IntersecVolume(mycube1, mycube2);
            var expected = 1.0f;

            Assert.AreEqual(expected, actual);
        }


        /*
         * With negative coordinate for the Y axis
         * */
        [TestMethod]
        public void TestVolume7()
        {
            ICoordinate coordiCube1 = new Coordinate3D(12, -12, 12);
            IDimension dimenCube1 = new DimensionCube(2);
            IShape mycube1 = new Cube(coordiCube1, dimenCube1);

            ICoordinate coordiCube2 = new Coordinate3D(11, -11, 11);
            IDimension dimenCube2 = new DimensionCube(2);
            IShape mycube2 = new Cube(coordiCube2, dimenCube2);

            IVolumeCalculator voluCalculator = new VolumeCalcuCube();
            var actual = voluCalculator.IntersecVolume(mycube1, mycube2);
            var expected = 1.0f;

            Assert.AreEqual(expected, actual);
        }

        /*
         * With negative coordinate for the X axis
         * */
        [TestMethod]
        public void TestVolume8()
        {
            ICoordinate coordiCube1 = new Coordinate3D(+12, 12, 12);
            IDimension dimenCube1 = new DimensionCube(2);
            IShape mycube1 = new Cube(coordiCube1, dimenCube1);

            ICoordinate coordiCube2 = new Coordinate3D(+11, 11, 11);
            IDimension dimenCube2 = new DimensionCube(2);
            IShape mycube2 = new Cube(coordiCube2, dimenCube2);

            IVolumeCalculator voluCalculator = new VolumeCalcuCube();
            var actual = voluCalculator.IntersecVolume(mycube1, mycube2);
            var expected = 1.0f;

            Assert.AreEqual(expected, actual);
        }



        /**
         * 
         * Test how the static method 'FindRectangle' work and returns
         * both formats of representing a rectangle:
         * Format1 : x,y with width and height
         * format2 : x1,y1 -> x2,y2
         * */
        [TestMethod]
        public void TestFindRectangle1()
        {
            ICoordinate coordiCube1 = new Coordinate3D(10, 10, 10);
            IDimension dimenCube1 = new DimensionCube(2);
            Cube mycube1 = new Cube(coordiCube1, dimenCube1);

            Rectangle rec = Utils.FindRectangle(mycube1, CartesianPlane.XY);

            var expected = rec.X;
            var actual = 9.0f;
            Assert.AreEqual(expected, actual);

            expected = rec.Y;
            actual = 9.0f;
            Assert.AreEqual(expected, actual);

            var expected2 = rec.Width;
            var actual2 = 2;
            Assert.AreEqual(expected2, actual2);

            expected2 = rec.Height;
            actual2 = 2;
            Assert.AreEqual(expected2, actual2);

            expected = rec.GetLeftPoint().X;
            actual = 9.0f;
            Assert.AreEqual(expected, actual);

            expected = rec.GetLeftPoint().Y;
            actual = 9.0f;
            Assert.AreEqual(expected, actual);

            expected = rec.GetRightPoint().X;
            actual = 11.0f;
            Assert.AreEqual(expected, actual);

            expected = rec.GetRightPoint().Y;
            actual = 11.0f;
            Assert.AreEqual(expected, actual);
        }


        /**
         * 
         * Same as previous one with diferent coordinates
         * */
        [TestMethod]
        public void TestFindRectangle2()
        {
            ICoordinate coordiCube1 = new Coordinate3D(5, 5, 5);
            IDimension dimenCube1 = new DimensionCube(2);
            Cube mycube1 = new Cube(coordiCube1, dimenCube1);

            Rectangle rec = Utils.FindRectangle(mycube1, CartesianPlane.XY);

            var expected = rec.X;
            var actual = 4.0f;
            Assert.AreEqual(expected, actual);

            expected = rec.Y;
            actual = 4.0f;
            Assert.AreEqual(expected, actual);

            var expected2 = rec.Width;
            var actual2 = 2;
            Assert.AreEqual(expected2, actual2);

            expected2 = rec.Height;
            actual2 = 2;
            Assert.AreEqual(expected2, actual2);

            expected = rec.GetLeftPoint().X;
            actual = 4.0f;
            Assert.AreEqual(expected, actual);

            expected = rec.GetLeftPoint().Y;
            actual = 4.0f;
            Assert.AreEqual(expected, actual);

            expected = rec.GetRightPoint().X;
            actual = 6.0f;
            Assert.AreEqual(expected, actual);

            expected = rec.GetRightPoint().Y;
            actual = 6.0f;
            Assert.AreEqual(expected, actual);
        }

    }   
}
