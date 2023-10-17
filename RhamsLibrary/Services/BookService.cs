using Microsoft.EntityFrameworkCore;
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
            var book = new Book { Title = b.Title, Author = b.Author, Description = b.Description, YearPub = b.YearPub };
            _db.Books.Add(book);
            _db.SaveChanges();
            return book;
        }
        public void removeBook(Book book)
        {
            var b = _db.Books
            .FirstOrDefault(x => x.Title == book.Title);
            if (b != null)
            {
                _db.Books.Remove(b);
            }
            _db.SaveChanges();
            _db.Books.ToList();
        }
        public void updateBook(Book book)
        {
            var b = _db.Books
            .FirstOrDefault(c => c.Id == book.Id);
            if (b != null)
            {
                b.Title = book.Title;
                b.Author = book.Author;
                b.Description = book.Description;
                b.YearPub = book.YearPub;
            }

            _db.Entry(b).State = EntityState.Modified;
            _db.SaveChanges();
        }
        public List<Book> SearchBooks(string search)
        {
            return _db.Books
            .Where(b => b.Title.Contains(search) ||
                b.Description.Contains(search) ||
                b.Author.Contains(search) ||
                b.YearPub.ToString().Contains(search)
                )
            .ToList();
        }
        public List<Book> getAllBooks()
        {
            var list = _db.Books.ToList();
            return list;
        }
    }
}
