using UnitTestLab_Roshambo;
using Xunit;

namespace UnitTestLab_RoshamboTests
{
    public class UnitTestLab_RoshamboTests
    {
        [Fact]
        public void RockBeatsScissorsTest()
        {
            //Arrange
            string firstPlayer = "Rock";
            string secondPlayer = "Scissors";
            string expected = "Rock beat Scissors";
            RoshamboClass roshamboClass = new RoshamboClass();

            //Act
            var actual = roshamboClass.Play(firstPlayer, secondPlayer);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PaperBeatsRockTest()
        {
            //Arrange
            string firstPlayer = "Paper";
            string secondPlayer = "Rock";
            string expected = "Paper beat Rock";
            RoshamboClass roshamboClass = new RoshamboClass();

            //Act
            var actual = roshamboClass.Play(firstPlayer, secondPlayer);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ScissorsBeatsPaper()
        {
            //Arrange
            string firstPlayer = "Scissors";
            string secondPlayer = "Paper";
            string expected = "Scissors beat Paper";
            RoshamboClass roshamboClass = new RoshamboClass();

            //Act
            var actual = roshamboClass.Play(firstPlayer, secondPlayer);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}