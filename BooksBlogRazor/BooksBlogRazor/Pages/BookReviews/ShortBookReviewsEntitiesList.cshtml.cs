using System;
using BooksBlogRazor.Persistence;
using BooksBlogRazor.Persistence.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksBlogRazor.Pages.BookReviews
{
    public class ShortBookReviewsEntitiesListModel : PageModel
    {
        private readonly BooksBlogDbContext _context;

        public ShortBookReviewsEntitiesListModel(BooksBlogDbContext context)
        {
            _context = context;
        }

        public IList<BookReview> ShortBookReviewsEntities { get; set; }

        public async Task OnGetAsync(string searchWord, string dateCreatedFilter)
        {
            var bookReviewsQuery = _context.BookReviews.AsQueryable();
            var filteredBookReviewsQuery = bookReviewsQuery;

            if (!string.IsNullOrEmpty(searchWord))
            {
                filteredBookReviewsQuery = bookReviewsQuery.Where(br => br.Title.Contains(searchWord));
            }

            switch (dateCreatedFilter)
            {
                case "Month":
                    filteredBookReviewsQuery = filteredBookReviewsQuery.Where(mr => mr.ReviewDateCreated > DateTime.Today.AddMonths(-1));
                    break;
                case "Year":
                    filteredBookReviewsQuery = filteredBookReviewsQuery.Where(mr => mr.ReviewDateCreated > DateTime.Today.AddYears(-1));
                    break;
            }

            ShortBookReviewsEntities = await filteredBookReviewsQuery
                .AsNoTracking()
                .OrderByDescending(br => br.ReviewDateCreated)
                .ToListAsync();
        }
    }
}