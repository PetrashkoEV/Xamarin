using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite.Net;

namespace SelfEducation.Business.Data.Repository.Private
{
    public interface IConnectionExtensions
    {
        int SafeInsertAll(IEnumerable objects);
        Task<T> ExecuteScalarAsync<T>(string query, params object[] args);
        T SafeExecuteScalar<T>(string query, params object[] args);
        int SafeExecute(string query, params object[] args);
        Task<int> ExecuteAsync(string query, params object[] args);
        Task<int> InsertAsync(object obj);
        int SafeInsert(object obj);
        IEnumerable<T> SafeDeferredQuery<T>(string query, params object[] args) where T : new();
        int SafeUpdate(object obj);
        Task<int> UpdateAsync(object obj);
        List<T> SafeQuery<T>(string query, params object[] args) where T : new();
        Task<List<T>> QueryAsync<T>(string query, params object[] args) where T : new();
        Task<T> QueryFirstAsync<T>(string query, params object[] args) where T : new();
        void SafeRunInTransaction(Action action);
        Task RunInTransactionAsync(Action action);
    }
}