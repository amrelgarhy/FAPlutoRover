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

        [TestMethod]
        public void North_TurnLeft4Times_BackToNorth()
        {
            var direction = new North(surface);
            var updatedDirection = direction.TurnLeft().TurnLeft().TurnLeft().TurnLeft();

            Assert.IsInstanceOfType(updatedDirection, typeof(North));
        }

        [TestMethod]
        public void North_TurnRight4Times_BackToNorth()
        {
            var direction = new North(surface);
            var updatedDirection = direction.TurnRight().TurnRight().TurnRight().TurnRight();

            Assert.IsInstanceOfType(updatedDirection, typeof(North));
        }

        [TestMethod]
        public void North_TurnRightThenLeft_BackToNorth()
        {
            var direction = new North(surface);
            var updatedDirection = direction.TurnRight().TurnLeft();

            Assert.IsInstanceOfType(updatedDirection, typeof(North));
        }

        [TestMethod]
        public void North_TurnLeftThenRight_BackToNorth()
        {
            var direction = new North(surface);
            var updatedDirection = direction.TurnLeft().TurnRight();

            Assert.IsInstanceOfType(updatedDirection, typeof(North));
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

        [TestMethod]
        public void East_TurnLeft4Times_BackToEast()
        {
            var direction = new East(surface);
            var updatedDirection = direction.TurnLeft().TurnLeft().TurnLeft().TurnLeft();

            Assert.IsInstanceOfType(updatedDirection, typeof(East));
        }

        [TestMethod]
        public void East_TurnRight4Times_BackToEast()
        {
            var direction = new East(surface);
            var updatedDirection = direction.TurnRight().TurnRight().TurnRight().TurnRight();

            Assert.IsInstanceOfType(updatedDirection, typeof(East));
        }

        [TestMethod]
        public void East_TurnRightThenLeft_BackToEast()
        {
            var direction = new East(surface);
            var updatedDirection = direction.TurnRight().TurnLeft();

            Assert.IsInstanceOfType(updatedDirection, typeof(East));
        }

        [TestMethod]
        public void East_TurnLeftThenRight_BackToEast()
        {
            var direction = new East(surface);
            var updatedDirection = direction.TurnLeft().TurnRight();

            Assert.IsInstanceOfType(updatedDirection, typeof(East));
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

        [TestMethod]
        public void South_TurnLeft4Times_BackToSouth()
        {
            var direction = new South(surface);
            var updatedDirection = direction.TurnLeft().TurnLeft().TurnLeft().TurnLeft();

            Assert.IsInstanceOfType(updatedDirection, typeof(South));
        }

        [TestMethod]
        public void South_TurnRight4Times_BackToSouth()
        {
            var direction = new South(surface);
            var updatedDirection = direction.TurnRight().TurnRight().TurnRight().TurnRight();

            Assert.IsInstanceOfType(updatedDirection, typeof(South));
        }

        [TestMethod]
        public void South_TurnRightThenLeft_BackToSouth()
        {
            var direction = new South(surface);
            var updatedDirection = direction.TurnRight().TurnLeft();

            Assert.IsInstanceOfType(updatedDirection, typeof(South));
        }

        [TestMethod]
        public void South_TurnLeftThenRight_BackToSouth()
        {
            var direction = new South(surface);
            var updatedDirection = direction.TurnLeft().TurnRight();

            Assert.IsInstanceOfType(updatedDirection, typeof(South));
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

        [TestMethod]
        public void West_TurnLeft4Times_BackToWest()
        {
            var direction = new West(surface);
            var updatedDirection = direction.TurnLeft().TurnLeft().TurnLeft().TurnLeft();

            Assert.IsInstanceOfType(updatedDirection, typeof(West));
        }

        [TestMethod]
        public void West_TurnRight4Times_BackToWest()
        {
            var direction = new West(surface);
            var updatedDirection = direction.TurnRight().TurnRight().TurnRight().TurnRight();

            Assert.IsInstanceOfType(updatedDirection, typeof(West));
        }

        [TestMethod]
        public void West_TurnRightThenLeft_BackToWest()
        {
            var direction = new West(surface);
            var updatedDirection = direction.TurnRight().TurnLeft();

            Assert.IsInstanceOfType(updatedDirection, typeof(West));
        }

        [TestMethod]
        public void West_TurnLeftThenRight_BackToWest()
        {
            var direction = new West(surface);
            var updatedDirection = direction.TurnLeft().TurnRight();

            Assert.IsInstanceOfType(updatedDirection, typeof(West));
        }
        #endregion

    }
}
