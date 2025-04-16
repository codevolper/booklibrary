using BookLibrary.Domain.Entities;
using BookLibrary.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Infrastructure
{
    public class BookRepository : IBookRepository
    {
        #region ORM Context Initializer
        private readonly DefaultDbContext _context;

        public BookRepository(DefaultDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        #endregion

        public async Task<List<Book>> SearchBooks(Book book)
        {
            return await _context.Books
                 .Where(b => b.Title.Contains(book.Title) || b.ISBN.Contains(book.ISBN))
                 .ToListAsync();
        }       
    }
}
