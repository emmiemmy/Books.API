using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Books.API.Models;
using Books.API.Services;

namespace Books.API.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BooksController : Controller
    {
        private readonly BooksService _service;

        public BooksController(BooksService service)
        {
            _service = service;
        }

        // GET: api/Books
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            var books = await _service.GetBooks();

            if(books == null){
                return NotFound(books);
            }
            return Ok(books);
        }


        // GET: api/Books/B01
        [HttpGet("id/{id?}")]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks(string id)
        {
            var books =  await _service.GetBooksById(id);

            if (books == null)
            {
                return NotFound();
            }

            return Ok(books);
        }

        // GET: api/books/author/kim
        [HttpGet("author/{name?}")]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooksByAuthor(string name)
        {
            var books =  await _service.GetBooksByAuthor(name);

            if (books == null)
            {
                return NotFound();
            }

            return Ok(books);
        }

        // GET: api/books/title
        [HttpGet("title/{name?}")]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooksByTitle(string name)
        {
            var books =  await _service.GetBooksByTitle(name);

            if (books == null)
            {
                return NotFound();
            }

            return Ok(books);
        }

          // POST: api/Books
        [HttpPost]
        public async Task<ActionResult<Book>> PostBook(Book book)
        {
            try{
                if(book == null){
                    return BadRequest();
                }
                var res = await _service.AddBook(book);
            }catch(Exception){
                return StatusCode(500, "Error creating book ");
            }
            
            
            return CreatedAtAction("GetBook", new { id = book.Id }, book);
        }

        
/*

        // PUT: api/Books/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBook(string id, Book book)
        {
            if (id != book.Id)
            {
                return BadRequest();
            }

            _context.Entry(book).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        

        // DELETE: api/Books/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(string id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }

            _context.Books.Remove(book);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BookExists(string id)
        {
            return _context.Books.Any(e => e.Id == id);
        }
    */
    }
}
