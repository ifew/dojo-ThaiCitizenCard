using System;
using Xunit;

namespace ThaiCitizenCard
{
    public class ThaiCitizenCardTest
    {
        [Fact]
        public void Input_1234567890_Should_Be_False()
        {
            var inputCitizenCard = "1234567890";

            ThaiCitizenCard thaiCitizenCard = new ThaiCitizenCard();
            bool actual = thaiCitizenCard.CheckPattern(inputCitizenCard);

            Assert.False(actual);
        }
        [Fact]
        public void Input_0234567890123_Should_Be_False()
        {
            var inputCitizenCard = "0234567890123";

            ThaiCitizenCard thaiCitizenCard = new ThaiCitizenCard();
            bool actual = thaiCitizenCard.CheckPattern(inputCitizenCard);

            Assert.False(actual);
        }

        [Fact]
        public void Input_9234567890123_Should_Be_False()
        {
            var inputCitizenCard = "9234567890123";

            ThaiCitizenCard thaiCitizenCard = new ThaiCitizenCard();
            bool actual = thaiCitizenCard.CheckPattern(inputCitizenCard);

            Assert.False(actual);
        }

        [Fact]
        public void Input_1234567890123_Should_Be_False()
        {
            var inputCitizenCard = "1234567890123";

            ThaiCitizenCard thaiCitizenCard = new ThaiCitizenCard();
            bool actual = thaiCitizenCard.CheckPattern(inputCitizenCard);

            Assert.False(actual);
        }

        [Fact]
        public void Input_1234567890121_Should_Be_True()
        {
            var inputCitizenCard = "1234567890121";

            ThaiCitizenCard thaiCitizenCard = new ThaiCitizenCard();
            bool actual = thaiCitizenCard.CheckPattern(inputCitizenCard);

            Assert.True(actual);
        }

        [Fact]
        public void Input_4717321215462_Should_Be_True()
        {
            var inputCitizenCard = "4717321215462";

            ThaiCitizenCard thaiCitizenCard = new ThaiCitizenCard();
            bool actual = thaiCitizenCard.CheckPattern(inputCitizenCard);

            Assert.True(actual);
        }

        [Fact]
        public void Input_1234567890121_Should_Be_1234567890121_Is_True()
        {
            var inputCitizenCard = "1234567890121";
            var expected = "1234567890121";

            ThaiCitizenCard thaiCitizenCard = new ThaiCitizenCard();
            string actual = thaiCitizenCard.GetCitizenCardNumber(inputCitizenCard);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Input_4717321215462_Should_Be_4717321215462_Is_True()
        {
            var inputCitizenCard = "4717321215462";
            var expected = "4717321215462";

            ThaiCitizenCard thaiCitizenCard = new ThaiCitizenCard();
            string actual = thaiCitizenCard.GetCitizenCardNumber(inputCitizenCard);

            Assert.Equal(expected, actual);
        }
    }
}
