using Stock.ExchangeAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stock.ExchangeAPI.Repositories
{
    public class ExchangeRepository: IExchangeRepository
    {
        private readonly StockDBContext db = new StockDBContext();
        public void AddExchange(Exchange exchange)
        {
            db.Exchanges.Add(exchange);
            db.SaveChanges();
        }
        public void DeleteExchange(string name) {
            Exchange item = db.Exchanges.SingleOrDefault(i => i.StockName == name);
            db.Exchanges.Remove(item); //remove item
            db.SaveChanges();

        }
        public List<Exchange> GetAllExchange()
        {
            return db.Exchanges.ToList();
        }
        public Exchange GetExchangeByName(string name)
        {
            return db.Exchanges.SingleOrDefault(i => i.StockName == name);
        }
        public void UpdateExchange(Exchange exchange)
        {
            db.Exchanges.Update(exchange);
            db.SaveChanges();
        }




    }
}
