using System;
using BigBasketApp.Models;
using BigBasketApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BigBasketApp{
    [ApiController]
    public class ItemsController : ControllerBase{
        ItemsContext db;
        public ItemsController(ItemsContext itemContext){
            db = itemContext;
        }
        [HttpGet][Route("/[controller]/getAllItems")]
        public IActionResult Get() {
            List<BasketItems> items = db.Items.ToList();
            return Ok(items);
        }

        [HttpGet][Route("/[controller]/getItemById")]
        public IActionResult Get(int id) {
            BasketItems? item = db.Items.Find(id);
            return Ok(item);
        }
        [HttpGet][Route("/[controller]/getItemByName")]
        public IActionResult Get(string name) {
            BasketItems? item = db.Items.FirstOrDefault(x => x.Name == name);
            return Ok(item);
        }

        [HttpPost][Route("/[controller]/AddItem")]
        public IActionResult Create([FromBody] BasketItems item) {
            if(ModelState.IsValid)
                db.Items.Add(item);
                db.SaveChanges();
                return Ok(item);
        }
        [HttpPut][Route("/[controller]/updateItem")]
        public IActionResult Update(int id, [FromBody] BasketItems item){
            BasketItems? data = db.Items.FirstOrDefault( x => x.ItemId == id);
            if(data!=null){
                data.Name = item.Name;
                data.Description = item.Description;
                data.Quantity = item.Quantity;
                data.Price = item.Price;
                data.Category = item.Category;
                db.SaveChanges();
                return Ok("Item data Updated Successfully");
            }else{
                return BadRequest("Item data Not Updated");
            }
        }
        [HttpDelete][Route("/[controller]/deleteItem")]
        public IActionResult Delete(int id){
           BasketItems? item = db.Items.Find(id);
           if(item!=null){
            db.Items.Remove(item);
            db.SaveChanges();
            return Ok("Item with id "+ item.ItemId +" has been deleted");}
           else{
            return BadRequest(" Item id not found");
            }
        }

    }
}