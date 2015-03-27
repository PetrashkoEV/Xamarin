using SelfEducation.Business.Data.Contracts.Private;
using SelfEducation.Business.Data.Entities;
using SelfEducation.Business.Data.Services.Transaction.Private;
using SQLite.Net;
using SQLite.Net.Interop;

namespace SelfEducation.Business.Data.Services.Transaction
{
    public class CreateTablesTransaction : SQLiteConnection, ICreateTablesTransaction
    {
        public CreateTablesTransaction(ISQLitePlatform sqlitePlatform, IDbLocation databasePath)
            : base(sqlitePlatform, databasePath.DatabaseFilePath)
        {
        }

        public void Execute()
        {
            CreateTable<CurrencyEntity>();
        }
    }
}