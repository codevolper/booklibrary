using BookLibrary.Domain.Entities;

namespace BookLibrary.Domain.Interfaces;

public interface IBookRepository
{
   Task<List<Book>> SearchBooks(Book book);
}
