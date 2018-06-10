using System;
using FAPlutoRover.Directions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FAPlutoRover.Test
{
    [TestClass]
    public class Directions
    {
        ISurface surface;

        [TestInitialize]
        public void Init()
        {
            surface = new GridSurface();
        }

        [TestMethod]
        public void North_TurnLeft_ShouldFaceWest()
        {
            var direction = new North(surface);
            var updatedDirection = direction.TurnLeft();

            Assert.IsInstanceOfType(updatedDirection, typeof(West));
        }
    }
}
