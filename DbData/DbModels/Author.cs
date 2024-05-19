using System;
using System.Collections.Generic;

namespace DbData.DbModels;

public partial class Author
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateTime DateOfBirth { get; set; }

    public virtual ICollection<Book> Book { get; set; } = new List<Book>();
}
