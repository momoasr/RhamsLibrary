namespace RhamsLibrary
{
    public interface IBookService
    {
        public Book addBook(Book book);
        public void removeBook(string title);
        public void updateBook(Book book);
        public List<Book> SearchBooks(string search);
        public List<Book> getAllBooks();
    }
}
