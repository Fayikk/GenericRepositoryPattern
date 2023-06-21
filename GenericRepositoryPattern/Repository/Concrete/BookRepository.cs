using GenericRepositoryPattern.Context;
using GenericRepositoryPattern.Entities;
using GenericRepositoryPattern.Repository.Abstract;
using Microsoft.EntityFrameworkCore;

namespace GenericRepositoryPattern.Repository.Concrete
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<string> GetFirstBookName()
        {
            return await GetAll().Select(x => x.Name).FirstOrDefaultAsync();
        }
    }
}
