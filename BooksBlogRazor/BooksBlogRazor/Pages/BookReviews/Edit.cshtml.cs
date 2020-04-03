using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BooksBlogRazor.Persistence;
using BooksBlogRazor.Persistence.Models;

namespace BooksBlogRazor.Pages.BookReviews
{
    public class EditModel : PageModel
    {
        private readonly BooksBlogRazor.Persistence.BooksBlogDbContext _context;

        public EditModel(BooksBlogRazor.Persistence.BooksBlogDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BookReview BookReview { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BookReview = await _context.BookReviews.FirstOrDefaultAsync(m => m.BookReviewId == id);

            if (BookReview == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(BookReview).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookReviewExists(BookReview.BookReviewId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool BookReviewExists(int id)
        {
            return _context.BookReviews.Any(e => e.BookReviewId == id);
        }
    }
}
