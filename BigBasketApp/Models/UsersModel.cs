using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace BigBasketApp.Models{
    public class Users{
        [Key]public int UserId { get; set;}
        public required string? Name { get; set;}
        public required string? Password { get; set;}
    }
}
