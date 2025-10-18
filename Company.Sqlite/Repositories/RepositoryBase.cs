using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Sqlite.Repositories
{
    public abstract class RepositoryBase
    {
        private static readonly Lazy<SqliteDbContext> _lazyDb = new Lazy<SqliteDbContext>(() => new SqliteDbContext());
        protected static SqliteDbContext db => _lazyDb.Value;
    }
}
