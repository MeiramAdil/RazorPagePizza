namespace RazorPages2.Models
{
  public class Book
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public BooksGenre Genre { get; set; }
  }

  public enum BooksGenre
  {
    Romantic, Horor, Fantastic,Detective
  }
}
