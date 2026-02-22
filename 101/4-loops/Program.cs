int myVal = Random.Shared.Next(1, 10);
int toMatch = 8;

Console.WriteLine("A basic for loop:\n");
Console.WriteLine($"My value is: {myVal}.\nLet's only print the even numbers up to it as long as it's not greater than {toMatch}.");
for (int i = 0; i <= myVal; i++)
{
  if (i % 2 != 0)
  {
    continue;
  }

  Console.WriteLine($"Curr even number {i}");

  if (i == toMatch)
  {
    Console.WriteLine($"We reached the limit {toMatch}, let's end things here!\n");
    break;
  }
}

// Foreach VERSIONS
int[] secArr = new int[] { 2, 3, 5, 7, 11 };

Console.WriteLine("\n----- ----- ----- ----- -----\n");
Console.WriteLine("Let's go into the Foreach section!\n");

Console.WriteLine("1st one - foreach (var in arr/list/collection):");
foreach (int n in secArr)
{
  Console.WriteLine($"Current value: {n}");
}

List<int> myList = new List<int> { 1, 2, 3, 4, 5 };
Console.WriteLine("\n2nd one ONLY for Lists: list.ForEach(listItem => ...)");
myList.ForEach(static l => Console.WriteLine($"Curr value: {l}"));

// Remember: foreach is ONLY to iterate, NOT modify:
// foreach (var item in myList)
// {
//     myList.Remove(item); // ❌ runtime error
// }

Console.WriteLine("\n----- ----- ----- ----- -----\n");
Console.WriteLine("3rd one - DICTIONARIES:");
Dictionary<string, int> myDict = new Dictionary<string, int>
{
  ["A"] = 1,
  ["B"] = 2,
  ["C"] = 3,
  ["D"] = 4,
  ["E"] = 5,
};

Console.WriteLine($"My dict Count(length): {myDict.Count}\n");

foreach (KeyValuePair<string, int> entry in myDict)
{
  Console.WriteLine($"{entry.Key}: {entry.Value}");
}

Console.WriteLine("Only KEYS:");
foreach (string key in myDict.Keys)
{
  Console.WriteLine($"Key: {key}");
}

Console.WriteLine("Only VALUES:");
foreach (int val in myDict.Values)
{
  Console.WriteLine($"Value: {val}");
}

List<int> myNewList = myList;
myNewList.Add(6);
Console.WriteLine("I added a 6 to a copy of myList. Are they still equal to each other?");
Console.WriteLine($"myNewList,Count is {myNewList.Count} - myList.Count is {myList.Count}");

for (int i = 0; i < myNewList.Count; i++)
{
  Console.WriteLine($"1st list item: {myList[i]} - 2nd list item: {myNewList[i]}");
}

Console.WriteLine("\n----- ----- ----- ----- -----\n");
Console.WriteLine("4th one - STRINGS:");

string str = "Learning to write CSharp.";

foreach (char ch in str)
{
  Console.Write(ch);

  if (ch == 'o')
  {
    Console.WriteLine("\nFound letter!");
    break;
  }
}

Console.WriteLine("\n----- ----- ----- ----- -----\n");
Console.WriteLine("WHILE loop");

string input = "";
while (input.ToLower() != "exit")
{
  Console.WriteLine("Say something! (To exit, say 'exit')");
  input = Console.ReadLine() ?? "";

  if (input.ToLower() != "exit")
  {
    Console.WriteLine($"You said: {input}");
  }
  else
  {
    Console.WriteLine("Ohhh... too bad... until next time. Bye, bye! 👋");
  }
}

Console.WriteLine("\n----- ----- ----- ----- -----\n");
Console.WriteLine("DO while loop");

do
{
  Console.WriteLine("Next time! (Type 'exit' again to go.)");
  input = Console.ReadLine() ?? "";

  // OrdinalIgnoreCase better THAN CurrentCultureIgnoreCase
  if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
  {
    Console.WriteLine("Bye-bye!");
  }
  else
  {
    Console.WriteLine($"You said: {input}");
  }
} while (!input.Equals("exit", StringComparison.CurrentCultureIgnoreCase));
