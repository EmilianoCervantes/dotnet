/** Variables before classes:
 * Top-level statements must precede namespace and type declarations. [OmniSharpMiscellaneousFiles.csproj]
 * Cannot be after the class definition.
 * Top-level statements must come before any type declarations (classes, interfaces, etc.).
 */
Book book = new("One Piece", "Eiichiro Oda", 21000);
Console.WriteLine($"My book: {book.Description}");
book.Name = "Romance Dawn";
book.PageCount = 100;
Console.WriteLine($"My book: {book.Description}");
Console.WriteLine($"My book's ISBN: {book.ISBN}.");
Console.WriteLine($"My book's Price: {book.Price}.");
book.ISBN = "kashdsaugdasjkdhajsk";
book.Price = 1000.73m;
Console.WriteLine($"My book's ISBN: {book.ISBN}.");
Console.WriteLine($"My book's Price: {book.Price:C}.");

public class Book(string name, string author, int pageCount)
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
  public string Name { get; set; } = name;

  public string Author { get; set; } = author;

  public int PageCount { get; set; } = pageCount;

  // USE OUR FIELDS FOR SOMETHING NEW
  // public string GetDescription()
  // {
  //   return $"{Name} by {Author}. Has {PageCount:N0} pages.";
  // }
  public string Description => $"{Name} by {Author}. Has {PageCount:N0} pages.";

  // FIELDS NOT ACCOUNTED FOR AT THE BEGINNING!
  public string? ISBN { get; set; }
  public decimal Price { get; set; }
}
