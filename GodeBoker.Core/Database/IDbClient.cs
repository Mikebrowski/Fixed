using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace GodeBoker.Core.Database
{
    public interface IDbClient
    {
        IMongoCollection<RegisteredBook> GetRegisteredBookCollection();
    }
}
