using System;
using BigBasketApp.Models;
using BigBasketApp.Data;
using Microsoft.AspNetCore.Mvc;
// using Microsoft.AspNetCore.JsonPatch;
using BigBasketApp;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore.ChangeTracking;
// using System.Text.Json;
namespace BigBasketApp{
    [ApiController]
    public class CustomerController : ControllerBase{
        CustomerContext db;
        public CustomerController(CustomerContext customerContext){
            db = customerContext;
            // _customerRepository = customerContext;
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
        //  [HttpPatch][Route("/[controller]/patchCustomer/{id}")] 
        //         public IActionResult Patch(int id, [FromBody] JsonPatchDocument cust)
        //         {
        //             // var updatedEmployee = await _employeeRepository.UpdateEmployeePatchAsync(id, employeeDocument);
        //             if(cust == null){
        //                 return BadRequest("input data should not be null");
        //             }
        //             Customers? data = db.Customers.FirstOrDefault(x => x.Id == id);
        //             if(data == null){
        //                 return BadRequest("Id not found");
        //             }
        //             cust.ApplyTo(data);
        //             db.SaveChangesAsync();
        //             var cList = db.Customers.ToList();
        //             var index = cList.FindIndex(x => x.Id == id);
        //             if (index != -1)
        //             {
        //                 // Update the product at the found index
        //                 cList[index] = data;
        //             }
        //             return Ok("Updated Successfully");
        //         }

        [HttpPut][Route("/[controller]/updateCustomer/{id}")]
        public  IActionResult Update(int id, Customers customer){
        Customers? data = db.Customers.FirstOrDefault(x => x.Id == id);
        if(data!=null && customer!=null){
            data.Name = customer.Name;
            data.Email = customer.Email;
            data.Password = customer.Password;
            data.Phone = customer.Phone;
            data.Address = customer.Address;
            // db.Customers.Update(customer);
            db.SaveChanges();
            return Ok("Updated successfully");
        }else{
            return BadRequest("Not Updated");
        }
        }
        // [HttpPost][Route("/[controller]/createCustomer")]
        // public IActionResult Create([FromBody] Customers u){
        //     if(ModelState.IsValid){
        //     db.Customers.Add(u);
        //     db.SaveChanges();
        //     return Ok("Customer details inserted");
        //     }else{
        //         return BadRequest("Customer details not inserted");
        //     }
        // }

        [HttpPost][Route("/[controller]/createCustomer")]
        public async Task<ActionResult<Customers>> Create(Customers c)
        {
            db.Customers.Add(c);
            await db.SaveChangesAsync();
            return  CreatedAtAction(nameof(Create), new { id = c.Id }, c);
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