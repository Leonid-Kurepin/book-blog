using BooksBlogRazor.Persistence;
using BooksBlogRazor.Persistence.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BooksBlogRazor.Pages.BookReviews
{
    public class ShortBookReviewEntityModel : PageModel
    {
        private readonly BooksBlogDbContext _context;

        public ShortBookReviewEntityModel(BooksBlogDbContext context)
        {
            _context = context;
        }

        public BookReview BookReviewEntity { get; private set; }

        public async Task OnGetAsync(int id)
        {
            BookReviewEntity = await _context.BookReviews.FirstOrDefaultAsync(br => br.BookReviewId.Equals(id));
        }
    }
}