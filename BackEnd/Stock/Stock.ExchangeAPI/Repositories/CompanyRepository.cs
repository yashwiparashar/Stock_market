using Stock.ExchangeAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stock.ExchangeAPI.Repositories
{
    public class CompanyRepository: ICompanyRepository
    {
        private readonly StockDBContext db = new StockDBContext();
        public  void AddCompany(Company company)
        {
            
                db.Companies.Add(company);
                db.SaveChanges();
            
        }
        public void DeleteCompany(string name)
        {
            Company item = db.Companies.SingleOrDefault(i => i.CompanyName == name);
            db.Companies.Remove(item); //remove item
            db.SaveChanges();

        }
        public List<Company> GetAllCompany()
        {
            return db.Companies.ToList();
        }
        public Company GetCompanyByName(string name)
        {
            return db.Companies.SingleOrDefault(i => i.CompanyName == name);
        }
        public void UpdateCompany(Company company)
        {
            db.Companies.Update(company);
            db.SaveChanges();
        }






    }
}
