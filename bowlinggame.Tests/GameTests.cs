using System;
using Xunit;
using bowlinggame.kata;

namespace bowlinggame.Tests
{
    public class GameTests
    {
        private Game game = new Game();

        [Fact]
        public void CanCreateGameTest()
        {
            // Given
            // When
            // Then
            Assert.NotNull(game);
        }

        [Fact]
        public void CanBowlGutterGameTest()
        {
            // Given
            RollMany(20, 0);

            // When
            var score = game.Score();

            // Then
            Assert.True(0 == score);
        }

        [Fact]
        public void CanBowlAllOnesTest()
        {
            // Given
            RollMany(20, 1);

            // When
            var score = game.Score();

            // Then 
            Assert.True(20 == score);
        }

        private void RollMany(Int32 rolls, Int32 pins)
        {
            for (var roll=0; roll<rolls; roll++)
                game.Roll(pins);
        }
    }
}