using BookLibrary.Domain.Entities;

namespace BookLibrary.Application.Interfaces;

public interface IBookService
{
    Task<List<Book>> SearchBooks(Book book);
}
