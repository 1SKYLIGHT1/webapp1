using Books.Mappers;
using DbData.DbModels;

namespace Books
{
    public class BookStorageService
    {
        private LibraryContext _libraryContext;

        public BookStorageService(LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
        }

        public List<Book> GetBookList()
        {
            return _libraryContext.Book.Select(s => s.ToModel()).ToList();
        }

        public void AddBook(Book book)
        {
            _libraryContext.Book.Add(book.ToEntity());
            _libraryContext.SaveChanges();
        }
        
        public void DeleteBook(int bookId)
        {
            var dbBook = _libraryContext.Book.Where(w => w.Id  == bookId).FirstOrDefault();
            _libraryContext.Book.Remove(dbBook);
            _libraryContext.SaveChanges();
        }
        
        public List<Author> FilterBooks()
        {
            return _libraryContext.Book.Where(b => b.Author.FirstName.ToUpper().StartsWith("Д"))
                .Select(b => b.Author)
                .DistinctBy(b => b.LastName)
                .Select(s => s.ToModel())
                .ToList();
        }
        
        public List<Book> FilterBooksPrices()
        {
            return _libraryContext.Book.Where(b => b.Price > 2500)
                //.Sum(b => b.Price).
                .Select(s => s.ToModel())
                .ToList();
        }
        
        public int GetSumBookPrices()
        {
            return _libraryContext.Book.Where(b => b.Price > 2500)
                .Sum(b => b.Price);
        }
        
        public Book GetMaxPriceBook()
        {
            return _libraryContext.Book.MaxBy(b => b.Price).ToModel();
        }
        
        public void SyntaxTest()
        {
            var aa = from book in _libraryContext.Book
                where book.Id == 1
                where book.Author.FirstName == ""
                select book;
        
        }
    }
}
