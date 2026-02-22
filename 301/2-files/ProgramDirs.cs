void Divider(string title = "New Section:")
{
  Console.WriteLine("\n----- ----- ----- ----- -----");
  Console.WriteLine("----- ----- ----- ----- -----\n");

  Console.WriteLine(title);
}

const string dirname = "TestDir";

// Create a Directory if it doesn't already exist
if (!Directory.Exists(dirname))
{
  Directory.CreateDirectory(dirname);
}
else
{
  Directory.Delete(dirname);
}

// Get the path for the current directory
string currPath = Directory.GetCurrentDirectory();
Console.WriteLine($"Current directory is {currPath}");

// Just like with files, you can retrieve info about a directory
DirectoryInfo di = new DirectoryInfo(currPath);
Console.WriteLine($"{di.Name}");
Console.WriteLine($"{di.Parent}");
Console.WriteLine($"{di.CreationTime}");

Divider();

// Enumerate the contents of directories
Console.WriteLine("Just directories:");
List<string> dirsList = new List<string>(Directory.EnumerateDirectories(currPath));
foreach (string dir in dirsList)
{
  Console.WriteLine(dir);
}

Divider();

Console.WriteLine("Just files:");
List<string> fileList = new List<string>(Directory.EnumerateFiles(currPath));
foreach (string dir in fileList)
{
  Console.WriteLine(dir);
}

Divider();

Console.WriteLine("All directory contents:");
List<string> contentsList = new List<string>(Directory.EnumerateFileSystemEntries(currPath));
foreach (string dir in contentsList)
{
  Console.WriteLine(dir);
}
