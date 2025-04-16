using BookLibrary.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookLibrary.Infrastructure.Mapping;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.ToTable("books");

        builder.Property(b => b.Id)
            .HasColumnName("book_id");

        builder.Property(b => b.Title);

        builder.Property(b => b.FirstName)
            .HasColumnName("first_name");

        builder.Property(b => b.LastName)
            .HasColumnName("last_name");

        builder.Property(b => b.TotalCopies)
            .HasColumnName("total_copies");

        builder.Property(b => b.TotalCopiesInUse)
            .HasColumnName("copies_in_use");
    }
}
