using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BooksBlogRazor.Persistence;
using BooksBlogRazor.Persistence.Models;

namespace BooksBlogRazor.Pages.BookReviews
{
    public class CreateModel : PageModel
    {
        private readonly BooksBlogRazor.Persistence.BooksBlogDbContext _context;

        public CreateModel(BooksBlogRazor.Persistence.BooksBlogDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public BookReview BookReview { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Set default image
            if (string.IsNullOrEmpty(BookReview.Image))
            {
                BookReview.Image = "https://knigopoisk.org/media/books/po/poster.png";
            }

            BookReview.ReviewDateCreated = DateTime.Today;

            _context.BookReviews.Add(BookReview);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Reviews");
        }
    }
}