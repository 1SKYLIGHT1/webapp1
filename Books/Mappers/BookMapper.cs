using DbData.DbModels;
using DbBook = DbData.DbModels.Book;

namespace Books.Mappers
{
    public static class BookMapper
    {
        public static Book ToModel(this DbBook dbBook)
        {
            return new Book
            {
                AuthorId = dbBook.AuthorId,
                Id = dbBook.Id,
                Title = dbBook.Title,
                Price = dbBook.Price,
                PublicationDate = dbBook.PublicationDate
            };
        }

        public static DbBook ToEntity(this Book book)
        {
            return new DbBook
            {
                AuthorId = book.AuthorId,
                Id = book.Id,
                Title = book.Title,
                Price = (short)book.Price,
                PublicationDate = book.PublicationDate
            };
        }
    }
}
