using Books;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class BookController : ControllerBase
    {
        private BookStorageService _bookStorageService;

        public BookController(BookStorageService bookStorageService)
        {
            _bookStorageService = bookStorageService;
        }

        [HttpGet]
        public List<Book> GetBookList()
        {
            return _bookStorageService.GetBookList();
        }     
        
        [HttpPost]
        public IActionResult AddBook([FromBody]Book newBook)
        {
            _bookStorageService.AddBook(newBook);

            return Ok();
        }
    }
}
