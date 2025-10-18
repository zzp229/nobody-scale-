using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Sqlite.Repositories
{
    public abstract class RepositoryBase
    {
        protected static SqliteDbContext db { get; } = new Lazy<SqliteDbContext>().Value;
    }
}
