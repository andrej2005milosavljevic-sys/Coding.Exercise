using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordUnscrambler.Data;

namespace WordUnscrambler.Workers
{
    public class WordMatcher
    {
         public List<MatchedWord> Match(string[] scrambledWords, string[] wordList)
        {
            var matchedWordList = new List<MatchedWord>();

            foreach (var scrambledWord in scrambledWords)
            {
                foreach (var word in wordList)
                {
                    if (scrambledWord.Equals(word, StringComparison.OrdinalIgnoreCase))
                    {
                        matchedWordList.Add(BuildMatchedWord(scrambledWord, word));
                    }
                    else
                    {
                        var scrambledwordArray = scrambledWord.ToCharArray();
                        var wordArray = word.ToCharArray();

                        Array.Sort(scrambledwordArray);
                        Array.Sort(wordArray);

                        var sortedScrambledWord = new string(scrambledwordArray);
                        var sortedWord = new string(wordArray);
                        if (sortedScrambledWord.Equals(sortedWord, StringComparison.OrdinalIgnoreCase))
                        {
                            matchedWordList.Add(BuildMatchedWord(scrambledWord, word));
                        }
                    }
                }


            }

            return matchedWordList;
        }
        private MatchedWord BuildMatchedWord(string scrambledWord, string word)
        {
            MatchedWord matchedWord = new MatchedWord
            {
                ScrambledWord = scrambledWord,
                Word = word
            };
            return matchedWord;
        }
    }
}
