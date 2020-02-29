using System;
using System.ComponentModel.DataAnnotations;

namespace BooksBlogRazor.Persistence.Models
{
    public class BookReview
    {
        public int BookReviewId { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Genre { get; set; }
        public int? MyRating { get; set; }
        public string Description { get; set; }
        public string Review { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ReviewDateCreated { get; set; }
    }
}
