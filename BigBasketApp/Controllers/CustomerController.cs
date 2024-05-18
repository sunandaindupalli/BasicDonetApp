using System;
using BigBasketApp.Models;
using BigBasketApp.Data;
using Microsoft.AspNetCore.Mvc;
using BigBasketApp;
namespace BigBasketApp{
    [ApiController]
    public class CustomerController : ControllerBase{
        CustomerContext db;
        public CustomerController(CustomerContext customerContext){
            db = customerContext;
        }

        [HttpGet][Route("/[controller]/getAllCustomers")]
        public IActionResult Get(){
            List<Customers> customers = db.Customers.ToList();
            return Ok(customers);
        }
        [HttpGet][Route("/[controller]/getCustomerById")]
        public IActionResult Get(int id){
            Customers? customer = db.Customers.Find(id);
            return Ok(customer);
        }
        [HttpGet][Route("/[controller]/getCustomerByName")]
        public IActionResult Get(string name){
            Customers? customer = db.Customers.FirstOrDefault(x => x.Name == name);
            return Ok(customer);
        }
        [HttpPut][Route("/[controller]/updateCustomer")]
        public IActionResult Update(int id,[FromBody] Customers customer){
            Customers? data = db.Customers.FirstOrDefault(x => x.Id == id);
            if(data!=null){
                data.Name = customer.Name;
                data.Email = customer.Email;
                data.Phone = customer.Phone;
                data.Address = customer.Address;
                // db.Customers.Update(customer);
                db.SaveChanges();
                return Ok("Updated successfully");
            }else{
                return BadRequest("Not Updated");
            }
        }
        [HttpPost][Route("/[controller]/createCustomer")]
        public IActionResult Create([FromBody] Customers u){
            if(ModelState.IsValid){
            db.Customers.Add(u);
            db.SaveChanges();
            return Ok("Customer details inserted");
            }else{
                return BadRequest("Customer details not inserted");
            }
        }
        [HttpDelete][Route("/[controller]/deleteCustomer")]
        public IActionResult Delete(int id){
           Customers? custId = db.Customers.Find(id);
           if(custId!=null){
            db.Customers.Remove(custId);
            db.SaveChanges();
            return Ok("Customer with id "+custId.Id+" has been deleted");}
           else{
            return BadRequest(" Customer id not found");
            }
        }
    }
}