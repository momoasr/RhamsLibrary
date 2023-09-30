namespace RhamsLibrary.Services
{
    public class BookService: IBookService
    {
        private readonly List<Book> _books;

        //public BookService(BookService books)
        //{
        //    _books = books;
        //}
        public Book addBook(Book b)
        {
            Book book = new Book();
            book.Title = b.Title;
            book.Author = b.Author;
            book.Description = b.Description;
            book.YearPub = b.YearPub;
            _books.Add(book);
            return book; 
        }
        public void removeBook(Book book)
        {
            _books.Remove(book);
        }
        public void updateBook(Book book)
        {
            var index = _books.FindIndex(x => x.Id == book.Id);
            if(index == -1)
            {
                _books[index] = book;
            }
        }
        public List<Book> SearchBooks(string search)
        {
            _books.FindAll(c => c.Title == search || 
                           c.Author == search || 
                           c.YearPub.ToString() == search ||
                           c.Description == search).ToList();
            
            return _books;
        }
        public List<Book> getAllBooks()
        {
            foreach (Book book in _books)
            {
                Console.WriteLine(book.Title);
            }
            return _books;
        }
    }
}
