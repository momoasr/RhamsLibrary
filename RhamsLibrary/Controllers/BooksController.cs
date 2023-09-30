using Microsoft.AspNetCore.Mvc;

namespace RhamsLibrary.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }
        // POST: BooksController/create and add
        [HttpPost]
        public Book addBook(Book b)
        {
            Book book = _bookService.addBook(b);
            return book;
            
        }

        // PUT: BooksController/Delete
        [HttpDelete]
        public void removeBook(Book book)
        {
            _bookService.removeBook(book);
        }

        // PUT: BooksController/Edit
        [HttpPut]
        public void updateBook(Book book)
        {
            _bookService.updateBook(book);
        }

        // GET: BooksController/SearchBook
        [HttpGet("Search/{criteria}")]
        public List<Book> SearchBooks(string search)
        {
            List<Book> books = _bookService.SearchBooks(search);
            return books;
        }

        // GET: BooksController/GetAllBook
        [HttpGet]
        public List<Book> getAllBooks()
        {
            List<Book> b = _bookService.getAllBooks();
            return b;
        }
    }
}
