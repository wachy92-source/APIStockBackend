using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIStock.Core.Entities
{
    public class StockItem
    {
        public int Id { get; set; }
        public string Estilo { get; set; }
        public string Color { get; set; }
        public int Total { get; set; }
        public string Talla { get; set; }
    }
}

