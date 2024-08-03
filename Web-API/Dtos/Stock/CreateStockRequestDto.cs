﻿using System.ComponentModel.DataAnnotations;

namespace Web_API.Dtos.Stock
{
    public class CreateStockRequestDto
    {
        [Required]
        [MaxLength(10,ErrorMessage = "Symbol cannot be over 10 over character")]
        public string Symbol { get; set; } = string.Empty;

        [Required]
        [MaxLength(10, ErrorMessage = "Company name cannot be over 10 over character")]
        public string CompanyName { get; set; } = string.Empty;

        [Required]
        [Range(1,100000000)]
        public decimal Purchase { get; set; }

        [Required]
        [Range(0.001,100)]
        public decimal LastDiv { get; set; }

        [Required]
        [MaxLength(10,ErrorMessage = "Industry cannoct be over 10 character")]
        public string Industry { get; set; } = string.Empty;

        [Range(1,50000000)]
        public long MarketCap { get; set; }
    }
}
