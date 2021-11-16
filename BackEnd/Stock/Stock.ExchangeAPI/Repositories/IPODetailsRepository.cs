using Stock.ExchangeAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stock.ExchangeAPI.Repositories
{
    public class IPODetailsRepository: IIPODetailsRepository
    {
        private readonly StockDBContext db = new StockDBContext();
        public void AddIpo(Ipo ipo)
        {
            db.Ipos.Add(ipo);
            db.SaveChanges();
        }
        public void DeleteIpo(string name)
        {
            Ipo ipo = db.Ipos.SingleOrDefault(i=>i.IpoCompanyName == name);
            db.Ipos.Remove(ipo); //remove item
            db.SaveChanges();

        }
        public List<Ipo> GetAllIpo()
        {
            return db.Ipos.ToList();
        }
        public Ipo GetIpoByName(string name)
        {
            
                return db.Ipos.FirstOrDefault(i => i.IpoCompanyName == name);
            
        }
        public void UpdateIpo(Ipo ipo)
        {
            db.Ipos.Update(ipo);
            db.SaveChanges();
        }






    }
}
