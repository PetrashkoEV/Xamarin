using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Practices.ServiceLocation;
using SelfEducation.Business.Data.Contracts.Private;
using SelfEducation.Business.Data.Entities;
using SelfEducation.Business.Data.Repository.Private;
using SQLite.Net;
using SQLite.Net.Interop;

namespace SelfEducation.Business.Data.Repository
{
    public class ConnectionExtensions : SQLiteConnection, IConnectionExtensions
    {
        public ConnectionExtensions(ISQLitePlatform sqlitePlatform, IDbLocation databasePath)
            : base(sqlitePlatform, databasePath.DatabaseFilePath)
        {
        }

        readonly object _locker = new object();

        public int SafeInsertAll(IEnumerable objects)
        {
            lock (_locker)
            {
                return InsertAll(objects);
            }
        }

        public Task<T> ExecuteScalarAsync<T>(string query, params object[] args)
        {
            return Task.Run(() =>
            {
                lock (_locker)
                {
                    return ExecuteScalar<T>(query, args);
                }
            });
        }

        public T SafeExecuteScalar<T>(string query, params object[] args)
        {
            lock (_locker)
            {
                return ExecuteScalar<T>(query, args);
            }
        }

        public int SafeExecute(string query, params object[] args)
        {
            lock (_locker)
            {
                return Execute(query, args);
            }
        }

        public Task<int> ExecuteAsync(string query, params object[] args)
        {
            return Task.Run(() =>
            {
                lock (_locker)
                {
                    return Execute(query, args);
                }
            });
        }

        public Task<int> InsertAsync(object obj)
        {
            return Task.Run(() =>
            {
                lock (_locker)
                {
                    return Insert(obj);
                }
            });
        }

        public int SafeInsert(object obj)
        {
            lock (_locker)
            {
                return Insert(obj);
            }
        }

        public IEnumerable<T> SafeDeferredQuery<T>(string query, params object[] args) where T : new()
        {
            lock (_locker)
            {
                return DeferredQuery<T>(query, args);
            }
        }

        public int SafeUpdate(object obj)
        {
            lock (_locker)
            {
                return Update(obj);
            }
        }

        public Task<int> UpdateAsync(object obj)
        {
            return Task.Run(() =>
            {
                lock (_locker)
                {
                    return Update(obj);
                }
            });
        }

        public List<T> SafeQuery<T>(string query, params object[] args) where T : new()
        {
            lock (_locker)
            {
                return Query<T>(query, args);
            }
        }

        public Task<List<T>> QueryAsync<T>(string query, params object[] args) where T : new()
        {
            return Task.Run(() =>
            {
                lock (_locker)
                {
                    return Query<T>(query, args);
                }
            });
        }
        
        public Task<T> QueryFirstAsync<T>(string query, params object[] args) where T : new()
        {
            return Task.Run(() =>
            {
                lock (_locker)
                {
                    return Query<T>(query, args).FirstOrDefault();
                }
            });
        }

        public void SafeRunInTransaction(Action action)
        {
            lock (_locker)
            {
                RunInTransaction(action);
            }
        }

        public Task RunInTransactionAsync(Action action)
        {
            return Task.Run(() =>
            {
                lock (_locker)
                {
                    RunInTransaction(action);
                }
            });
        }
    }
}