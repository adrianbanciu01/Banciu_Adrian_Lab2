using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Banciu_Adrian_Lab2.Data;
using Banciu_Adrian_Lab2.Models;

namespace Banciu_Adrian_Lab2.Pages.Books
{
    public class CreateModel : BookCategoriesPageModel
    {
        private readonly Banciu_Adrian_Lab2.Data.Banciu_Adrian_Lab2Context _context;

        public CreateModel(Banciu_Adrian_Lab2.Data.Banciu_Adrian_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["PublisherID"] = new SelectList(_context.Set<Publisher>(), "ID",
"PublisherName");
            ViewData["AuthorID"] = new SelectList(_context.Author, "ID", "LastName");
            var book = new Book { BookCategories = new List<BookCategory>() };
            PopulateAssignedCategoryData(_context, book);
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(string[] selectedCategories)
        {
            var newBook = new Book();
            if (selectedCategories != null)
            {
                newBook.BookCategories = selectedCategories.Select(catID => new BookCategory
                {
                    CategoryID = int.Parse(catID)
                }).ToList();
            }

            _context.Book.Add(newBook);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}
