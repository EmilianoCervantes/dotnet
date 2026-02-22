using System.Diagnostics;
using System.Text.RegularExpressions;

void Divider(string title = "New Section:")
{
  Console.WriteLine("\n----- ----- ----- ----- -----");
  Console.WriteLine("----- ----- ----- ----- -----\n");

  Console.WriteLine(title);
}

string teststr1 = "The quick brown Fox jumps over the lazy Dog";
string teststr2 = "the quick brown fox jumps over the lazy dog";

// The IsMatch function is used to determine if the content of a string
// results in a match with the given Regex
Regex CapWords = new Regex(@"[A-Z]\w+");
Console.WriteLine(CapWords.IsMatch(teststr1));
Console.WriteLine(CapWords.IsMatch(teststr2));

// The RegexOptions argument can be used to perform
// case-insensitive searches
Regex NoCase = new Regex(@"fox", RegexOptions.IgnoreCase);
Console.WriteLine(NoCase.IsMatch(teststr1));

// Use the Match and Matches methods to get information about
// specific Regex matches for a given pattern

// The Match method returns a single match at a time
Match m = CapWords.Match(teststr1);
while (m.Success)
{
  Console.WriteLine($"'{m.Value}' found at position {m.Index}");
  m = m.NextMatch();
}

// The Matches method returns a collection of Match objects
MatchCollection mc = CapWords.Matches(teststr1);
Console.WriteLine($"Found {mc.Count} matches:");
foreach (Match match in mc)
{
  Console.WriteLine($"'{match.Value}' found at position {match.Index}");
}

/*
*
*
*
*/

Regex CapWords2 = new Regex(@"[A-Z]\w+");

// Regular expressions can be used to replace content in strings
// in addition to just searching for content
string result = CapWords2.Replace(teststr1, "***");
Console.WriteLine(teststr1);
Console.WriteLine(result);

// Replacement text can be generated on the fly using MatchEvaluator
// This is a delegate that computes the new value of the replacement
string MakeUpper(Match m)
{
  string s = m.ToString();
  if (m.Index == 0)
  {
    return s;
  }
  return s.ToUpper();
}

string upperstr = CapWords2.Replace(teststr1, new MatchEvaluator(MakeUpper));
Console.WriteLine(teststr1);
Console.WriteLine(upperstr);

/*
*
*
*
*/

Divider("TIMEOUTS:");

const int MAX_REGEX_TIME = 1000; // Timeout value in milliseconds
const string thestr = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

// Use a Stopwatch to show elapsed time
Stopwatch sw;

// Use a Timeout value when executing RegEx to guard against bad input
TimeSpan Timeout = TimeSpan.FromMilliseconds(MAX_REGEX_TIME);

// Run the expression and output the result
try
{
  sw = Stopwatch.StartNew();
  Regex DreadfulRegexNeverUseSomethingLikeThis = new Regex(@"(a+a+)+b", RegexOptions.None, Timeout);
  MatchCollection mc2 = DreadfulRegexNeverUseSomethingLikeThis.Matches(thestr);
  sw.Stop();
  Console.WriteLine($"Found {mc2.Count} matches in {sw.Elapsed} time:");
  foreach (Match match in mc2)
  {
    Console.WriteLine($"'{match.Value}' found at position {match.Index}");
  }
}
catch (RegexMatchTimeoutException e)
{
  Console.WriteLine($"The Regex took too long to execute! {e.MatchTimeout}");
}
