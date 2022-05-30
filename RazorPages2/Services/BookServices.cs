using RazorPages2.Models;

namespace RazorPages2.Services
{
  public static class BookServices
  {
    static List<Book> Books { get; }
    static int id = 3;
    static BookServices()
    {
      Books = new List<Book> { };
    }

    public static List<Book> GetAll() => Books;
    public static Book? Get(int id) => Books.FirstOrDefault(x => x.Id == id);
    public static void Add(Book b)
    {
      b.Id = id++;
      Books.Add(b);
    }
    public static void Delete(int id)
    {
      var b = Get(id);
      if (b != null)
        Books.Remove(b);
      else return;
    }
    public static void Update(Book b)
    {
      var index = Books.FindIndex(x => x.Id == b.Id);
      if (index == -1) return;
      Books[index] = b;
    }
  }
}
