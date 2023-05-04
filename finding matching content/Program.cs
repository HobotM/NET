using System.Text.RegularExpressions;

string test1 = "QWE QWE QWE QWE EEE EWQQWEEE qwe qweqw eqweqweqw eqwe qwe";
string test2 = "qweqweqweqweqweqweqweqweqWe";

// IsMatch funtrion to determine the content of string

Regex CapWords = new Regex(@"[A-Z]\w+");

System.Console.WriteLine(CapWords.IsMatch(test1));
System.Console.WriteLine(CapWords.IsMatch(test2));

// Regex to argument used to perfoem case sens searches

Regex NoCase = new Regex (@"qeewee", RegexOptions.IgnoreCase);
System.Console.WriteLine(NoCase.IsMatch(test1));

// Match to get info about specific reges matches for given pattern

Match m = CapWords.Match(test1);
while(m.Success) {
    System.Console.WriteLine($"'{m.Value}' found at position {m.Index}");
    m = m.NextMatch();
}


// Matches returns a collection of match objects

MatchCollection mc = CapWords.Matches(test1);
System.Console.WriteLine($"Found{mc.Count} matches:");
foreach(Match match in mc)
{
    System.Console.WriteLine($"{match.Value} found at position {match.Index}");
}