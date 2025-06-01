namespace BooksApi.Services
{
    public class Bookservice
    {
        private List<Book> _books;
        public Bookservice() 
        {
            _books = new List<Book>();

        }
        public void AddBook(BooksApi book)
        {
            _books.Add(book);
        }
        public List<Book> GetAll()
        {
            return _books;
        }
    }
