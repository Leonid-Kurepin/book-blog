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
    public class IndexModel : PageModel
    {
        private readonly BooksBlogRazor.Persistence.BooksBlogDbContext _context;

        public IndexModel(BooksBlogRazor.Persistence.BooksBlogDbContext context)
        {
            _context = context;
        }

        public IList<BookReview> BookReview { get;set; }

        public async Task OnGetAsync()
        {
            BookReview = await _context.BookReviews.ToListAsync();
        }
    }
}
