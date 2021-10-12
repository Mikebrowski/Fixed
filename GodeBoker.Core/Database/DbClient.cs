using GodeBoker.Core;
using GodeBoker.Core.Database;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Bookstore.Core
{
    public class DbClient : IDbClient
    {
        private readonly IMongoCollection<RegisteredBook> _RegisteredBook;

        public DbClient(IOptions<BookstoreDbConfig> bookstoreDbConfig)
        {
            var client = new MongoClient(DbConfig.Value.Connection_String);
            var database = client.GetDatabase(DbConfig.Value.Database_Name);
            _RegisteredBook = database.GetCollection<RegisteredBook>(DbConfig.Value.Table_name);
        }

        public IMongoCollection<RegisteredBook> GetRegisteredBookCollection() => _RegisteredBook;
    }
}

