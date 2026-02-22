var x = Random.Shared.Next(1, 20);
var y = 0;

try {
  var result = x / y;
  Console.WriteLine("Did we get here?");
} catch {
  Console.WriteLine("Personalized error message");
}

try {
  var result = x / y;
  Console.WriteLine("Did we get here?");
} catch (DivideByZeroException e) {
  Console.WriteLine($"Personalized error message with system error message: {e.Message}");
}

Console.WriteLine("\nWe still reach the next part of the program.");

try {
  if (x > 10) {
    throw new ArgumentOutOfRangeException("x is greater than 10!");
  }
  Console.WriteLine("X is low");
} catch (ArgumentOutOfRangeException e) {
  Console.WriteLine("X was too big!");
  Console.WriteLine($"Here the error message we defined above: {e.Message}");
} finally {
  Console.WriteLine("THIS ALWAYS RUNS!");
}