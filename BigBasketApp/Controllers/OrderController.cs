using System;
using BigBasketApp.Models;
using BigBasketApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace BigBasketApp{
    [ApiController]
    public class OrderController : ControllerBase{
        OrderContext db;
        public OrderController(OrderContext orderContext){
            db = orderContext;
        }
        [HttpGet][Route("/[controller]/getAllOrders")]
        public IActionResult Get(){
            List<Orders> orders = db.Orders.ToList();
            return Ok(orders);
        }
        [HttpGet][Route("/[controller]/getOrderById")]
        public IActionResult Get(int id){
            Orders? order = db.Orders.Find(id);
            return Ok(order);
        }
       // [HttpGet][Route("/[controller]/getOrderByCustId")]
        // public IActionResult Get(int CustId){
        //     return db.Orders?.SingleOrDefault(x => x.CustomerId == CustId);
        //     // return db.Orders.ToList(x => x.CustomerId == CustId);
        // }
        [HttpPost][Route("/[controller]/createOrder")]
        public IActionResult Create([FromBody] Orders u){
            if(ModelState.IsValid)
            db.Orders.Add(u);
            db.SaveChanges();
            return Ok("Order initiated");
        }
        [HttpDelete][Route("/[controller]/deleteOrder")]
        public IActionResult Delete(int id){
           Orders? order = db.Orders.Find(id);
           if(order!=null){
            db.Orders.Remove(order);
            db.SaveChanges();
            return Ok("Order with id "+order.OrderId+" has been deleted");
            }else{
                return BadRequest(" user id not found");
            }
        }
    }
}