using Company.Sqlite.Models;
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

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            var sqliteConnect = new DropCreateDatabaseIfModelChanges<SqliteDbContext>();

            Database.SetInitializer(sqliteConnect);
        }
    }
}
