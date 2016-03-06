using System;
using System.Text.RegularExpressions;

class Problem3ExtractEmails
{
    public static void Main()
    {
        string inputString = "•	Examples of valid emails: info@softuni-bulgaria.org, kiki@hotmail.co.uk, no-reply@github.com, s.peterson@mail.uu.net, info-bg@software-university.software.academy."
                                + "•	Examples of invalid emails: --123@gmail.com, …@mail.bg, .info@info.info, _steve@yahoo.cn, mike@helloworld, mike@.unknown.soft., s.johnson@invalid-.";

        string pattern = @"(?<=\ )[A-Za-z0-9][\w\-\.]*[A-Za-z0-9]@[A-Za-z][A-Za-z\-\.]*\.[A-Za-z\-\.]{1,}[A-Za-z]";
        MatchCollection emailsMatchCollection = Regex.Matches(inputString, pattern);
        foreach (var email in emailsMatchCollection)
        {
            Console.WriteLine(email);
        }
    }
}