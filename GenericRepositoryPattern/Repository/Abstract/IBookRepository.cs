using GenericRepositoryPattern.Entities;

namespace GenericRepositoryPattern.Repository.Abstract
{
    public interface IBookRepository : IRepository<Book>
    {
        Task<string> GetFirstBookName();
    }
}
