using BookLibrary.Application.Interfaces;
using BookLibrary.Domain.Entities;
using BookLibrary.Domain.Interfaces;

namespace BookLibrary.Application.Services;

public class BookService(IBookRepository repository) : IBookService
{
    private readonly IBookRepository _repository = repository;
    
    public Task<List<Book>> SearchBooks(Book book)
    {
        return _repository.SearchBooks(book);
    }
}
