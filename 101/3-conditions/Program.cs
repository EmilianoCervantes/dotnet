// if-else

int myVal = Random.Shared.Next(1, 100); // 1 & 100 - Next is INCLUSIVE.

if (myVal < 34) {
  Console.WriteLine($"Int is in the FIRST 3rd: {myVal}\n");
} else if (myVal >= 34 && myVal < 67) {
  Console.WriteLine($"Int is in the MIDDLE range: {myVal}\n");
} else {
  Console.WriteLine($"Int is in the final 3rd: {myVal}\n");
}

// Ternary operator
Console.WriteLine($"Is it in the first half? {(myVal < 51 ? "Yes." : "No.")} \n");

// Switch
switch (myVal) {
  case 1:
  case 100:
    Console.WriteLine($"Found a Unicorn: {myVal}!\n");
    break;
  case < 51:
    Console.WriteLine("Switch caught a low number.\n");
    break;
  default:
    Console.WriteLine("Anything else.\n");
    break;
}