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
    }
}
