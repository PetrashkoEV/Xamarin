using System;
using SelfEducation.Business.Data.Contracts.Private;
using SelfEducation.Business.Data.Entities;
using SelfEducation.Business.Data.Services.Transaction.Private;
using SQLite.Net;
using SQLite.Net.Interop;

namespace SelfEducation.Business.Data.Services.Transaction
{
    public class CreateDefaultTagsTransaction : SQLiteConnection, ICreateDefaultTagsTransaction
    {
        public CreateDefaultTagsTransaction(ISQLitePlatform sqlitePlatform, IDbLocation databasePath)
            : base(sqlitePlatform, databasePath.DatabaseFilePath)
        {
        }

        public void Execute()
        {
            Insert(new CurrencyEntity
            {
                CharCode = "CharCode",
                Name = "Name",
                NumCode = 1,
                OnDate = DateTime.Now,
                Rate = "Rate",
                Scale = 1
            });
        }
    }
}