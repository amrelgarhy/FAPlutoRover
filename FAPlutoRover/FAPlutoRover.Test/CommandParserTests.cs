using System;
using FAPlutoRover.Commands;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FAPlutoRover.Test
{
    [TestClass]
    public class CommandParserTests
    {
        [TestMethod]
        public void Commands_PassFBLR_GivesForwardBackwardLeftRightCommandsInSequance()
        {
            var parser = new CommandParser("FBLR");

            Assert.IsInstanceOfType(parser.Commands[0], typeof(Forward));
            Assert.IsInstanceOfType(parser.Commands[1], typeof(Backward));
            Assert.IsInstanceOfType(parser.Commands[2], typeof(Left));
            Assert.IsInstanceOfType(parser.Commands[3], typeof(Right));
        }


        [TestMethod]
        public void Commands_PassEmpty_GivesEmptyListOfCommands()
        {
            var parser = new CommandParser("");

            Assert.AreEqual(0, parser.Commands.Count);
        }


        [TestMethod]
        public void Commands_PassWrongCommandText_GivesEmptyListOfCommands()
        {
            var parser = new CommandParser("AZ");

            Assert.AreEqual(0, parser.Commands.Count);
        }


        [TestMethod]
        public void Commands_PassCommandTextHas3CorrectCommandAnd1Wronf_GivesListOf3Commands()
        {
            var parser = new CommandParser("FLAB");

            Assert.AreEqual(3, parser.Commands.Count);
        }
    }
}
