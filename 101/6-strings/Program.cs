using System.Globalization;

var str = "Something";
Console.WriteLine($"Length: {str.Length}");
Console.WriteLine($"Last letter: {str[str.Length - 1]}");

Console.WriteLine("\n----- ----- ----- ----- -----\n");
string[] strArr = { "one", "two", "three" };
string concatenatedStrArr;
concatenatedStrArr = String.Concat(strArr);
Console.WriteLine($"Using String.Concat: {concatenatedStrArr}.\n");

concatenatedStrArr = String.Join("", strArr);
Console.WriteLine($"Using String.Join: {concatenatedStrArr}.\n");

Console.WriteLine($"So... what's the difference?");
var separator = "*-*";
concatenatedStrArr = String.Join(separator, strArr);
Console.WriteLine($"You can pass Join('separator', array), e.g. '{separator}' -> result: {concatenatedStrArr}.\n");

Console.WriteLine("\n----- ----- ----- ----- -----");
Console.WriteLine("----- ----- ----- ----- -----\n");

Console.WriteLine("Comparing strings:\n");
Console.WriteLine("< 0 means... 1st string goes BEFORE 2nd string when sorting.");
Console.WriteLine("== 0 means... strings are in the same position in sort order");
Console.WriteLine("> 0 means... 1st string goes AFTER 2nd string when sorting.");
var strA = "This is a string";
var strB = "THIS IS A STRING";
var strC = "THis is";

Console.WriteLine($"Lets compare {strA} and {strB}.");
Console.WriteLine($"Result is: {String.Compare(strA, strB)}.");
Console.WriteLine($"But we can also ignore case: {String.Compare(strA, strB, true)}.");
Console.WriteLine($"We can also use myStr.CompareTo: {strA.CompareTo(strB)}.");

Console.WriteLine("\n----- ----- ----- ----- -----\n");
Console.WriteLine($"Are '{strA}' and '{strC}' equal?");
Console.WriteLine($"Result from String.Equals(): {String.Equals(strA, strC)}");
Console.WriteLine($"We can also use directly myStr.Equals(): {strA.Equals(strC)}");

Console.WriteLine("\n----- ----- ----- ----- -----");
Console.WriteLine("----- ----- ----- ----- -----\n");

Console.WriteLine("Searching inside strings:");
var myStr = "Today I went to the doctor.";
Console.WriteLine($"myStr.IndexOf(\"o\"): {myStr.IndexOf("o")}");
Console.WriteLine($"myStrLast.IndexOf(\"o\"): {myStr.LastIndexOf("o")}");
Console.WriteLine($"myStr.IndexOf(\"tor\"): {myStr.IndexOf("tor")}");
Console.WriteLine($"myStr.IndexOf(\"i\"): {myStr.IndexOf("i")}");
Console.WriteLine($"myStr.IndexOf(\"I\"): {myStr.IndexOf("I")}");

Console.WriteLine("\n----- ----- ----- ----- -----\n");

Console.WriteLine($"myStr.Replace(\"o\", \"a\"): {myStr.Replace("o", "a")}");
Console.WriteLine($"myStr.Replace(\"the\", \"some\"): {myStr.Replace("the", "some")}");

Console.WriteLine("\n----- ----- ----- ----- -----");
Console.WriteLine("----- ----- ----- ----- -----\n");

Console.WriteLine("Formatting strings:\n");
Console.WriteLine("Common types:");
Console.WriteLine("N(Number), G(General), F(Fixed-point),");
Console.WriteLine("E(Exponential), D(Decimal => INT, Long, ❌float, double, or decimal),");
Console.WriteLine("P(Percent), X(Hexadecimal), C(Currency in local format).\n");

var val1 = 12345;
Console.WriteLine($"1st example with {val1}");
Console.WriteLine($"N: {val1:N}, G: {val1:G}, G3: {val1:G3}, F: {val1:F}, D: {val1:D}.\n");

var val2 = 1234.9876m;
Console.WriteLine($"2nd example with {val2}");
Console.WriteLine($"N: {val2:N}, G: {val2:G}, G4: {val2:G4}, F2: {val2:F2}, C: {val2:C}, P: {val2:P}.");

/**
* StringBuilder
* 
* INTERVIEW QUESTION:
* Use case:
* 1. Generating reports.
* 2. Processing A LOT of file content.
*/

Console.WriteLine("\n----- ----- ----- ----- -----");
Console.WriteLine("----- ----- ----- ----- -----\n");

Console.WriteLine("Strings to Numbers:");
var num1 = "1.00";
var num2 = "2.02";
var num3 = "3,000,000.00";
var num4 = "4,000.04";

var num = 0;
var dec = 0m;

object o = 10;

// Parser might trigger an exception!
try
{
  // num = int.Parse(num1); // ❌ System.FormatException: The input string '1.00' was not in a correct format.
  num = int.Parse(num1, NumberStyles.Float); // ONLY works with .00
  Console.WriteLine($"Parsing {num1} which was a {num1.GetType().Name} and has .00: {num}.");

  dec = decimal.Parse(num2);
  Console.WriteLine($"Parsing number with decimals: {dec}.");

  // NumberStyles CAN be combined:
  num = int.Parse(num3, NumberStyles.AllowThousands | NumberStyles.Float);
  Console.WriteLine($"Parsing comma and thousands for int {num3}: {num}.");

  dec = decimal.Parse(num4);
  Console.WriteLine($"Parsing comma and decimals to decimal {num4}: {dec}.");

  Console.WriteLine("\nIn the code you can notice the differences in the processes.");
}
catch (System.Exception)
{

  throw;
}
