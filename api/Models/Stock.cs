using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Stock
    {
        public int Id { get; set; }

        [Column(TypeName = "char(3)")]
        public string Exchange { get; set; }

        [Column(TypeName = "char(5)")]
        public string Symbol { get; set; } = String.Empty;

        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; } = String.Empty;

        [Column(TypeName = "nvarchar(150)")]
        public string Sector { get; set; } = String.Empty;
        [Column(TypeName = "nvarchar(150)")]
        public string Industry { get; set; } = String.Empty;

        [Column(TypeName = "decimal(16,2)")]
        public decimal CurrentPrice { get; set; }

        [Column(TypeName = "decimal(16,2)")]
        public decimal MarketCap { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}