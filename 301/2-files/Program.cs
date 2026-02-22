void Divider(string title = "New Section:")
{
  Console.WriteLine("\n----- ----- ----- ----- -----");
  Console.WriteLine("----- ----- ----- ----- -----\n");

  Console.WriteLine(title);
}

const string filename = "MyFirstFile.txt";

/*
 * Read AND close files!
 *
 * using - scope for resource management with automatic disposal.
 * StreamWriter - text-file writer.
 * File.CreateText() - Creates a text file StreamWriter.
 */
// using (StreamWriter sw = File.CreateText(filename))
// {
//   sw.WriteLine("My first line i na file."); // Multiple runs WON'T add more lines.
// }

var fileExists = File.Exists(filename);
Console.WriteLine($"Checking if the file exists... {fileExists}.\n");

if (fileExists)
{
  File.Delete(filename);

  Console.WriteLine($"{filename} deleted.");
}

using (StreamWriter sw = File.CreateText(filename))
{
  sw.WriteLine("My first line in a file."); // Multiple runs WON'T add more lines.
}

Console.WriteLine($"The file was created... {File.Exists(filename)}.");

File.WriteAllText(filename, "I'm replacing everything with this line.");

Console.WriteLine($"Using WriteAllText I replaced ALL the contents of {filename}.\nLet's check it out:");

string currContent = File.ReadAllText(filename);
Console.WriteLine($"{currContent}\n");

Console.WriteLine("Let's NOT replace, but append with AppendAllText:");
File.AppendAllText(filename, "I'm appending this.");
File.AppendAllText(filename, "I'm appending this x2.");
currContent = File.ReadAllText(filename);
Console.WriteLine($"{currContent}\n");

Console.WriteLine("BUT why go through all that hassle? At least be cleaner:");
Console.WriteLine("(Notice we are using SW with 'AppendText' to keep the other texts!)\n");

using (StreamWriter sw = File.AppendText(filename))
{
  sw.WriteLine("My 2nd StreamWriter line in a file.");
  sw.WriteLine("My 3rd StreamWriter line in a file.");
  sw.WriteLine("My 4th StreamWriter line in a file.");
}

currContent = File.ReadAllText(filename);
Console.WriteLine($"{currContent}");

Divider("File's INFO from File properties:\n");
Console.WriteLine($"GetCreationTime: {File.GetCreationTime(filename)}");
Console.WriteLine($"GetLastWriteTime: {File.GetLastWriteTime(filename)}");
Console.WriteLine($"GetLastAccessTime: {File.GetLastAccessTime(filename)}");

Console.WriteLine("\n----- ----- ----- ----- -----");
Console.WriteLine("File info with FileInfo");

try
{
  FileInfo fi = new FileInfo(filename);
  Console.WriteLine($"{fi.Length}");
  Console.WriteLine($"{fi.Directory}");
  Console.WriteLine($"{fi.IsReadOnly}");
}
catch (Exception e)
{
  Console.WriteLine($"Exception: {e}");
}

Divider("Making the file READONLY:\n");
File.SetAttributes(filename, FileAttributes.ReadOnly);
Console.WriteLine($"GetAttributes: {File.GetAttributes(filename)}");

Divider("Manipulating file's info:\n");
// File information can also be manipulated
DateTime dt = new DateTime(2020, 7, 1);
File.SetCreationTime(filename, dt);
Console.WriteLine(File.GetCreationTime(filename));
