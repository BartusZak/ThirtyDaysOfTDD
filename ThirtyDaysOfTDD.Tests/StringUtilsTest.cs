using Xunit;

namespace ThirtyDaysOfTDD.Tests
{
    
    public class StringUtilsTest
    {
        [Fact]
        public void ShouldBeAbleToCountNumberOfLettersInSimpleSentence()
        {
            //arange
            Sentence sentence = new Sentence();

            //act
            int result = sentence.CountNumberOfLetters("Bartek");

            //asserts
            Assert.Equal(6, result);

        }
    }
}
