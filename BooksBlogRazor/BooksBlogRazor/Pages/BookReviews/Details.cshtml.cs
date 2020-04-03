using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BooksBlogRazor.Persistence;
using BooksBlogRazor.Persistence.Models;

namespace BooksBlogRazor.Pages.BookReviews
{
    public class DetailsModel : PageModel
    {
        private readonly BooksBlogRazor.Persistence.BooksBlogDbContext _context;

        public DetailsModel(BooksBlogRazor.Persistence.BooksBlogDbContext context)
        {
            _context = context;
        }

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
    }
}
