using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages2.Models;
using static RazorPages2.Services.BookServices;

namespace RazorPages2.Pages
{
  public class LibraryModel : PageModel
  {
    public Book NewBook { get; set; }
    public List<Book> books = new();
    public void OnGet()
    {
      books = GetAll();
    }
    /*public IActionResult OnPost()
    {
      if (!ModelState.IsValid)
      {
        return Page();
      }
      Add(NewPizza);
      return RedirectToAction("Get");
    }

    public IActionResult OnPostDelete(int id)
    {
      Delete(id);
      return RedirectToAction("Get");
    }*/
  }
}
