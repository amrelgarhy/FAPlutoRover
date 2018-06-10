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
    }
}
