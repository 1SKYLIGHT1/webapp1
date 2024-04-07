namespace Books
{
    internal class BookStorageService
    {
        private List<Book> _books;

        public List<Book> GetBookList()
        {
            return _books;
        }

        public BookStorageService()
        {
            _books = Book.GetBookList();
        }

        public void AddStudent(Book book)
        {
            _books.Add(book);
        }

        public void DeleteStudent(int bookId)
        {
            _books.RemoveAll(a => a.Id == bookId);
        }

        public List<string> FilterBooks()
        {
            return _books.Where(b => b.Author.ToUpper().StartsWith("Д"))
                .Select(b => b.Author)
                .Distinct()
                .ToList();
        }

        public List<Book> FilterBooksPrices()
        {
            return _books.Where(b => b.Price > 2500)
                //.Sum(b => b.Price)
                .ToList();
        }

        public int GetSumBookPrices()
        {
            return _books.Where(b => b.Price > 2500)
                .Sum(b => b.Price);
        }

        public Book GetMaxPriceBook()
        {
            return _books.MaxBy(b => b.Price);
        }

        public void SyntaxTest()
        {
            var aa = from book in _books
                where book.Id == 1
                where book.Author == ""
                select book;

        }
    }
}
