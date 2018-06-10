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

        #region North Tests
        [TestMethod]
        public void North_TurnLeft_ShouldFaceWest()
        {
            var direction = new North(surface);
            var updatedDirection = direction.TurnLeft();

            Assert.IsInstanceOfType(updatedDirection, typeof(West));
        }

        [TestMethod]
        public void North_TurnRight_ShouldFaceEast()
        {
            var direction = new North(surface);
            var updatedDirection = direction.TurnRight();

            Assert.IsInstanceOfType(updatedDirection, typeof(East));
        }
        #endregion

        #region East Tests
        [TestMethod]
        public void East_TurnLeft_ShouldFaceNorth()
        {
            var direction = new East(surface);
            var updatedDirection = direction.TurnLeft();

            Assert.IsInstanceOfType(updatedDirection, typeof(North));
        }

        [TestMethod]
        public void East_TurnRight_ShouldFaceSouth()
        {
            var direction = new East(surface);
            var updatedDirection = direction.TurnRight();

            Assert.IsInstanceOfType(updatedDirection, typeof(South));
        }
        #endregion

        #region South Tests
        [TestMethod]
        public void South_TurnLeft_ShouldFaceEast()
        {
            var direction = new South(surface);
            var updatedDirection = direction.TurnLeft();

            Assert.IsInstanceOfType(updatedDirection, typeof(East));
        }

        [TestMethod]
        public void South_TurnRight_ShouldFaceWest()
        {
            var direction = new South(surface);
            var updatedDirection = direction.TurnRight();

            Assert.IsInstanceOfType(updatedDirection, typeof(West));
        }
        #endregion

        #region West Tests
        [TestMethod]
        public void West_TurnLeft_ShouldFaceSouth()
        {
            var direction = new West(surface);
            var updatedDirection = direction.TurnLeft();

            Assert.IsInstanceOfType(updatedDirection, typeof(South));
        }

        [TestMethod]
        public void West_TurnRight_ShouldFaceNorth()
        {
            var direction = new West(surface);
            var updatedDirection = direction.TurnRight();

            Assert.IsInstanceOfType(updatedDirection, typeof(North));
        }
        #endregion
    }
}
