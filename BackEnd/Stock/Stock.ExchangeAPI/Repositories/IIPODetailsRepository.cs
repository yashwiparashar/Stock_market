using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Stock.ExchangeAPI.Entities;
namespace Stock.ExchangeAPI.Repositories
{
    interface IIPODetailsRepository
    {
        void AddIpo(Ipo ipo);
        void DeleteIpo(string name);
        List<Ipo> GetAllIpo();
        Ipo GetIpoByName(string name);
        void UpdateIpo(Ipo ipo);






    }
}
