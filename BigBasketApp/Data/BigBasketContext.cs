using System;
using Microsoft.EntityFrameworkCore;
using BigBasketApp.Models;

namespace BigBasketApp.Data{
    public class UserContext : DbContext{
        public UserContext(DbContextOptions<UserContext> options) : base(options){
            
        }
        protected override void OnModelCreating(ModelBuilder userBuilder){
            userBuilder.Entity<Users>().HasData(
                new Users { Name= "Sunanda" , Password ="123", UserId = 101},
                new Users { Name= "Siva" , Password ="1234", UserId = 102},
                new Users { Name= "Charan" , Password ="12345", UserId = 103},
                new Users { Name= "Syamala" , Password ="1236", UserId = 104},
                new Users { Name= "Bhaskar" , Password ="1237", UserId = 105}
            );
            base.OnModelCreating(userBuilder);
        }
        public DbSet<Users> Users { get; set; }
    }

    public class ItemsContext : DbContext {

        public ItemsContext(DbContextOptions<ItemsContext> options) :base(options) {}

        protected override void OnModelCreating(ModelBuilder itemBuilder){
            itemBuilder.Entity<BasketItems>().HasData(
                new BasketItems{ ItemId = 1001, Name = "Tomato", Description ="Hybrid Tomato's", Price =20.0, Quantity="500g", Category = "Vegitable",},
                new BasketItems{ ItemId = 1002, Name = "Onions", Description ="Organically grown", Price =25.0, Quantity="1kg", Category = "Vegitable",},
                new BasketItems{ ItemId = 1003, Name = "Coriander Leaves", Description ="Fresh Coriander", Price =10.0, Quantity="200g", Category = "Vegitable",},
                new BasketItems{ ItemId = 1004, Name = "Carrot", Description ="Hybrid Carrots", Price =50.0, Quantity="500g", Category = "Vegitable",},
                new BasketItems{ ItemId = 1005, Name = "Potato", Description ="Potato's Loose", Price =30.0, Quantity="1kg", Category = "Vegitable",},
                new BasketItems{ ItemId = 1006, Name = "Apples", Description ="Organic Apples", Price =200.0, Quantity="1kg", Category = "Fruits",},
                new BasketItems{ ItemId = 1007, Name = "Oranges", Description ="Hybrid Oranges's", Price =120.0, Quantity="500g", Category = "Fruits",},
                new BasketItems{ ItemId = 1008, Name = "Banana", Description ="Local", Price =50.0, Quantity="1kg", Category = "Fruits",},
                new BasketItems{ ItemId = 1009, Name = "Chillies", Description ="Green Chillies", Price =10.0, Quantity="100g", Category = "Vegitable",},
                new BasketItems{ ItemId = 1010, Name = "Curry leaves", Description ="Curry leaves loose", Price =5.0, Quantity="100g", Category = "Vegitable",},
                new BasketItems{ ItemId = 1011, Name = "Mango", Description ="Organic Mango's", Price =200.0, Quantity="1.5kg", Category = "Fruits",},
                new BasketItems{ ItemId = 1012, Name = "Lemon", Description ="Lemons", Price =8.0, Quantity="1pc", Category = "Vegitable",}
            );
            base.OnModelCreating(itemBuilder);
        }
        public DbSet<BasketItems> Items { get; set; }
    }
}