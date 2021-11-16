using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Stock.ExchangeAPI.Entities;

namespace Stock.ExchangeAPI.Repositories
{
    interface ISectorsRepository
    {
        void AddSectors(Sectors sector);
        void DeleteSectors(string name);
        List<Sectors> GetAllSectors();
        Sectors GetSectorsByName(string name);
        void UpdateSectors(Sectors sector);



    }
}
