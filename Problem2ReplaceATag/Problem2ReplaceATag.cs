using System;
using System.Text.RegularExpressions;

class Problem2ReplaceATag
{
    public static void Main()
    {
        // The string in which the <a href=> tags wil be replaced with [URL]
        string inputHTMLDocument = "<ul><li><a href=http://softuni.bg>SoftUni</a></li></ul>";
        // Regex matching literally <a href=(group 1 matching [any word character and also : / .] with lenght 1 to infinite)>(group 2 which will match any word characted 1 to ininity)<\/a>
        string pattern = @"<a href=([\w:\/\.]+)>(\w+)<\/a>";
        // string pattern = @"<a href=(.*)>(.*)<\/a>"; // Improved variant which will match more links and texts
        // Replace the matched <a href= links with URL ones using the content in group 1 as $1 and group 2 as $2
        string result = Regex.Replace(inputHTMLDocument, pattern, "[URL href=$1]$2[/URL]");

        Console.WriteLine(result);

        Console.Write("Press any key to continue . . . ");
        Console.ReadKey(true);
    }
}