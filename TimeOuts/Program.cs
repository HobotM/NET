using System.Text.RegularExpressions;
using System.Diagnostics;

const string thestr = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

// use a StopWatch to show elapsed time
Stopwatch sw;

// Use a timeout value when executing RegEx to guard against bad input

const int MAX_REGEX_TIME = 1000;
TimeSpan timeout = TimeSpan.FromMilliseconds(MAX_REGEX_TIME);

// Run the expression and output the result

try{
    sw = Stopwatch.StartNew();
    Regex CapWords = new Regex(@"(a+a+)+b", RegexOptions.None, timeout);
    MatchCollection mc = CapWords.Matches(thestr);
    sw.Stop();
    System.Console.WriteLine($"Found {mc.Count} matches in {sw.Elapsed} time:");
    foreach( Match match in mc){
        System.Console.WriteLine($"'{match.Value}' found at position {match.Index}");
    }

}
catch (RegexMatchTimeoutException e)
{
System.Console.WriteLine($"The regex timeout tool too long to execute! {e.MatchTimeout}");
}