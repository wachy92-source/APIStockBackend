using APIStock.Application;
//using APIStock.Application.Services;
using APIStock.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIStock.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StockController : ControllerBase
    {
        private readonly StockService _stockService;

        public StockController(StockService stockService)
        {
            _stockService = stockService;
        }

        [HttpGet]
        public async Task<ActionResult<List<StockItem>>> GetStock()
        {
            var stock = await _stockService.GetStockAsync();
            return Ok(stock);
        }
    }
}
