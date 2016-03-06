using System;
using System.Text.RegularExpressions;

class Problem1SeriesOfLetters
{
    public static void Main()
    {
        string inputString = Console.ReadLine(); // aaaaabbbbbcdddeeeedssaa
        string pattern = @"(\w)\1+";
        //			Regex regex = new Regex(pattern);
        //			MatchCollection matchCollection = Regex.Matches(inputString, pattern);
        //			Console.WriteLine(matchCollection.Count);
        string result = Regex.Replace(inputString, pattern, "$1");
        Console.WriteLine(result);

        Console.Write("Press any key to continue . . . ");
        Console.ReadKey(true);
    }
}