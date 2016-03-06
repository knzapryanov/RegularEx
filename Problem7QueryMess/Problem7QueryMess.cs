using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;
using System.Collections.Generic;

class Problem7QueryMess
{
    public static void Main()
    {
        Dictionary<string, string> pairsDictionary = new Dictionary<string, string>();
        List<StringBuilder> finalRows = new List<StringBuilder>();
        string matchPairsPattern = @"(?<=&|^|\?)(?<key>[^&?]+)=(?<value>[^&?]+)(?=$|&|\?)";
        string matchTrimStart = @"^(\+|%20)*";
        string matchTrimEnd = @"(\+|%20)*$";
        string matchTrimMiddle = @"(?<trim>\+|%20)+";
        string inputRow = Console.ReadLine();
        while (inputRow != "END")
        {
            MatchCollection pairsMatchCollection = Regex.Matches(inputRow, matchPairsPattern);
            for (int i = 0; i < pairsMatchCollection.Count; i++)
            {
                string finalKey = Regex.Replace(pairsMatchCollection[i].Groups["key"].Value, matchTrimStart, "");
                finalKey = Regex.Replace(finalKey, matchTrimEnd, "");
                finalKey = Regex.Replace(finalKey, matchTrimMiddle, " ");
                string finalValue = Regex.Replace(pairsMatchCollection[i].Groups["value"].Value, matchTrimStart, "");
                finalValue = Regex.Replace(finalValue, matchTrimEnd, "");
                finalValue = Regex.Replace(finalValue, matchTrimMiddle, " ");
                if (pairsDictionary.ContainsKey(finalKey))
                {
                    pairsDictionary[finalKey] =
                        pairsDictionary[finalKey] + ", " + finalValue;
                }
                else
                {
                    pairsDictionary[finalKey] = finalValue;
                }
            }

            StringBuilder currentRow = new StringBuilder();
            foreach (var pair in pairsDictionary)
            {
                currentRow.Append(pair.Key);
                currentRow.Append("=");
                currentRow.Append("[");
                currentRow.Append(pair.Value);
                currentRow.Append("]");
            }
            finalRows.Add(currentRow);
            pairsDictionary.Clear();
            inputRow = Console.ReadLine();
        }

        foreach (var finalRow in finalRows)
        {
            Console.WriteLine(finalRow.ToString());
        }
    }
}