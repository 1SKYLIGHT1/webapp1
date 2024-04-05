using Books;

var books = new BookStorageService();

var authors = books.FilterBooks();

var prices = books.FilterBooksPrices();

foreach (var author in authors)
{
    Console.WriteLine(author);
}

foreach (var price in prices)
{
    Console.WriteLine($"{price.Title}-{price.Price}");
}

var sumPrices = books.GetSumBookPrices();

Console.WriteLine(sumPrices);

var maxPrices = books.GetMaxPriceBook();

Console.WriteLine($"{maxPrices.Title} - {maxPrices.Price}");






