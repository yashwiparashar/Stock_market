using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StockAdminAPI.Entities
{
    public class AdminDBContext : DbContext
    {
        public DbSet<Admindetails> Admindetailss { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-NCG816RS\SQLEXPRESS;Initial Catalog=StockDB;Integrated Security=True");
        }



    }
}
