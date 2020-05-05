using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Wall.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Wall.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
        public HomeController(MyContext context)
        {
            _context = context;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("register")]
        public IActionResult Register(User newUser)
        {
            if(ModelState.IsValid)
            {
                if(_context.Users.Any(u => u.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email Already Exist");
                    return View("Index");
                }
                else
                {
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                    _context.Users.Add(newUser);
                    _context.SaveChanges();
                    HttpContext.Session.SetInt32("userinSession", newUser.UserId);
                    return Redirect("/dashboard");
                }
            }
            else
            {
                return View("Index");
            }
        }

        [HttpPost("login")]
        public IActionResult Login(LoginUser userIn)
        {
            if(ModelState.IsValid)
            {
                var userInDb = _context.Users.FirstOrDefault(u => u.Email == userIn.LoginEmail);
                if(userInDb == null){
                    ModelState.AddModelError("LoginEmail","Invalid Email Address");
                    return View("Index");
                }
                else
                {
                    var hash = new PasswordHasher<LoginUser>();
                    var result = hash.VerifyHashedPassword(userIn, userInDb.Password, userIn.LoginPassword);
                    if(result == 0)
                    {
                        ModelState.AddModelError("LoginPassword","Invalid Password");
                        return View("Index");
                    }
                    else
                    {
                        //userId stored in userinSession
                        HttpContext.Session.SetInt32("userinSession", userInDb.UserId);
                        return Redirect("/dashboard");
                    }
                }
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet("dashboard")]
        public IActionResult Dashbaord()
        {
            int? ID = HttpContext.Session.GetInt32("userinSession");
            User userInDB = _context.Users.FirstOrDefault(u=>u.UserId==ID);
            List<Message> userMessage = _context.Messages.Where(m => m.UserId == ID).ToList();
            if(userInDB == null)
            {
                return RedirectToAction("Logout");
            }
            else
            {
                ViewBag.User = userInDB;
                return View("Dashboard");
            }
        }
        [HttpPost("message")]
        public IActionResult Create(Message newMessage)
        {
            int? ID = HttpContext.Session.GetInt32("userinSession");
            ViewBag.getUser = _context.Users.FirstOrDefault(u=>u.UserId==ID);
            if(ModelState.IsValid)
            {
                newMessage.UserId = (int)ID; 
                _context.Messages.Add(newMessage);
                _context.SaveChanges();
                return Redirect("/dashboard");
            }
            else
            {
                
                return View("/dashboard");
            }
        }
        [HttpGet("/user/{userID}")]
        public IActionResult UserInfo(int userID)
        {
            int? ID = HttpContext.Session.GetInt32("userinSession");
            ViewBag.getUser = _context.Users.FirstOrDefault(u=>u.UserId==ID);
            ViewBag.getOne = _context.Users.FirstOrDefault(u => u.UserId == userID);
            return View("User");
        }

        [HttpPost("/user/{userID}")]
        public IActionResult Upload(Item newItem, int userID)
        {
            int? ID = HttpContext.Session.GetInt32("userinSession");
            ViewBag.getUser = _context.Users.FirstOrDefault(u=>u.UserId==ID);
            ViewBag.getOne = _context.Users.FirstOrDefault(u => u.UserId == userID);
            if(ModelState.IsValid)
            {
                newItem.UserId = (int)ID; 
                _context.Items.Add(newItem);
                _context.SaveChanges();
                return Redirect($"/user/{userID}");
            }
            else
            {
                return Redirect($"/user/{userID}");
            }
        }
        [HttpGet("/user/{userID}/allphotos")]
        public IActionResult Photos(int userID){
            int? ID = HttpContext.Session.GetInt32("userinSession");
            ViewBag.getUser = _context.Users.FirstOrDefault(u=>u.UserId==ID);
            ViewBag.getOne = _context.Users.FirstOrDefault(u => u.UserId == userID);
            List<Item> allItems = _context.Items.Where(i => i.UserId == userID)
                                                .ToList();
            return RedirectToAction("UserInfo", allItems);
        }











        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("userinSession");
            HttpContext.Session.Clear();
            return Redirect("/");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
