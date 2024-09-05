using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.DTOs.Stock;
using api.Mappers;
using api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Logging;

namespace api.Controllers
{
    [Route("api/stock")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public StockController(ILogger<StockController> logger, ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var stocks = _context.Stocks.ToList()
            .Select(x => x.ToStockDto());

            // return 5 stocks
            return Ok(stocks.Take(5));
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var stock = _context.Stocks.Find(id);
            if (stock == null)
                return NotFound();

            return Ok(stock.ToStockDto());
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateStockRequestDto stockDto)
        {
            var stockModel = stockDto.ToStockFromCreateDTO();
            _context.Stocks.Add(stockModel);
            _context.SaveChanges();

            // Passes in new stockModel object into GetById() using the id
            // Returns in form of ToStockDto
            return CreatedAtAction(nameof(GetById), new { id = stockModel.Id }, stockModel.ToStockDto());
        }

        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Update([FromRoute] int id, [FromBody] UpdateStockRequestDto updateDto)
        {
            var stockModel = _context.Stocks.FirstOrDefault(x => x.Id == id);

            if (stockModel == null)
            {
                return NotFound();
            }

            stockModel.Symbol = updateDto.Symbol;
            stockModel.Name = updateDto.Name;
            stockModel.CurrentPrice = updateDto.CurrentPrice;
            stockModel.Industry = updateDto.Industry;
            stockModel.MarketCap = updateDto.MarketCap;
            stockModel.Sector = updateDto.Sector;

            _context.SaveChanges();

            return Ok(stockModel.ToStockDto());
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete([FromRoute] int id){
            var stockModel = _context.Stocks.FirstOrDefault(x => x.Id == id);

            if(stockModel == null){
                return NotFound();
            }

            _context.Stocks.Remove(stockModel);

            _context.SaveChanges();

            return NoContent();
        }
    }
}