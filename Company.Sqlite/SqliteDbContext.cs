using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Sqlite
{
    public class SqliteDbContext : DbContext
    {
        // 创建数据库映射
        public SqliteDbContext() : base("SqliteDbContext")
        {
            
        }
    }
}
