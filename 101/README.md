# First steps

For this section we will be using .NET 10.0, which is the latest version of .NET (as of February 2026).

It uses modern C# syntax.

## Hello World

You can create a new program by running in the terminal the command

```bash
dotnet new console
```

As we are not passing a name, the project will take the name of the directory where it is created.

To run the program, you can use the command `dotnet run`.
- This command will compile the program, creating a `bin/Debug/net10.0/1-hello-world` file and run it.

Try modifying the file and re-run `dotnet run` to see the changes.

## Code documentation

After you write comments and tags, e.g.:
```
/// My func comments start here
/// <summary>
/// Some summary about the functionality...
/// </summary>
/// <param name='args'>Some param</param>
/// <returns>
/// No return value.
/// </returns>
```

And also update your `<my-app>.csproj` file.

Go into the terminal and run:

```bash
dotnet build
```

It generates the doc as a side effect, the command is to create an executable in reality.

Try a before and after with the comments.
