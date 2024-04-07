
//using PracticumLINQ;

var people = new List<Person>

{
    new Person ("Tom", 23),
    new Person ("Bob", 27)
};

var personnel = from p in people
                let name = $"Mr. {p.Name}"
                let year = DateTime.Now.Year - p.Year
                select new
                {
                    Name = name,
                    Year = year
                };

foreach ( var person in people)
{
Console.WriteLine($"{person.Name} - {person.Year}");

}

record class Person(string Name, int Year);


//int[] numbers = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };
// методы расширения
//var evens = numbers.Where(i => i > 10);

// операторы запросов

//Console.WriteLine(evens);