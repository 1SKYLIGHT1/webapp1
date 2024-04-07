using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    internal class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public int Price { get; set; }

        public DateTime PublicationDate { get; set; } = DateTime.Now;

        public static List<Book> GetBookList()
        {
            return new List<Book>()
        {
            new Book()
            {
                Id = 1,
                Title = "Полёт Эйзенштейна",
                Author = "Джеймс Сваллоу",
                Price = 1500,
                PublicationDate = new DateTime(2007,3,1)
            },
            new Book()
            {
                Id = 2,
                Title = "Восхождение Хоруса",
                Author = "Дэн Абнетт",
                Price = 2900,
                PublicationDate = new DateTime(2006,4,2)
            },
             new Book()
            {
                Id = 3,
                Title = "Лживые Боги",
                Author = "Грэм Макнилл",
                Price = 3500,
                PublicationDate = new DateTime(2006,8,9)
            },
              new Book()
            {
                Id = 4,
                Title = "Инквизитор Эйзенхорн",
                Author = "Дэн Абнетт",
                Price = 900,
                PublicationDate = new DateTime(2001,7,3)
            },
               new Book()
            {
                Id = 5,
                Title = "Инквизитор Рейвинор",
                Author = "Дэн Абнетт",
                Price = 1700,
                PublicationDate = new DateTime(2005,9,15)
            },
                new Book()
            {
                Id = 6,
                Title = "Фулгрим",
                Author = "Грэм Макнилл",
                Price = 2100,
                PublicationDate = new DateTime(2008,11,19)
            },
                 new Book()
            {
                Id = 7,
                Title = "Сожжение Просперо",
                Author = "Дэн Абнетт",
                Price = 3200,
                PublicationDate = new DateTime(2012,3,12)
            },
                  new Book()
            {
                Id = 8,
                Title = "Немезида",
                Author = "Джеймс Сваллоу",
                Price = 1100,
                PublicationDate = new DateTime(2010,12,12)
            },
                new Book()
            {
                Id = 9,
                Title = "Преторианец Терры",
                Author = "Джон Френч",
                Price = 1000,
                PublicationDate = new DateTime(2015,6,4)
            },
                  new Book()
            {
                Id = 10,
                Title = "Император человечества",
                Author = "Аарон Дембски-Боуден",
                Price = 4000,
                PublicationDate = new DateTime(2016,6,17)
            },
        };
        }
    }
}
