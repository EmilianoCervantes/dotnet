/** Variables before classes:
 * Top-level statements must precede namespace and type declarations. [OmniSharpMiscellaneousFiles.csproj]
 * Cannot be after the class definition.
 * Top-level statements must come before any type declarations (classes, interfaces, etc.).
 */
Book book = new("One Piece", "Eiichiro Oda", 21000, 1000000.99m);
Console.WriteLine($"My book: {book.Description}");
Console.WriteLine($"My book: {book.GetDescription()}");
book.Name = "Romance Dawn";
book.PageCount = 100;
Console.WriteLine($"My book: {book.Description}");
Console.WriteLine($"My book's ISBN: {book.ISBN}.");
Console.WriteLine($"My book's Price: {book.Price}.");
book.ISBN = "kashdsaugdasjkdhajsk";
book.Price = 1000.73m;
Console.WriteLine($"My book's ISBN: {book.ISBN}.");
Console.WriteLine($"My book's Price: {book.Price:C}.");
Console.WriteLine();

Magazine magazine = new("Comics Online", "Internet", 1000000, 9.99m, 2007);
Console.WriteLine($"My magazine: {magazine.GetDescription()}");

// WriteLine ALREADY calls the .ToString() method BEHIND THE SCENES!
Console.WriteLine($"Magazine to string: {magazine}.");
Console.WriteLine(magazine.ToString());
Console.WriteLine(magazine);
Console.WriteLine();
Console.WriteLine($"book.ToString() (overridden method): {book}.");

try
{
  magazine.Name = "";
}
catch (Exception e)
{

  Console.WriteLine($"Deliberately catching the error: {e.Message}.");
}

public class Publication(string name, int pageCount, decimal price)
{
  private string _name = name;

  public string Name
  {
    get => _name;
    set
    {
      if (value == "")
      {
        throw new ArgumentException("Name cannot be blank");
      }
      _name = value;
    }
  }
  public int PageCount { get; set; } = pageCount;
  public decimal Price { get; set; } = price;

  public virtual string GetDescription()
  {
    return $"{Name} is {PageCount} long. At only {Price}.";
  }
}

public class Book(string name, string author, int pageCount, decimal price) : Publication(name, pageCount, price)
{

  // public string dummyTest = "";
  // public readonly string dummyReadOnlyTest = "";

  /**
   * 1)
   * OLD WAY!
  public string GetName()
  {
    return _name;
  }

  public void SetName(string newName)
  {
    _name = newName;
  }

  public string GetAuthor()
  {
    return _author;
  }

  public void SetAuthor(string newAuthor)
  {
    _author = newAuthor;
  }

  public int GetNumOfPages()
  {
    return _pageCount;
  }

  public void SetNumOfPages(int newPageCount)
  {
    _pageCount = newPageCount;
  }
  */

  /**
   * 2)
   * NEW WAY
  public string Name {
    get {
      return _name;
    }
    set {
      _name = value;
    }
  }
  */

  /**
   * 3) NEW NEW WAY
  public string Name {
    get => _name;
    set => _name = value;
  }
  */

  /**
   * 4)
   * NEW NEW NEEEW WAY!
   */
  // public new string Name { get; set; } = name;

  public string Author { get; set; } = author;

  // public new int PageCount { get; set; } = pageCount;

  // USE OUR FIELDS FOR SOMETHING NEW
  // public string GetDescription()
  // {
  //   return $"{Name} by {Author}. Has {PageCount:N0} pages.";
  // }
  public string Description => $"{Name} by {Author}. Has {PageCount:N0} pages.";

  // FIELDS NOT ACCOUNTED FOR AT THE BEGINNING!
  public string? ISBN { get; set; }

  // WHILE this is an OVERRIDE
  public override string ToString()
  {
    return $"This is the book {Name}. Author: {Author}. Pages: {PageCount}. Price: {Price}";
  }

  // THIS is an OVERLOAD
  public string ToString(char formatType)
  {
    if (formatType == 'a')
    {
      return $"{Name} by {Author}";
    }
    else if (formatType == 'p')
    {
      return $"{Name} with {PageCount} pages.";
    }

    return $"{Name} by {Author} with {PageCount} pages.";
  }
}

public class Magazine(string name, string publisher, int pageCount, decimal price, int year) : Publication(name, pageCount, price)
{
  public string Publisher { get; set; } = publisher;
  public int Year { get; } = year;

  public override string GetDescription()
  {
    return $"{Name} published by {Publisher} in {Year} for only {Price:C}.";
  }
}
