using System;
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

        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<IEnumerable<Book>> GetBooksById(string id)
        {
            IQueryable<Book> query = _context.Books;
            if(!string.IsNullOrEmpty(id)){
                query = query.OrderBy(b => b.Id).Where(b => b.Id.Contains(id));
            }
            return await query.OrderBy(b => b.Id).ToListAsync();
        }

        public async Task<IEnumerable<Book>> GetBooksByAuthor(string name)
        {
            IQueryable<Book> query = _context.Books;
            if(!string.IsNullOrEmpty(name)){
                query = query.OrderBy(b => b.Author).Where(b => b.Author.Contains(name));
            }
            query = query.OrderBy(b => b.Author);
            return await query.ToListAsync();
        }

        public async Task<IEnumerable<Book>> GetBooksByTitle(string name)
        {
            IQueryable<Book> query = _context.Books;
            if(!string.IsNullOrEmpty(name)){
                query = query.OrderBy(b => b.Title).Where(b => b.Title.Contains(name));
            }
            query = query.OrderBy(b => b.Title);
            return await query.ToListAsync();
        }

        public async Task<Book> AddBook(Book book)
        {
            var result = await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
            return result.Entity;

        }

        public async void AddBooks(Book[] books)
        {
             await _context.Books.AddRangeAsync(books);

            await _context.SaveChangesAsync();
    
        }
    }
}