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

            Assert.AreEqual(0, rover.X);
            Assert.AreEqual(1, rover.Y);
        }

        [TestMethod]
        public void PlutoRover_FirstMoveForwardThenLeft_XZeroY1FaceWest()
        {
            var rover = new PlutoRover(new GridSurface(100));

            rover.Forward();
            rover.TurnLeft();

            Assert.AreEqual(0, rover.X);
            Assert.AreEqual(1, rover.Y);
            Assert.IsInstanceOfType(rover.Direction, typeof(West));
        }

        [TestMethod]
        public void PlutoRover_FirstMoveForwardThenBackward_XZeroY0FaceNorth()
        {
            var rover = new PlutoRover(new GridSurface(100));

            rover.Forward();
            rover.Backward();

            Assert.AreEqual(0, rover.X);
            Assert.AreEqual(0, rover.Y);
            Assert.IsInstanceOfType(rover.Direction, typeof(North));
        }


        [TestMethod]
        public void PlutoRover_FirstTurnLeftMoveBackward_X1Y0FaceWest()
        {
            var rover = new PlutoRover(new GridSurface(100));

            rover.TurnLeft();
            rover.Backward();

            Assert.AreEqual(1, rover.X);
            Assert.AreEqual(0, rover.Y);
            Assert.IsInstanceOfType(rover.Direction, typeof(West));
        }


        [TestMethod]
        public void PlutoRover_Move2Forward_TurnRight_Move2Forward_TurnRight_Move2Forward_TurnRight_Move2Forward_TurnRight__FaceNorthX0Y0()
        {
            var rover = new PlutoRover(new GridSurface(100));

            rover.Forward();
            rover.Forward();
            rover.TurnRight();

            rover.Forward();
            rover.Forward();
            rover.TurnRight();

            rover.Forward();
            rover.Forward();
            rover.TurnRight();

            rover.Forward();
            rover.Forward();
            rover.TurnRight();

            Assert.AreEqual(0, rover.X);
            Assert.AreEqual(0, rover.Y);
            Assert.IsInstanceOfType(rover.Direction, typeof(North));
        }


        #region Commands
        [TestMethod]
        public void PlutoRoverCommand_F_Yis1()
        {
            var rover = new PlutoRover(new GridSurface(100));

            rover.ExecuteCommand("F");

            Assert.AreEqual(1, rover.Y);
        }

        [TestMethod]
        public void PlutoRoverCommand_FFB_Y1X0()
        {
            var rover = new PlutoRover(new GridSurface(100));

            rover.ExecuteCommand("FFB");

            Assert.AreEqual(1, rover.Y);
            Assert.AreEqual(0, rover.X);
        }

        [TestMethod]
        public void PlutoRoverCommand_FFRFF_Y2X2East()
        {
            var rover = new PlutoRover(new GridSurface(100));

            rover.ExecuteCommand("FFRFF");

            Assert.AreEqual(2, rover.Y);
            Assert.AreEqual(2, rover.X);

            Assert.IsInstanceOfType(rover.Direction, typeof(East));
        }
        #endregion

        #region sphere grid
        [TestMethod]
        public void PlutoRoverCommandWithSphereGrid_FFRFF_Y2X2East()
        {
            var rover = new PlutoRover(new SphereGridSurface(100));

            rover.ExecuteCommand("FFRFF");

            Assert.AreEqual(2, rover.Y);
            Assert.AreEqual(2, rover.X);

            Assert.IsInstanceOfType(rover.Direction, typeof(East));
        }

        [TestMethod]
        public void PlutoRoverCommandWithSphereGrid_FFFRFFF_ReturnTo00East()
        {
            var rover = new PlutoRover(new SphereGridSurface(2));

            rover.ExecuteCommand("FFFRFFF");

            Assert.AreEqual(0, rover.Y);
            Assert.AreEqual(0, rover.X);

            Assert.IsInstanceOfType(rover.Direction, typeof(East));
        }

        [TestMethod]
        public void PlutoRoverCommandWithSphereGrid_FFFFRFFFF_ShouldNotReturnTo00East()
        {
            var rover = new PlutoRover(new SphereGridSurface(2));

            rover.ExecuteCommand("FFFFRFFFF");

            Assert.AreNotEqual(0, rover.Y);
            Assert.AreNotEqual(0, rover.X);

            Assert.IsInstanceOfType(rover.Direction, typeof(East));
        }
        #endregion
    }

}
