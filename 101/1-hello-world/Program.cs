// See https://aka.ms/new-console-template for more information
Console.WriteLine("Em says: Hello!");
Console.WriteLine("What's your name?");

// ?? "" is to avoid "Converting null literal or possible null value to non-nullable type."
string name = Console.ReadLine() ?? "";
Console.WriteLine($"Nice to meet you {name}!");
