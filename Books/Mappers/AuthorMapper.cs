using DbData.DbModels;
using DbAuthor = DbData.DbModels.Author;

namespace Books.Mappers
{
    public static class AuthorMapper
    {
        public static Author ToModel(this DbAuthor dbAuthor)
        {
            return new Author()
            {
                Id = dbAuthor.Id,
                FirstName = dbAuthor.FirstName,
                LastName = dbAuthor.LastName,
                DateOfBirth = dbAuthor.DateOfBirth,
            };
        }

        public static DbAuthor ToEntity(this Author author)
        {
            return new DbAuthor()
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                DateOfBirth = author.DateOfBirth,
            };
        }
    }
}
