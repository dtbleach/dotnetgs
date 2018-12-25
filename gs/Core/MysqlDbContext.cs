using gs.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gs.Core
{
    public class MysqlDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=www.afanti.org.cn;port=3306;database=logs;uid=root;pwd=1qazxsw2;");
        }
        public virtual DbSet<lg> LG { get; set; }
    }
}
