using System;
using System.ComponentModel.DataAnnotations;

namespace BigBasketApp.Models{
    public class Orders{
        [Key] public int? OrderId { get; set; }
        public int? ItemId { get; set;}
        public int? CustomerId { get; set; }
        public string? OrderStatus { get; set; }
        public double? TotalAmount { get; set; }
        public string? OrderDate { get; set; }

    }
}