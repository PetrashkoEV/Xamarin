using System.Linq;
using SelfEducation.Business.Data.Contracts.Private;
using SelfEducation.Business.Data.Entities;
using SelfEducation.Business.Data.Repository.Private;
using SQLite.Net;
using SQLite.Net.Interop;

namespace SelfEducation.Business.Data.Repository
{
    public class Repository<T> : SQLiteConnection, IRepository<T>
        where T : IEntity, new()
    {
        readonly object _locker = new object();

        public Repository(ISQLitePlatform sqlitePlatform, IDbLocation databasePath)
            : base(sqlitePlatform, databasePath.DatabaseFilePath)
        {
            CreateTable<CurrencyEntity>();
        }


        public TableQuery<T> GetItems()
        {
            lock (_locker)
            {
                return (from i in Table<T>() select i);
            }
        }
        
        public T GetItem(int id)
        {
            lock (_locker)
            {
                return Table<T>().FirstOrDefault(x => x.Id == id);
            }
        }

        public int SaveItem(T item)
        {
            lock (_locker)
            {
                if (item.Id != 0)
                {
                    Update(item);
                    return item.Id;
                }
                return Insert(item);
            }
        }

        public int DeleteItem(int id)
        {
            lock (_locker)
            {
                return Delete<T>(new T() { Id = id });
            }
        }

        public TableQuery<T> AsQueryable()
        {
            lock (_locker)
            {
                return Table<T>();
            }
        }
    }
}