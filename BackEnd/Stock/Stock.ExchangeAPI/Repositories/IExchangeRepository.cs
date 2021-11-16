using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Stock.ExchangeAPI.Entities;

namespace Stock.ExchangeAPI.Repositories
{
    interface IExchangeRepository
    {

        void AddExchange(Exchange exchange);
        void DeleteExchange(string name);
        List<Exchange> GetAllExchange();
        Exchange GetExchangeByName(string name);
        void UpdateExchange(Exchange exchange);






    }
}
