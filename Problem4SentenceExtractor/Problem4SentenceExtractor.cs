using System;
using System.Text.RegularExpressions;

class Problem4SentenceExtractor
{
    public static void Main()
    {
        string keyword = "Paris";
        string inputText = "This is my cat! And this is my dog. We happily live in Paris – the most beautiful city in the world! Isn’t it great? Well it is :)";
        string pattern = @"(?<=[\.\?\!]|^)([\w\s\’\–]*?)\b" + keyword + @"\b([\w\s\’\–]*?)[\.\?\!]";
        // Simpler version of the pattern - not mine (Filip Kolev SoftUni)
        // string pattern = @"\b[^.?!]+\b" + keyword + @"\b.*?[!.?]";
        MatchCollection sentenceMatchCollection = Regex.Matches(inputText, pattern);

        foreach (var sentence in sentenceMatchCollection)
        {
            Console.WriteLine(sentence.ToString().Trim());
        }

        Console.Write("Press any key to continue . . . ");
        Console.ReadKey(true);
    }
}