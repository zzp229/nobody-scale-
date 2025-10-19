using Company.Sqlite.Models;
using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Sqlite
{
    /// <summary>
    /// SQLite数据库配置类
    /// </summary>
    //public class SQLiteConfiguration : DbConfiguration
    //{
    //    public SQLiteConfiguration()
    //    {
    //        SetProviderFactory("System.Data.SQLite", SQLiteFactory.Instance);
    //        SetProviderFactory("System.Data.SQLite.EF6", SQLiteFactory.Instance);
    //    }
    //}

    //[DbConfigurationType(typeof(SQLiteConfiguration))]
    public class SqliteDbContext : DbContext
    {
        // 创建数据库映射
        public SqliteDbContext() : base("SqliteDbContext")
        {
            
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);

            // 注入sqliteDbContext，没表就新建表
            var sqliteConnect = new SqliteCreateDatabaseIfNotExists<SqliteDbContext>(modelBuilder);

            Database.SetInitializer(sqliteConnect);
        }
    }
}
