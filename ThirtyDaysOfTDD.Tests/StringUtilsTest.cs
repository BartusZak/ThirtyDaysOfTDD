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

        [Fact]
        public void ShouldBeAbleToCountSpecificNumberOfLettersInSimpleSentence()
        {
            //arange
            Sentence sentence = new Sentence();;
            string word = "Adamiakowa";
            char letter = 'a';

            //act
            int result = sentence.CountNumberOfSpecificLetters(word, letter);

            //asserts
            Assert.Equal(4, result);

        }
    }
}
