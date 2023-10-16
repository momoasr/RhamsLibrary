using RhamsLibrary.Data;

namespace RhamsLibrary.Services
{
    public class BookService: IBookService
    {
        LibraryContext _db;

        public BookService(LibraryContext db)
        {
            _db = db;
        }
        public Book addBook(Book b)
        {
             
        }
        public void removeBook(Book book)
        {
            
        }
        public void updateBook(Book book)
        {
            
        }
        public List<Book> SearchBooks(string search)
        {
            
        }
        public List<Book> getAllBooks()
        {
            var list = _db.Books.ToList();
            return list;
        }
    }
}
