using sick_emoji_2;
using System;
using Xunit;

namespace EmojiTests
{
    public class SmielyEmojiUnitTest
    {
        [Fact]
        public void Gets_Back_SmilingEmoji()
        {
            //arrange
            var smiley = new Smiley();

            // act
            var emoji = smiley.Emoji;

            // assert
            Assert.Equal("😊", emoji);
        }
    }
}
