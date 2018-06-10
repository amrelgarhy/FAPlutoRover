using FAPlutoRover.Directions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FAPlutoRover.Test
{
    [TestClass]
    public class RoverTests
    {
        [TestMethod]
        public void PlutoRover_Created_ShouldFaceNorth()
        {
            var rover = new PlutoRover(new GridSurface(100));

            Assert.IsInstanceOfType(rover.Direction, typeof(North));
        }

        [TestMethod]
        public void PlutoRover_FirstTurnLeft_FaceWest()
        {
            var rover = new PlutoRover(new GridSurface(100));

            rover.TurnLeft();

            Assert.IsInstanceOfType(rover.Direction, typeof(West));
        }

        [TestMethod]
        public void PlutoRover_FirstTurnRight_FaceEast()
        {
            var rover = new PlutoRover(new GridSurface(100));

            rover.TurnRight();

            Assert.IsInstanceOfType(rover.Direction, typeof(East));
        }

        [TestMethod]
        public void PlutoRover_FirstMoveForward_FaceNorth()
        {
            var rover = new PlutoRover(new GridSurface(100));

            rover.Forward();

            Assert.IsInstanceOfType(rover.Direction, typeof(North));
        }

        [TestMethod]
        public void PlutoRover_FirstMoveForward_XZeroY1()
        {
            var rover = new PlutoRover(new GridSurface(100));

            rover.Forward();

            Assert.AreEqual(rover.X, 0);
            Assert.AreEqual(rover.Y, 1);
        }

        [TestMethod]
        public void PlutoRover_FirstMoveForwardThenLeft_XZeroY1FaceWest()
        {
            var rover = new PlutoRover(new GridSurface(100));

            rover.Forward();
            rover.TurnLeft();

            Assert.AreEqual(rover.X, 0);
            Assert.AreEqual(rover.Y, 1);
            Assert.IsInstanceOfType(rover.Direction, typeof(West));
        }

        [TestMethod]
        public void PlutoRover_FirstMoveForwardThenBackward_XZeroY0FaceNorth()
        {
            var rover = new PlutoRover(new GridSurface(100));

            rover.Forward();
            rover.Backward();

            Assert.AreEqual(rover.X, 0);
            Assert.AreEqual(rover.Y, 0);
            Assert.IsInstanceOfType(rover.Direction, typeof(North));
        }


        [TestMethod]
        public void PlutoRover_FirstTurnLeftMoveBackward_X1Y0FaceWest()
        {
            var rover = new PlutoRover(new GridSurface(100));

            rover.TurnLeft();
            rover.Backward();

            Assert.AreEqual(rover.X, 1);
            Assert.AreEqual(rover.Y, 0);
            Assert.IsInstanceOfType(rover.Direction, typeof(West));
        }

    }
}
