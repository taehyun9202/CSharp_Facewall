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
            ViewBag.allMessages = _context.Messages.Include(m => m.Creator)
                                                   .ThenInclude(m => m.Reply)
                                                   .OrderByDescending(m => m.CreatedAt)
                                                   .ToList();
            ViewBag.allComments = _context.Comments.OrderByDescending(c => c.CreatedAt)
                                                   .ToList();
            ViewBag.allUsers = _context.Users.ToList();
            if(userInDB == null)
            {
                return RedirectToAction("Logout");
            }
            else
            {
                ViewBag.getUser = userInDB;
                return View("Dashboard");
            }
        }
        [HttpPost("message")]
        public IActionResult Create(Message newMessage)
        {
            int? ID = HttpContext.Session.GetInt32("userinSession");
            ViewBag.getUser = _context.Users.FirstOrDefault(u=>u.UserId==ID);
            User userInDB = _context.Users.FirstOrDefault(u=>u.UserId==ID);
            if(userInDB == null)
            {
                return RedirectToAction("Logout");
            }
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
        [HttpPost("comment")]
        public IActionResult Reply(Comment newComment)
        {
            int? ID = HttpContext.Session.GetInt32("userinSession");
            ViewBag.getUser = _context.Users.FirstOrDefault(u=>u.UserId==ID);
            User userInDB = _context.Users.FirstOrDefault(u=>u.UserId==ID);
            if(userInDB == null)
            {
                return RedirectToAction("Logout");
            }
            else{
                if(ModelState.IsValid)
                {
                    newComment.UserId = (int)ID; 
                    _context.Comments.Add(newComment);
                    _context.SaveChanges();
                    return Redirect("/dashboard");
                }
                else
                {
                    return View("/dashboard");
                }
            }
        }
        [HttpGet("/user/{userID}")]
        public IActionResult UserInfo(int userID)
        {
            int? ID = HttpContext.Session.GetInt32("userinSession");
            ViewBag.getUser = _context.Users.FirstOrDefault(u=>u.UserId==ID);
            ViewBag.getOne = _context.Users.FirstOrDefault(u => u.UserId == userID);
            ViewBag.allItems = _context.Items.Where(i => i.Uploader.UserId == userID)
                                             .ToList();
            ViewBag.allMessages = _context.Messages.Where(m => m.ToId == userID)
                                                   .Include(m => m.Reply)
                                                   .OrderByDescending(m => m.CreatedAt)
                                                   .ToList();
            ViewBag.allComments = _context.Comments.OrderByDescending(c => c.CreatedAt)
                                                   .ToList();
            ViewBag.allUsers = _context.Users.ToList();
            User userInDB = _context.Users.FirstOrDefault(u=>u.UserId==ID);
            if(userInDB == null)
            {
                return RedirectToAction("Logout");
            }
            return View("User");
        }

        [HttpPost("/user/{userID}")]
        public IActionResult Upload(Item newItem, int userID)
        {
            int? ID = HttpContext.Session.GetInt32("userinSession");
            ViewBag.getUser = _context.Users.FirstOrDefault(u=>u.UserId==ID);
            ViewBag.getOne = _context.Users.FirstOrDefault(u => u.UserId == userID);
            User userInDB = _context.Users.FirstOrDefault(u=>u.UserId==ID);
            if(userInDB == null)
            {
                return RedirectToAction("Logout");
            }
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
            ViewBag.allItems = _context.Items.Where(i => i.Uploader.UserId == userID)
                                             .ToList();
            User userInDB = _context.Users.FirstOrDefault(u=>u.UserId==ID);
            if(userInDB == null)
            {
                return RedirectToAction("Logout");
            }
            return View("Photos");
        }


        [HttpGet("/item/{itemID}")]
        public IActionResult ItemInfo(int itemID){
            int? ID = HttpContext.Session.GetInt32("userinSession");
            ViewBag.getUser = _context.Users.FirstOrDefault(u=>u.UserId==ID);
            ViewBag.getOne = _context.Items.FirstOrDefault(i => i.ItemId == itemID);
            User userInDB = _context.Users.FirstOrDefault(u=>u.UserId==ID);
            if(userInDB == null)
            {
                return RedirectToAction("Logout");
            }
            return View("Item");
        }
        [HttpGet("/user/{userID}/messages")]
        public IActionResult MessageList(int userID){
            int? ID = HttpContext.Session.GetInt32("userinSession");
            ViewBag.getUser = _context.Users.FirstOrDefault(u=>u.UserId==ID);
            ViewBag.getOne = _context.Users.FirstOrDefault(i => i.UserId == userID);
            ViewBag.allMessages = _context.Messages.Where(m => m.ToId == userID)
                                                   .OrderByDescending(m => m.CreatedAt)
                                                   .ToList();
            User userInDB = _context.Users.FirstOrDefault(u=>u.UserId==ID);
            if(userInDB == null)
            {
                return RedirectToAction("Logout");
            }
            return Redirect($"/user/{userID}");
        }


        [HttpGet("/item/{itemID}/delete")]
        public IActionResult DeleteItem(int itemID, int userID){
            int? ID = HttpContext.Session.GetInt32("userinSession");
            ViewBag.getUser = _context.Users.FirstOrDefault(u=>u.UserId==ID);
            Item delete = _context.Items.FirstOrDefault(i => i.ItemId == itemID);
            _context.Items.Remove(delete);
            _context.SaveChanges();
            User userInDB = _context.Users.FirstOrDefault(u=>u.UserId==ID);
            if(userInDB == null)
            {
                return RedirectToAction("Logout");
            }
            return Redirect($"/user/{userID}");
        }

        [HttpGet("user/{userID}/friends")]
        public IActionResult Friend(int userID){
            int? ID = HttpContext.Session.GetInt32("userinSession");
            ViewBag.getUser = _context.Users.FirstOrDefault(u=>u.UserId==userID);
            ViewBag.getOne = _context.Users.FirstOrDefault(u => u.UserId == userID);
            User userInDB = _context.Users.FirstOrDefault(u=>u.UserId==ID);
            if(userInDB == null)
            {
                return RedirectToAction("Logout");
            }
            return View("Friend");
        }
        // [HttpGet("addfriends")]
        // public IActionResult AddFriend(){
        //     int? ID = HttpContext.Session.GetInt32("userinSession");
        //     ViewBag.getUser = _context.Users.FirstOrDefault(u=>u.UserId==ID);
        //     User userInDB = _context.Users.FirstOrDefault(u=>u.UserId==ID);
        //     if(userInDB == null)
        //     {
        //         return RedirectToAction("Logout");
        //     }
        //     if(ModelState.IsValid)
        //     {
        //         newMessage.UserId = (int)ID; 
        //         _context.Messages.Add(newMessage);
        //         _context.SaveChanges();
        //         return Redirect("/dashboard");
        //     }
        //     else
        //     {
                
        //         return View("/dashboard");
        //     }
        // }



        [HttpGet("user/{userID}/edit")]
        public IActionResult Edit(int userID){
            int? ID = HttpContext.Session.GetInt32("userinSession");
            ViewBag.getUser = _context.Users.FirstOrDefault(u=>u.UserId==userID);
            User userInDB = _context.Users.FirstOrDefault(u=>u.UserId==ID);
            if(userInDB == null)
            {
                return RedirectToAction("Logout");
            }
            return View("Edit");
        }

        [HttpPost("update")]
        public IActionResult Update(){
            int? ID = HttpContext.Session.GetInt32("userinSession");
            User userInDB = _context.Users.FirstOrDefault(u=>u.UserId==ID);
            if(ModelState.IsValid)
            {
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                userInDB.Password = Hasher.HashPassword(userInDB, userInDB.Password);
                _context.SaveChanges();
                HttpContext.Session.SetInt32("userinSession", userInDB.UserId);
                return Redirect($"/user/{userInDB.UserId}");
            }
            else{
                return Redirect($"/user/{userInDB.UserId}/edit");
            }
        }

        // [HttpPost("like")]
        // public IActionResult Like()
        // {

        // }

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
