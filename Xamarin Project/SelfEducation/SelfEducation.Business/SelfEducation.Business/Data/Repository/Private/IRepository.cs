using SelfEducation.Business.Data.Contracts.Private;
using SQLite.Net;

namespace SelfEducation.Business.Data.Repository.Private
{
    public interface IRepository<T> where T : IEntity, new()
    {
        TableQuery<T> GetItems();
        T GetItem(int id);
        int SaveItem(T item);
        int DeleteItem(int id);
        TableQuery<T> AsQueryable();
    }
}