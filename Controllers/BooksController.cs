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

        // GET: api/books
        //DEPREACATED
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            var books = await _service.GetBooks();

            if (books == null)
            {
                return NotFound(books);
            }
            return Ok(books);
        }


        // GET: api/books/id/B01
        [HttpGet("id/{id?}")]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks(string id)
        {
            var books = await _service.GetBooksById(id);

            if (books == null)
            {
                return NotFound($"No books found by Id = {id}");
            }

            return Ok(books);
        }

        // GET: api/books/author/kim
        [HttpGet("author/{name?}")]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooksByAuthor(string name)
        {
            var books = await _service.GetBooksByAuthor(name);

            if (books == null)
            {
                return NotFound($"No books found by Author={name}");
            }

            return Ok(books);
        }

        // GET: api/books/title
        [HttpGet("title/{name?}")]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooksByTitle(string name)
        {
            var books = await _service.GetBooksByTitle(name);

            if (books == null)
            {
                return NotFound($"No books found for Title = {name}");
            }

            return Ok(books);
        }

        // GET: api/books/title
        [HttpGet("price/{priceStr?}")]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooksByPrice([FromQuery] string priceStr)
        {
            var books = await _service.GetBooksByPrice(priceStr);

            if (books == null)
            {
                return NotFound($"No books found for {priceStr}");
            }

            return Ok(books);
        }

        // POST: api/Books
        [HttpPost]
        public async Task<ActionResult<Book>> PostBook([FromBody]Book book)
        {
            try
            {
                if (book == null)
                {
                    return BadRequest();
                }
                var newBook = await _service.AddBook(book);
                return CreatedAtAction(nameof(GetBookById), new { id = newBook.Id }, newBook);

            }
            catch (Exception)
            {
                return StatusCode(500, "Error creating book ");
            }


        }

        // GET: api/books/B01
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBookById(string id)
        {
            try
            {
                var result = await _service.GetBookById(id);

                if (result == null)
                {
                    return NotFound($"Book with Id = {id} not found");
                }
                return result;
            }
            catch (Exception)
            {
                return StatusCode(500,
                    "Error retrieving data from the database");
            }
        }

        [HttpPut("/books/id/{id}")]
        public async Task<ActionResult<Book>> UpdateBook(string id, [FromBody]Book book)
        {
            try
            {
                if (id != book.Id)
                    return BadRequest("Book ID mismatch");

                var bookToUpdate = await _service.GetBookById(id);

                if (bookToUpdate == null)
                    return NotFound($"Book with Id = {id} not found");

                return await _service.UpdateBook(book);
            }
            catch (Exception)
            {
                return StatusCode(500,
                    "Error updating data");
            }
        }

        [HttpDelete("{id}")]
    public async Task<ActionResult<Book>> DeleteBook(string id)
    {
        try
        {
            var bookToDelete = await _service.GetBookById(id);

            if (bookToDelete == null)
            {
                return NotFound($"Book with Id = {id} not found");
            }

            return await _service.DeleteBook(id);
        }
        catch (Exception)
        {
            return StatusCode(500,
                "Error deleting data");
        }
    }
        
    }
}
