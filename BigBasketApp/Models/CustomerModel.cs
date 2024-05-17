using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace BigBasketApp.Models{
    public class Customers{
        [Key]public int Id { get; set;}
        public string? Name { get; set;}
        public string? Email { get; set;}
        public string? Phone { get; set;}
        public string? Address { get; set;}
    }
}