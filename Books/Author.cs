namespace Books
{
    public class Author
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Age => DateTime.Now.Year - DateOfBirth.Year;

        public string AuthorInfo => $"{FirstName} {LastName} {Age} лет";

        public Author() { }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {DateTime.Now.Year - DateOfBirth.Year} лет";
        }

        public override bool Equals(object? obj)
        {
            var other = obj as Author;

            //проверка на тип, если типы не совпадают, то объекты точно разные
            if (other == null)
            {
                return false;
            }

            return FirstName.Equals(other.FirstName) && LastName.Equals(other.LastName);
        }
    }
}