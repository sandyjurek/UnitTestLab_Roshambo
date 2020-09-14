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
    }
}