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

        [Fact]
        public void CanBowlSpareTest()
        {
            // Given
            game.Roll(5);
            game.Roll(5);
            game.Roll(2);
            game.Roll(2);
            RollMany(16, 0);

            // When
            var score = game.Score();

            // Then
            Assert.True(16 == score);
        }

        [Fact]
        public void CanBowlStrikeTest()
        {
            // Given
            game.Roll(10);
            game.Roll(5);
            game.Roll(2);
            game.Roll(2);
            RollMany(15, 0);

            // When
            var score = game.Score();

            // Then
            Assert.True(26 ==score);
        }

        private void RollMany(Int32 rolls, Int32 pins)
        {
            for (var roll=0; roll<rolls; roll++)
                game.Roll(pins);
        }
    }
}