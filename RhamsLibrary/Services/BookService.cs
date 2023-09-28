namespace RhamsLibrary.Services
{
    public class BookService: IBook
    {
        private readonly List<Book> _books;

        //public BookService(BookService books)
        //{
        //    _books = books;
        //}
        public void addBook(Book b)
        {
            Book book = new Book();
            book.Title = b.Title;
            book.Author = b.Author;
            book.Description = b.Description;
            book.YearPub = b.YearPub;
            _books.Add(book);
            
        }
        public void removeBook(Book book)
        {
            _books.Remove(book);
        }
        public void updateBook(int id)
        {

        }
        public Book getBooks(string search);
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
