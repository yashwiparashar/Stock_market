using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Stock.ExchangeAPI.Entities;

namespace Stock.ExchangeAPI.Repositories
{
    interface ICompanyRepository
    {
        void AddCompany(Company company);
        void DeleteCompany(string name);
        List<Company> GetAllCompany();
        Company GetCompanyByName(string name);
        void UpdateCompany(Company company);



    }
}
