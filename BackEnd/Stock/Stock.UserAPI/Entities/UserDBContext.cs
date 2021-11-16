using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Stock.UserAPI.Entities
{
    public class UserDBContext : DbContext
    {

        public DbSet<User> Users { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-NCG816RS\SQLEXPRESS;Initial Catalog=StockDB;Integrated Security=True");
        }

    }
}
