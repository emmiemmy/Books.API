using System.Collections.Generic;
using System.Threading.Tasks;
using Books.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Books.API.Services
{
    public interface IBooksService
    {
        IEnumerable<Book> GetBooks();

        Book GetBookById(string id);

        IEnumerable<Book> GetBooksById(string id);

        


    }
}