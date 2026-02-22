// returnType FuncName(...args)
decimal MilesToKM(decimal miles, decimal conversionRate = 1.60934m)
{
  return miles * conversionRate;
}

void PrecisionPrint(decimal num)
{
  Console.WriteLine($"{num} miles are {MilesToKM(num):N3}km.");
}

void FriendlyPrint(decimal num)
{
  Console.WriteLine($"{num} miles are {MilesToKM(num, 1.6m)}km.");
}

void Divider(string title = "New Section:")
{
  Console.WriteLine("\n----- ----- ----- ----- -----");
  Console.WriteLine("----- ----- ----- ----- -----\n");

  Console.WriteLine(title);
}

var miles = 10m;
PrecisionPrint(miles);
FriendlyPrint(miles);

Divider("1. Ways to call functions:\n");

/**
 * What's wrong with this line?
 *
 * 1) VAR cannot be used to define params.
 * 2) Optionals must go AT THE END! 
 * ❌ error CS0825: The contextual keyword 'var' may only appear within a local variable declaration or in script code.
 * ❌ error CS1737: Optional parameters must appear after all required parameters.
 */
// void FormatName(var prefix = "Mr.", string name, var suffix = "")
void FormatName(string name, string prefix = "SW Eng.", string suffix = "- welcome!")
{
  Console.WriteLine($"{prefix} {name} {suffix}");
}


FormatName("Eli");
FormatName(name: "Oscar");
FormatName("Emi", suffix: "in da house");

Divider("2. Reference and our parameters:\n");

void EgRegularFunc(int arg)
{
  arg += 10;
  Console.WriteLine($"Int inside EgRegularFunc: {arg}");
}

void EgRefFunc(ref int arg)
{
  arg += 10;
  Console.WriteLine($"Int inside EgRefFunc: {arg}");
}

var myInt = 5;
EgRegularFunc(myInt);
Console.WriteLine($"Int AFTER EgRegularFunc: {myInt}");
EgRefFunc(ref myInt);
Console.WriteLine($"Int AFTER EgRefFunc: {myInt}\n");


void PlusTimes(int arg1, int arg2, out int sum, out int product)
{
  sum = arg1 + arg2;
  product = arg1 * arg2;
}

int arg1 = 5, arg2 = 3;
// int sum = 1, product = 2; // No need to initialize them but there's also no issue.
int sum, product;
PlusTimes(arg1, arg2, out sum, out product);
Console.WriteLine($"Result of PlusTimes: Sum is {sum} and Product is {product}");

// BOTH ARE VALID!
// (int sum, int prod) PlusTimesV2(int arg1, int arg2) // option1
(int, int) PlusTimesV2(int arg1, int arg2) // option2
{
  var sum = arg1 + arg2;
  var prod = arg1 * arg2;

  return (sum, prod);
}

Divider("3. Return multiple values:\n");

Console.WriteLine("With tuples we can do:");
(int myIntA, int myIntB) tup1 = (5, 10);
var tup2 = ("Anything", 10m);
var tup3 = (Name: "Emi", Age: Random.Shared.Next(890, 7800), Movie: "The Social Network");

Console.WriteLine($"tup1={tup1} -> Naming outside myIntA={tup1.myIntA}");
Console.WriteLine($"tup2={tup2} -> Naming was automatic, e.g. Item2={tup2.Item2}");
Console.WriteLine($"tup3={tup3} -> Naming inside Age={tup3.Age}\n");

var res = PlusTimesV2(arg1, arg2);
// W/option1
// Console.WriteLine($"Result of PlusTimesV2: Sum is {res.sum} and Product is {res.prod}");
// w/option2
Console.WriteLine($"Result of PlusTimesV2: Sum is {res.Item1} and Product is {res.Item2}");
