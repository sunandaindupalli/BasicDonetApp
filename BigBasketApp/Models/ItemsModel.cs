using System;
using System.ComponentModel.DataAnnotations;

namespace BigBasketApp.Models{
    public class BasketItems{
        [Key] public int? ItemId { get; set; }
        [Required] public string? Name { get; set;}
        [Required] public string? Description { get;set;}
        [Required] public string? Category { get; set;}
        [Required] public double? Price { get; set;}
        [Required] public string? Quantity { get; set;}
    }
}