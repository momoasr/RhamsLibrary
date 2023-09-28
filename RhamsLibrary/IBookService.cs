namespace RhamsLibrary
{
    public interface IBook
    {
        public void addBook(Book book);
        public void removeBook(Book book);
        public void updateBook(int id);
        public Book getBooks(string search);
        public List<Book> getAllBooks();
    }
}
