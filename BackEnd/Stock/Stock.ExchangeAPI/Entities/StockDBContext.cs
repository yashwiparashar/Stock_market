using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Stock.ExchangeAPI.Entities
{
    public class StockDBContext: DbContext
    {

        public DbSet<Company> Companies{ get; set; }
        public DbSet<Sectors> Sectorss{ get; set; }
        public DbSet<Exchange> Exchanges { get; set; }
        public DbSet<Ipo> Ipos { get; set; }
        public DbSet<Price> StockPrices { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-NCG816RS\SQLEXPRESS;Initial Catalog=StockDB;Integrated Security=True");
        }

    }
}
