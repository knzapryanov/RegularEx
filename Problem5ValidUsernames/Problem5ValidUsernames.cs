using System;
using System.Text.RegularExpressions;

class Problem5ValidUsernames
{
    public static void Main()
    {
        string inputString = Console.ReadLine(); //@"chico/ gosho \ sapunerka (3sas) mazut  lelQ_Van4e";
        string pattern = @"(?<=[ \\\/()]|^)(?<username>[A-Za-z]\w{2,24})(?=[ \\\/()]|$)";
        MatchCollection usernamesMatchCollection = Regex.Matches(inputString, pattern);
        int currentLenghtCount = 0;
        int highestLenghtCount = 0;
        int usernameOneIndex = 0;
        int usernameTwoIndex = 0;
        for (int i = 0; i < usernamesMatchCollection.Count - 1; i++)
        {
            currentLenghtCount = usernamesMatchCollection[i].Length + usernamesMatchCollection[i + 1].Length;
            if (currentLenghtCount > highestLenghtCount)
            {
                highestLenghtCount = currentLenghtCount;
                usernameOneIndex = i;
                usernameTwoIndex = i + 1;
            }
        }
        Console.WriteLine(usernamesMatchCollection[usernameOneIndex]);
        Console.WriteLine(usernamesMatchCollection[usernameTwoIndex]);
    }
}