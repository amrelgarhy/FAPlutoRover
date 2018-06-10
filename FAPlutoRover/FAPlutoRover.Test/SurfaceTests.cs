using System;
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


        #endregion

    }
}
