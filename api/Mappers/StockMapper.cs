using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.DTOs.Stock;
using api.Models;

namespace api.Mappers
{
    public static class StockMapper
    {
        public static StockDto ToStockDto(this Stock stock){
            return new StockDto
            {
                Id = stock.Id,
                Symbol = stock.Symbol,
                Name = stock.Name,
                CurrentPrice = stock.CurrentPrice,
                Industry = stock.Industry,
                Sector = stock.Sector,
                MarketCap = stock.MarketCap,
                Exchange = stock.Exchange,
            };
        }
    }
}