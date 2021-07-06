using System.Collections.Generic;
using System.Threading.Tasks;
using Books.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Books.API.Services
{
    public interface IBooksService
    {
        Task<IEnumerable<Book>> GetBooks();

        Task<Book> GetBookById(string id);

        Task<IEnumerable<Book>> GetBooksById(string id);
        Task<IEnumerable<Book>> GetBooksByAuthor(string name);
        Task<IEnumerable<Book>> GetBooksByTitle(string name);
        Task<IEnumerable<Book>> GetBooksByPrice(string priceStr);
        Task<Book> AddBook(Book book);
        void AddBooks(Book[] books);
        Task<Book> UpdateBook(Book book);
        Task<Book> DeleteBook(string id);


    }
}