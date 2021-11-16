using Stock.ExchangeAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stock.ExchangeAPI.Repositories
{
    public class SectorsRepository: ISectorsRepository
    {
        private readonly StockDBContext db = new StockDBContext();
        public  void AddSectors(Sectors sector)
        {
            
                db.Sectorss.Add(sector);
                db.SaveChanges();
            
        }
        public void DeleteSectors(string name)
        {
            Sectors item = db.Sectorss.FirstOrDefault(i => i.SectorName == name);
            db.Sectorss.Remove(item); //remove item
            db.SaveChanges();

        }


        public List<Sectors> GetAllSectors()
        {
            return db.Sectorss.ToList();
        }
       public  Sectors GetSectorsByName(string name)
        {
            return db.Sectorss.SingleOrDefault(i => i.SectorName == name);
        }
        public void UpdateSectors(Sectors sector)
        {
            db.Sectorss.Update(sector);
            db.SaveChanges();
        }





    }
}
