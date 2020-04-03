using BooksBlogRazor.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BooksBlogRazor.Persistence.Configurations
{
    internal class BookReviewConfiguration : IEntityTypeConfiguration<BookReview>
    {
        public void Configure(EntityTypeBuilder<BookReview> builder)
        {
            //----------Properties------------
            //Title
            builder
                .Property(br => br.Title)
                .IsRequired(false)
                .HasMaxLength(255);

            //Image
            builder
                .Property(br => br.Image)
                .IsRequired(false);

            //Genre
            builder
                .Property(br => br.Genre)
                .IsRequired(false)
                .HasMaxLength(255);

            //MyRating
            builder
                .Property(br => br.MyRating)
                .IsRequired(false);

            //Description
            builder
                .Property(br => br.Description)
                .IsRequired(false);

            //Review
            builder
                .Property(br => br.Review)
                .IsRequired(false);

            //ReviewDateCreated
            builder
                .Property(br => br.ReviewDateCreated)
                .IsRequired(false);
        }
    }
}


