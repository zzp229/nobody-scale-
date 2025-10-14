using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Sqlite
{
    internal class SqliteDbContext : DbContext
    {
        public SqliteDbContext() : base("SqliteDbContext")
        {
            
        }
    }
}
