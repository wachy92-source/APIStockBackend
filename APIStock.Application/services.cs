using APIStock.Core.Entities;
using APIStock.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIStock.Application
{
    public class StockService
    {
        private readonly IStockRepository _repository;

        public StockService(IStockRepository repository)
        {
            _repository = repository;
        }

        public Task<List<StockItem>> GetStockAsync()
        {
            return _repository.GetStockAsync();
        }
    }
}
