using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

class Problem6ExtractHyperlinks
{
    public static void Main()
    {
        // PROBLEM ASSIGNMENT
        //
        // Write a program to extract all hyperlinks (<href=…>) from a given HTML text. 
        // The text comes from the console on a variable number of lines and ends with the command "END".
        // Print at the console the href values in the text.
        // The input text is standard HTML code.
        // It may hold many tags and can be formatted in many different forms (with or without whitespace).
        // The <a> elements may have many attributes, not only href.
        // You should extract only the values of the href attributes of all <a> elements.

        StringBuilder inputText = new StringBuilder();
        string inputRow = Console.ReadLine();
        while (inputRow != "END")
        {
            if (inputRow != "END")
            {
                inputText.Append(inputRow);
            }
            inputRow = Console.ReadLine();
        }
        string pattern = @"(?:<a)(?:[\s\n\w=""()]*?.*?)(?:href([\s\n]*)?=(?:['""\s\n]*)?)([:#\/.\-\w!?=^+]*(\([""'a-zA-Z\s.()0-9]*\))?)(?:[\s\na-zA-Z=""()0-9]*.*?)?(?:\>)";
        MatchCollection hyperlinkMatches = Regex.Matches(inputText.ToString(), pattern);
        for (int i = 0; i < hyperlinkMatches.Count; i++)
        {
            Console.WriteLine(hyperlinkMatches[i].Groups[2]);
        }
    }
}