using Xunit;
using bowlinggame.kata;

namespace bowlinggame.Tests
{
    public class GameTests
    {
        [Fact]
        public void CanCreateGameTest()
        {
            //Arrange

            //Act
            var game = new Game();

            //Assert
            Assert.NotNull(game);
        }
    }
}