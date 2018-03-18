using System;

namespace ThirtyDaysOfTDD
{
    public class Sentence
    {
        public int CountNumberOfLetters(string word) => word.Length;

        public int CountNumberOfSpecificLetters(string word, char letter)
        {
            int letterCount = 0;

            word = word.ToLower();
            char lowerLetter = char.ToLower(letter);

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == lowerLetter)
                {
                    letterCount++;
                }
            }

            return letterCount;
        }
    }
}
