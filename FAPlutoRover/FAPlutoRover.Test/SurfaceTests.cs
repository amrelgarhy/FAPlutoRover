using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FAPlutoRover.Test
{
    [TestClass]
    public class SurfaceTests
    {
        #region grid surface
        [TestMethod]
        public void GridSurface_Create_XYShouldBeZero()
        {
            var gridSurface = new GridSurface(100);

            Assert.AreEqual(gridSurface.X, 0);
            Assert.AreEqual(gridSurface.Y, 0);
        }


        [TestMethod]
        public void GridSurface_BackwardX_KeepInPlace()
        {
            var gridSurface = new GridSurface(100);

            gridSurface.StepXBackward();

            Assert.AreEqual(0, gridSurface.X);
            Assert.AreEqual(0, gridSurface.Y);
        }

        [TestMethod]
        public void GridSurface_ForwardX_X1()
        {
            var gridSurface = new GridSurface(100);

            gridSurface.StepXForward();

            Assert.AreEqual(1, gridSurface.X);
            Assert.AreEqual(0, gridSurface.Y);
        }

        [TestMethod]
        public void GridSurfaceSize1_ForwardTwiceX_X1()
        {
            var gridSurface = new GridSurface(1);

            gridSurface.StepXForward();
            gridSurface.StepXForward();

            Assert.AreEqual(1, gridSurface.X);
            Assert.AreEqual(0, gridSurface.Y);
        }

        [TestMethod]
        public void GridSurface_BackwardY_KeepInPlace()
        {
            var gridSurface = new GridSurface(100);

            gridSurface.StepYBackward();

            Assert.AreEqual(0, gridSurface.X);
            Assert.AreEqual(0, gridSurface.Y);
        }

        [TestMethod]
        public void GridSurface_ForwardY_Y1()
        {
            var gridSurface = new GridSurface(100);

            gridSurface.StepYForward();

            Assert.AreEqual(0, gridSurface.X);
            Assert.AreEqual(1, gridSurface.Y);
        }

        [TestMethod]
        public void GridSurfaceSize1_ForwardTwiceY_Y1()
        {
            var gridSurface = new GridSurface(1);

            gridSurface.StepYForward();
            gridSurface.StepYForward();

            Assert.AreEqual(0, gridSurface.X);
            Assert.AreEqual(1, gridSurface.Y);
        }
        #endregion

        #region sphere grid surface
        [TestMethod]
        public void Sphere_IncreaseYMoreThanSizeBy1_Y0()
        {
            var grid = new SphereGridSurface(2);

            grid.StepYForward();
            grid.StepYForward();
            grid.StepYForward();

            Assert.AreEqual(0, grid.Y);
        }


        [TestMethod]
        public void Sphere_IncreaseYMoreThanSizeBy2_Y1()
        {
            var grid = new SphereGridSurface(2);

            grid.StepYForward();
            grid.StepYForward();
            grid.StepYForward();
            grid.StepYForward();

            Assert.AreEqual(1, grid.Y);
        }

        [TestMethod]
        public void Sphere_IncreaseYMoreThanSizeBy2AndXIncrease1_Y1X1()
        {
            var grid = new SphereGridSurface(2);

            grid.StepYForward();
            grid.StepYForward();
            grid.StepYForward();
            grid.StepYForward();

            grid.StepXForward();

            Assert.AreEqual(1, grid.Y);
            Assert.AreEqual(1, grid.X);
        }
        #endregion

        #region Obstacles Test
        [TestMethod]
        public void Sphere_MoveToAnObstacle_ReturnToLastPoint()
        {
            var grid = new SphereGridSurface(100, new List<Obstacle> { new Obstacle(1, 1) });

            grid.StepYForward();
            grid.StepXForward();

            Assert.AreEqual(1, grid.Y);
            Assert.AreEqual(0, grid.X);
        }
        #endregion

    }
}
