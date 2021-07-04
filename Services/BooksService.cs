using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Books.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Books.API.Services
{
    public class BooksService
    {
        private BooksContext _context;

        public BooksService(BooksContext context)
        {
            _context = context;
        }

        public Book GetBookById(string id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Book> GetBooks()
        {
            return _context.Books.ToList();
        }

        public IEnumerable<Book> GetBooksById(string id)
        {
            //var books = from p in _context.Books select p;
            return _context.Books.OrderBy(b => b.Id).ToList();
        }

        public async Task<Book> AddBook(Book book)
        {
            var result = await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
            return result.Entity;

        }
    }
}