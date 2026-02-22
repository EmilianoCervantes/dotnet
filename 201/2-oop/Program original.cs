// /** Variables before classes:
//  * Top-level statements must precede namespace and type declarations. [OmniSharpMiscellaneousFiles.csproj]
//  * Cannot be after the class definition.
//  * Top-level statements must come before any type declarations (classes, interfaces, etc.).
//  */
// var book = new Book("One Piece", "Eiichiro Oda", 21000);
// Console.WriteLine($"My book: {book.GetDescription()}");

// public class Book
// {
//   // ** CANNOT access properties directly! **
//   public string dummyTest = "";
//   public readonly string dummyReadOnlyTest = "";
//   private string? _name;
//   private string? _author;
//   private int _pageCount;

//   public Book(string name, string author, int pageCount)
//   {
//     _name = name;
//     _author = author;
//     _pageCount = pageCount;
//   }

//   public string GetDescription()
//   {
//     return $"{_name} by {_author}. Has {_pageCount:N0} pages.";
//   }

//   /**
//    * OLD WAY!
//   public string GetName()
//   {
//     return _name;
//   }

//   public void SetName(string newName)
//   {
//     _name = newName;
//   }

//   public string GetAuthor()
//   {
//     return _author;
//   }

//   public void SetAuthor(string newAuthor)
//   {
//     _author = newAuthor;
//   }

//   public int GetNumOfPages()
//   {
//     return _pageCount;
//   }

//   public void SetNumOfPages(int newPageCount)
//   {
//     _pageCount = newPageCount;
//   }
//   */

//   /**
//    * NEW WAY
//   public string Name {
//     get {
//       return _name;
//     }
//     set {
//       _name = value;
//     }
//   }
//   */

//   // NEW NEEEW WAY!
//   public string Name
//   {
//     get => _name;
//     set => _name = value;
//   }

//   public string Author
//   {
//     get => _author;
//     set => _author = value;
//   }

//   public int PageCount
//   {
//     get => _pageCount;
//     set => _pageCount = value;
//   }
// }
