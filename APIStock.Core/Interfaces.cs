using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIStock.Core.Entities;

namespace APIStock.Core.Interfaces
{
    public interface IStockRepository
    {
        Task<List<StockItem>> GetStockAsync();
    }
}
