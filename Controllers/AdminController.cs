using MvcExamTaskMitRao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcExamTaskMitRao.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductMenu() {
            var _db = new ExamEntities();
            var emailforuser = Session["email"].ToString();
            var currentuser = _db.Users.FirstOrDefault(u => u.Email == emailforuser);
            var products = _db.ProductMenuItems.Where(p => p.ProductMenuId == 1).ToList();
            return View(products);
        }

        [HttpGet]
        public ActionResult CreateProductMenu()
        {
            return View();
        }

        [HttpGet]
        public ActionResult EditProductMenuItem(int id)
        {
            var _db = new ExamEntities();
            var emailforuser = Session["email"].ToString();
            var currentuser = _db.Users.FirstOrDefault(u => u.Email == emailforuser);
            var producttoedit = _db.ProductMenuItems.Where(p => p.id == id).FirstOrDefault();
            return View(producttoedit);
        }

        [HttpPost]
        public ActionResult UpdateProductItem(ProductMenuItem productMenuItem)
        {
            var _db = new ExamEntities();
            var producttoupdateid = productMenuItem.id;
            var producttoupdate = _db.ProductMenuItems.FirstOrDefault(p => p.id == producttoupdateid);
            producttoupdate.itemname = productMenuItem.itemname;
            producttoupdate.itemdesc = productMenuItem.itemdesc;
            _db.SaveChanges();
            return new RedirectResult("ProductMenu");
        }

        [HttpGet]
        public ActionResult DeleteProductMenuItem(int id)
        {
            var _db = new ExamEntities();
            var producttodelete = _db.ProductMenuItems.FirstOrDefault(p => p.id == id);
            //var producttoupdate = _db.ProductMenuItems.FirstOrDefault(p => p.id == producttoupdateid);
            _db.ProductMenuItems.Remove(producttodelete);
            _db.SaveChanges();
            return new RedirectResult("~/Admin/ProductMenu");
        }

        [HttpPost]
        public ActionResult CreateProductMenu(ProductMenuItem menuitem)
        {
            var _db = new ExamEntities();
            _db.ProductMenuItems.Add(menuitem);
            menuitem.ProductMenuId = 1;
            _db.SaveChanges();
            return new RedirectResult("ProductMenu");
        }

        public ActionResult FoodMenu() {

            var _db = new ExamEntities();
            var emailforuser = Session["email"].ToString();
            var currentuser = _db.Users.FirstOrDefault(u => u.Email == emailforuser);
            var products = _db.ProductMenuItems.Where(p => p.ProductMenuId == 2).ToList();
            return View(products);
        }

        [HttpGet]
        public ActionResult CreateFoodMenu()
        {
            return View();
        }

        [HttpGet]
        public ActionResult EditFoodMenuItem(int id)
        {
            var _db = new ExamEntities();
            var emailforuser = Session["email"].ToString();
            var currentuser = _db.Users.FirstOrDefault(u => u.Email == emailforuser);
            var producttoedit = _db.ProductMenuItems.Where(p => p.id == id).FirstOrDefault();
            return View(producttoedit);
        }

        [HttpPost]
        public ActionResult UpdateFoodItem(ProductMenuItem productMenuItem)
        {
            var _db = new ExamEntities();
            var producttoupdateid = productMenuItem.id;
            var producttoupdate = _db.ProductMenuItems.FirstOrDefault(p => p.id == producttoupdateid);
            producttoupdate.itemname = productMenuItem.itemname;
            producttoupdate.itemdesc = productMenuItem.itemdesc;
            _db.SaveChanges();
            return new RedirectResult("~/Admin/FoodMenu");
        }

        [HttpGet]
        public ActionResult DeleteFoodMenuItem(int id)
        {
            var _db = new ExamEntities();
            var producttodelete = _db.ProductMenuItems.FirstOrDefault(p => p.id == id);
            //var producttoupdate = _db.ProductMenuItems.FirstOrDefault(p => p.id == producttoupdateid);
            _db.ProductMenuItems.Remove(producttodelete);
            _db.SaveChanges();
            return new RedirectResult("~/Admin/FoodMenu");
        }

        [HttpPost]
        public ActionResult CreateFoodMenu(ProductMenuItem menuitem)
        {
            var _db = new ExamEntities();
            _db.ProductMenuItems.Add(menuitem);
            menuitem.ProductMenuId = 2;
            _db.SaveChanges();
            return new RedirectResult("~/Admin/FoodMenu");
        }

        public ActionResult OrderMenu() {
            var _db = new ExamEntities();
            var emailforuser = Session["email"].ToString();
            var currentuser = _db.Users.FirstOrDefault(u => u.Email == emailforuser);
            var products = _db.ProductMenuItems.Where(p => p.ProductMenuId == 3).ToList();
            return View(products);
        }

        [HttpGet]
        public ActionResult CreateOrderMenu()
        {
            return View();
        }

        [HttpGet]
        public ActionResult EditOrderMenuItem(int id)
        {
            var _db = new ExamEntities();
            var emailforuser = Session["email"].ToString();
            var currentuser = _db.Users.FirstOrDefault(u => u.Email == emailforuser);
            var producttoedit = _db.ProductMenuItems.Where(p => p.id == id).FirstOrDefault();
            return View(producttoedit);
        }

        [HttpPost]
        public ActionResult UpdateOrderItem(ProductMenuItem productMenuItem)
        {
            var _db = new ExamEntities();
            var producttoupdateid = productMenuItem.id;
            var producttoupdate = _db.ProductMenuItems.FirstOrDefault(p => p.id == producttoupdateid);
            producttoupdate.itemname = productMenuItem.itemname;
            producttoupdate.itemdesc = productMenuItem.itemdesc;
            _db.SaveChanges();
            return new RedirectResult("~/Admin/OrderMenu");
        }

        [HttpGet]
        public ActionResult DeleteOrderMenuItem(int id)
        {
            var _db = new ExamEntities();
            var producttodelete = _db.ProductMenuItems.FirstOrDefault(p => p.id == id);
            //var producttoupdate = _db.ProductMenuItems.FirstOrDefault(p => p.id == producttoupdateid);
            _db.ProductMenuItems.Remove(producttodelete);
            _db.SaveChanges();
            return new RedirectResult("~/Admin/FoodMenu");
        }

        [HttpPost]
        public ActionResult CreateOrderMenu(ProductMenuItem menuitem)
        {
            var _db = new ExamEntities();
            _db.ProductMenuItems.Add(menuitem);
            menuitem.ProductMenuId = 3;
            _db.SaveChanges();
            return new RedirectResult("~/Admin/OrderMenu");
        }
        public ActionResult StockMenu() {
            var _db = new ExamEntities();
            var emailforuser = Session["email"].ToString();
            var currentuser = _db.Users.FirstOrDefault(u => u.Email == emailforuser);
            var products = _db.ProductMenuItems.Where(p => p.ProductMenuId == 4).ToList();
            return View(products);
        }

        [HttpGet]
        public ActionResult CreateStockMenu()
        {
            return View();
        }

        [HttpGet]
        public ActionResult EditStockMenuItem(int id)
        {
            var _db = new ExamEntities();
            var emailforuser = Session["email"].ToString();
            var currentuser = _db.Users.FirstOrDefault(u => u.Email == emailforuser);
            var producttoedit = _db.ProductMenuItems.Where(p => p.id == id).FirstOrDefault();
            return View(producttoedit);
        }

        [HttpPost]
        public ActionResult UpdateStockItem(ProductMenuItem productMenuItem)
        {
            var _db = new ExamEntities();
            var producttoupdateid = productMenuItem.id;
            var producttoupdate = _db.ProductMenuItems.FirstOrDefault(p => p.id == producttoupdateid);
            producttoupdate.itemname = productMenuItem.itemname;
            producttoupdate.itemdesc = productMenuItem.itemdesc;
            _db.SaveChanges();
            return new RedirectResult("~/Admin/StockMenu");
        }

        [HttpGet]
        public ActionResult DeleteStockMenuItem(int id)
        {
            var _db = new ExamEntities();
            var producttodelete = _db.ProductMenuItems.FirstOrDefault(p => p.id == id);
            //var producttoupdate = _db.ProductMenuItems.FirstOrDefault(p => p.id == producttoupdateid);
            _db.ProductMenuItems.Remove(producttodelete);
            _db.SaveChanges();
            return new RedirectResult("~/Admin/StockMenu");
        }

        [HttpPost]
        public ActionResult CreateStockMenu(ProductMenuItem menuitem)
        {
            var _db = new ExamEntities();
            _db.ProductMenuItems.Add(menuitem);
            menuitem.ProductMenuId = 4;
            _db.SaveChanges();
            return new RedirectResult("~/Admin/StockMenu");
        }
        public ActionResult Users() {
            var _db = new ExamEntities();
            var GetAllUsers = _db.Users.ToList();
            return View(GetAllUsers);
        }
    }
}