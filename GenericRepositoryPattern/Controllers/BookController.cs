using GenericRepositoryPattern.Entities;
using GenericRepositoryPattern.Repository.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepositoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var book1 = new Book { Name = "İçindeki DEVİ Uyandır", Author = "Franz Kafka" };
            await _bookRepository.Create(book1);
            var model = _bookRepository.GetAll();
            return Ok(model);
        }
    }
}
