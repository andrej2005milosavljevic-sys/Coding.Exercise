using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordUnscrambler.Data;
using WordUnscrambler.Workers;

namespace WordUnscrambler
{
   
    public class Program
    {
        private const string wordlist = "wordlist.txt";
        private static readonly FileReader _fileReader = new FileReader();
        private static readonly WordMatcher _wordMatcher = new WordMatcher();
        static void Main(string[] args)
        {
            bool continueUnscrambling = true;
            do
            {

                Console.WriteLine("Please enter the option - M for manual unscrambling, or F for file unscrambling:");
                var option = Console.ReadLine() ?? string.Empty;

                switch (option.ToUpper())
                {
                    case "M":
                        Console.WriteLine("Enter scrambled words manually:");
                        ManualUnscramble();
                        break;
                    case "F":
                        Console.WriteLine("Enter the scrambled words file name:");
                        FileUnscramble();
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        continue;
                }
                var continueInput = string.Empty;
                do
                {

                    Console.WriteLine("Do you want to continue? (Y/N):");
                    continueInput = Console.ReadLine() ?? string.Empty;

                } while (!continueInput.Equals("Y", StringComparison.OrdinalIgnoreCase) && !continueInput.Equals("N", StringComparison.OrdinalIgnoreCase));
                continueUnscrambling = continueInput.Equals("Y", StringComparison.OrdinalIgnoreCase);

            } while (continueUnscrambling);
            
        }

        private static void FileUnscramble()
        {
            var filename = Console.ReadLine() ?? string.Empty;
            string[] scrambledWords = _fileReader.Read(filename);
            DisplayMatchedWords(scrambledWords);


        }

        private static void ManualUnscramble()
        {
            var manualInput = Console.ReadLine() ?? string.Empty;
            string[] scrambledWords = manualInput.Split(',');
            DisplayMatchedWords(scrambledWords);
        }

        private static void DisplayMatchedWords(string[] scrambledWords)
        {
            string[] wordList;
            try
            {
                wordList = _fileReader.Read(wordlist);
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Invalid file or word list.");
                return;
            }
            List<MatchedWord> matchedWords = _wordMatcher.Match(scrambledWords, wordList);
            if (matchedWords.Any())
            {
                foreach (var matchedWord in matchedWords)
                {
                    Console.WriteLine($"Scrambled: {matchedWord.ScrambledWord}, Matched: {matchedWord.Word}");
                }
            }
            else
            {
                Console.WriteLine("No matches found");
            }
        }
    }
}
