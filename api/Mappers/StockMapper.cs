using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.DTOs.Stock;
using api.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace api.Mappers
{
    public static class StockMapper
    {
        public static StockDto ToStockDto(this Stock stock)
        {
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

        public static Stock ToStockFromCreateDTO(this CreateStockRequestDto stockDto)
        {
            return new Stock
            {
                Symbol = stockDto.Symbol,
                Name = stockDto.Name,
                CurrentPrice = stockDto.CurrentPrice,
                Industry = stockDto.Industry,
                Sector = stockDto.Sector,
                MarketCap = stockDto.MarketCap,
                Exchange = stockDto.Exchange,
            };

        }
    }

}