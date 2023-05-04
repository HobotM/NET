using System.Text.RegularExpressions;


string test1 = "QWE QWE QWE QWE EEE EWQQWEEE qwe Qweqw Eqweqweqw Eqwe qwe";
string test2 = "qweqweqweqweqweqweqweqweqWe";

Regex CapWords = new Regex(@"[A-Z]\w+");

// Replace content
string result = CapWords.Replace(test1, "****");
System.Console.WriteLine(test1);
System.Console.WriteLine(result);

// delegate that computes the new value of the replacement

string makeUpper(Match m) {
    string s = m.ToString();

    if(m.Index == 0)
    {
        return s;
    }

    return s.ToUpper();
}

string upperstr = CapWords.Replace(test1, new MatchEvaluator(makeUpper));
System.Console.WriteLine(test1);
System.Console.WriteLine(upperstr);
