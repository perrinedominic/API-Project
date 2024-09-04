using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.DTOs.Stock
{
    public class UpdateStockRequestDto
    {
        public string Exchange { get; set; }

        public string Symbol { get; set; } = String.Empty;

        public string Name { get; set; } = String.Empty;

        public string Sector { get; set; } = String.Empty;
        public string Industry { get; set; } = String.Empty;

        public decimal CurrentPrice { get; set; }

        public decimal MarketCap { get; set; }
    }
}