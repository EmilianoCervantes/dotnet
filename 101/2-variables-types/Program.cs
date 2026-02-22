// Ints, Floats, Doubles and Decimals
int myFIrstInt = 10;
Console.WriteLine($"My first int: {myFIrstInt}");

float myFirstFloat = 0.1f;
float mySecondFloat = 0.2f;
Console.WriteLine($"Float sum {myFirstFloat}+{mySecondFloat} = {myFirstFloat + mySecondFloat}");

double myFirstDouble = 0.1;
double mySecondDouble = 0.2;
Console.WriteLine($"Double sum {myFirstDouble}+{mySecondDouble} = {myFirstDouble + mySecondDouble}");

decimal myFirstDecimal = 0.1m;
decimal mySecondDecimal = 0.2m;
Console.WriteLine($"Decimal sum {myFirstDecimal}+{mySecondDecimal} = {myFirstDecimal + mySecondDecimal}");

Console.WriteLine("\nDid you notice? Double has precision issues!");
Console.WriteLine("If it's about MONEY, A-L-W-A-Y-S use DECIMALS!");

// Implicit conversions
long bigNum;
bigNum = myFIrstInt;
Console.WriteLine($"\nImplicit long result: {bigNum} - {bigNum.GetType()}");
// Explicit conversions
decimal i_to_dec = myFIrstInt;
Console.WriteLine($"Explicit Int to Decimal: {i_to_dec.GetType()}");
decimal dou_to_dec = (decimal)(myFirstDouble + mySecondDouble);
Console.WriteLine($"How about this conversion? Original: {(myFirstDouble + mySecondDouble).GetType()}. New: {dou_to_dec.GetType()}");

// Booleans
bool b = true;
Console.WriteLine($"\nMy boolean is: {b}");

// Chars and strings
char c = 'c';
string s = "string";
string test = "a";
Console.WriteLine($"\nc is of type: {c.GetType()}, s is of type: {s.GetType()}, and test is of type: {test.GetType()}");

// Null
object? obj = null;
Console.WriteLine($"\nMy null: '{obj}'. Wait... nothing got printed?");
string? nullS = null;
Console.WriteLine($"My null string: {nullS}. {nullS ?? "Is this text showing? - ?? operator."}");
Console.WriteLine($"ALTERNATIVE: My null string: {nullS}. {(String.IsNullOrEmpty(nullS) ? "Is this text showing? - ?? operator." : nullS)}");

/*
CANNOT do null.GetType() - error.
Console.WriteLine($"Before assigning a value: {nullS.GetType()}.");

CANNOt do this: error CS8361: A conditional expression cannot be used directly in a string interpolation because the ':' ends the interpolation. Parenthesize the conditional expression.
Console.WriteLine($"If we try to check if the variable is currently null or not: {nullS is not null ? nullS.GetType() : "variable is null"}");

INSTEAD do (noticed the difference?): parenthesis...
*/
Console.WriteLine($"If we try to check if the variable is currently null or not: {(nullS is not null ? nullS.GetType() : "variable is null.")}");
nullS ??= "New value";
Console.WriteLine($"Now we did 'nullS??=string' and the res is: {nullS.GetType()}.");

// Arrays and Lists
int[] intArr = new int[1];
// var strArr = { "one", "two", "three" }; // ❌ error CS0820: Cannot initialize an implicitly-typed variable with an array initializer
// Either do this:
// string[] strArr = ["one", "two", "three"];
// Or do this:
string[] strArr = ["one", "two", "three"];
Console.WriteLine($"\nMy array of ints: {intArr} - {intArr.GetType()}. And my array of strings: {strArr}");

List<int> intList = [1];
Console.WriteLine($"My list of ints: {intList} - {intList.GetType()}");

// Adding items
Console.WriteLine($"\nLet's try adding items to our array and list.");
Console.WriteLine($"List length: {intList.Count}. Last item of the list: {intList[^1]}");
Console.WriteLine($"Array length: {intArr.Length}. Last item of the array: {intArr[^1]}");
intList.Add(2);
Console.WriteLine($"NEW list length: {intList.Count}. Last item of the list: {intList[^1]}");
// intArr.Add(2); // int[]' does not contain a definition for 'Add' and no accessible extension method 'Add' accepting a first argument of type 'int[]' could be found
// We CANNOT add items to an array. They have a fixed length.
// Console.WriteLine($"NEW arr length: {intList.Count}. Last item of the array: {intArr[intArr.Length - 1]}");

Console.WriteLine("\n----- ----- ----- ----- -----\n");
Console.WriteLine("\n----- ----- ----- ----- -----\n");

/*
 * ARRAY.COPY!!!
 * COPYING without tying the references!
 */
Console.WriteLine("HOW TO CLONE IN C#? {...obj}");
int[] intArr1 = [1, 2, 3, 4];
int[] intArr2 = intArr1;
int[] intArr3 = new int[intArr1.Length];
Array.Copy(intArr1, intArr3, intArr1.Length);

intArr1[0] = 0;
intArr2[2] = 5;
Console.WriteLine("I did intArr2 = intArr1; so... I modify both, and the result is:");
Console.WriteLine($"intArr1[0]: {intArr1[0]} - intArr2[0]: {intArr2[0]}.");
Console.WriteLine($"intArr2[2]: {intArr2[2]} - intArr1[2]: {intArr1[2]}.");
Console.WriteLine($"If one changes, the other one as well.");

intArr1[1] = 100;
intArr3[0] = 300;
Console.WriteLine("Now I did int[] intArr3 = new int[intArr1.Length]; Array.Copy(intArr1, intArr3, intArr1.Length);");
Console.WriteLine($"intArr1[1]: {intArr1[1]} - intArr3[1]: {intArr3[1]}.");
Console.WriteLine($"intArr3[0]: {intArr3[0]} - intArr1[0]: {intArr1[0]}.\n");
Console.WriteLine($"One does NOT affect the other.");

Console.WriteLine("\n----- ----- ----- ----- -----\n");
Console.WriteLine("\n----- ----- ----- ----- -----\n");
Console.WriteLine("\n----- ----- ----- ----- -----\n");
Console.WriteLine("\n----- ----- ----- ----- -----\n");
Console.WriteLine("\n----- ----- ----- ----- -----\n");

Console.WriteLine("Lets do some empty initializations:");
int emptyInt;
// string emptyStr;
// double emptyDouble;
// decimal emptyDecimal;
// int[] emptyIntArr;
// List<int> emptyIntList;

// error CS0165: Use of unassigned local variable 'emptyInt'
// Console.WriteLine($"Empty int: {emptyInt}"); // ❌ ERROR CS0165
// Console.WriteLine($"Empty string: {emptyStr}"); // ❌ ERROR CS0165

Console.WriteLine($"Empty int: {emptyInt = 1000} {emptyInt}");

Console.WriteLine("\n----- ----- ----- ----- -----\n");

// BUT HERE'S THE TRICK!
Console.WriteLine($"BUT HERE'S THE TRICK!");
int myInt = default;
Console.WriteLine($"Let's do int myInt = default; this equals: {myInt}");
decimal myDec = default;
Console.WriteLine($"Let's ALSO do decimal myDec = default; this equals: {myDec}");
bool myBool = default;
Console.WriteLine($"Let's ALSO do bool myBool = default; this equals: {myBool}");
string? myStr = default; // ❌ Cannot be "string", has to be of type "string?".
Console.WriteLine($"Let's ALSO do bool myBool = default; this equals: {myStr}");

Console.WriteLine("\n----- ----- ----- ----- -----\n");
Console.WriteLine("\n----- ----- ----- ----- -----\n");
Console.WriteLine("\n----- ----- ----- ----- -----\n");
Console.WriteLine("\n----- ----- ----- ----- -----\n");
Console.WriteLine("\n----- ----- ----- ----- -----\n");

Point p = new(100, 100);
Console.WriteLine($"My point: {p}.");

// Like Classes, they should be at the end
internal struct Point(int x, int y)
{
  public int x = x;
  public int y = y;

  public override readonly string ToString()
  {
    return $"(x: {x}, y: {y})";
  }
}
