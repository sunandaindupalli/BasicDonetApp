using System;
using BigBasketApp.Models;
using BigBasketApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace BigBasketApp{
    [ApiController]
    public class UserController : ControllerBase{
        UserContext db;
        public UserController(UserContext userContext){
            db = userContext;
        }
        [HttpGet][Route("/[controller]/getAllUsers")]
        public IActionResult Get(){
            List<Users> users = db.Users.ToList();
            return Ok(users);
        }
        [HttpGet][Route("/[controller]/getUserById")]
        public IActionResult Get(int id){
            Users? user = db.Users.Find(id);
            return Ok(user);
        }
        [HttpGet][Route("/[controller]/getUserByName")]
        public IActionResult Get(string name){
            Users? user = db.Users.FirstOrDefault(x => x.Name == name);
            return Ok(user);
        }
        [HttpPost][Route("/[controller]/createUser")]
        public IActionResult Create([FromBody] Users u){
            if(ModelState.IsValid)
            db.Users.Add(u);
            db.SaveChanges();
            return Ok();
        }
        [HttpPut][Route("/[controller]/updateUser")]
        public IActionResult Update(int id, [FromBody] Users user){
            Users? userData = db.Users.FirstOrDefault( x => x.UserId == id);
            if(userData!=null){
                userData.Name = user.Name;
                userData.Password = user.Password;
                db.SaveChanges();
                return Ok("User details Updated Successfully");
            }else{
                return BadRequest("User data Not Updated");
            }
        }
        [HttpDelete][Route("/[controller]/deleteUser")]
        public IActionResult Delete(int id){
           Users? user = db.Users.Find(id);
           if(user!=null){
            db.Users.Remove(user);
            db.SaveChanges();
            return Ok("User with id "+user.UserId+" has been deleted");}
           else{
            return BadRequest(" user id not found");
            }
        }
    }
}