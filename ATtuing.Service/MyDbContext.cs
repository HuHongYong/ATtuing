using ATtuing.Service.Entities;
using log4net;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ATtuing.Service
{
    public class MyDbContext : DbContext
    {
        //ILog ILogger,
        private static ILog log = LogManager.GetLogger(typeof(MyDbContext));
        public MyDbContext() : base("name=OracleDbContext")
        {
            Database.SetInitializer<MyDbContext>(null);
            this.Database.Log = (sql) => {
                log.DebugFormat("EF执行SQL：{0}", sql);
            };
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<EQEventEntity> EQEvents { get; set; }
        public DbSet<EQEventTaskEntity>  EQEventTasks { get; set; }
    }
}
