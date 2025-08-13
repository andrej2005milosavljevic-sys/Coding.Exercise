using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WordUnscrambler.Workers;

namespace WorldUnscrambler.Test.Unit
{
    [TestClass]
    public class WordMatcherTest
    {
        private readonly WordMatcher _wordMatcher = new WordMatcher();
        [TestMethod]
        public void TestMethod1()
        {
            string[] words = { "cat", "dog", "rock" };
            string[] scrambledWords = { "tca" };
            var matchedWords = _wordMatcher.Match(scrambledWords, words);

            Assert.IsTrue(matchedWords.Count == 1);
            Assert.IsTrue(matchedWords[0].ScrambledWord.Equals("tca"));
            Assert.IsTrue(matchedWords[0].Word.Equals("cat"));
        }
    }
}
