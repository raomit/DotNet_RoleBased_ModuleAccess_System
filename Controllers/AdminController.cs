using MvcExamTaskMitRao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
<<<<<<< HEAD

namespace MvcExamTaskMitRao.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        // GET: Admin
=======
using MvcExamTaskMitRao.CustomFilters;
using System.Data.Entity.Migrations;
using MvcExamTaskMitRao.Models.CustomModels;

namespace MvcExamTaskMitRao.Controllers
{
    [Authorize]
    [AdminOnlyAccessFilter]
    public class AdminController : Controller
    {
        //public static readonly RaoMitEntities _db;

        //static AdminController()
        //{
        //    AdminController._db = new RaoMitEntities();
        //}

        // GET: Admin Home Page
        [HttpGet]
>>>>>>> 9fd577dc6259ea9bd5308c32a72a08f9358d1f21
        public ActionResult Index()
        {
            return View();
        }

<<<<<<< HEAD
        public ActionResult ProductMenu() {
            var _db = new ExamEntities();
            var emailforuser = Session["email"].ToString();
            var currentuser = _db.Users.FirstOrDefault(u => u.Email == emailforuser);
            var products = _db.ProductMenuItems.Where(p => p.ProductMenuId == 1).ToList();
            return View(products);
        }

        [HttpGet]
        public ActionResult CreateProductMenu()
=======
        [HttpGet]
        public ActionResult GetManageMenus()
        {
            var _db = new RaoMitEntities();
            var AllMenus = _db.Menus.ToList();
            return View(AllMenus);
        }

        [HttpGet]
        public ActionResult GetManageUsers()
        {
            var _db = new RaoMitEntities();
            var AllUsers = _db.Users.ToList();
            var AllRoles = _db.Roles.ToList();
            var ModelData = (AllUsers, AllRoles);
            return View(ModelData);
        }

        [HttpGet]
        public ActionResult GetManageRoles()
        {
            var _db = new RaoMitEntities();
            var AllRoles = _db.Roles.ToList();
            var AllMenus = _db.Menus.ToList();
            var ModelData = (AllRoles, AllMenus);
            return View(ModelData);
        }

        [HttpGet]
        public ActionResult CreateNewMenu()
>>>>>>> 9fd577dc6259ea9bd5308c32a72a08f9358d1f21
        {
            return View();
        }

<<<<<<< HEAD
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
=======
        [HttpPost]
        public ActionResult CreateNewMenu(Menu NewMenu)
        {
            var _db = new RaoMitEntities();
            _db.Menus.Add(NewMenu);
            _db.SaveChanges();
            return RedirectToAction("GetManageMenus");
        }

        [HttpGet]
        public ActionResult CreateNewUser()
>>>>>>> 9fd577dc6259ea9bd5308c32a72a08f9358d1f21
        {
            return View();
        }

<<<<<<< HEAD
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
=======
        [HttpPost]
        public ActionResult CreateNewUser(User NewUser)
        {
            var _db = new RaoMitEntities();
            _db.Users.Add(NewUser);
            NewUser.type = "customer";
            _db.SaveChanges();
            _db.RolesUsers.Add(new RolesUser
            {
                roleId = 3,
                userId = NewUser.userId
            });
            _db.SaveChanges();
            return RedirectToAction("GetManageUsers");
        }

        [HttpGet]
        public ActionResult CreateNewRole()
>>>>>>> 9fd577dc6259ea9bd5308c32a72a08f9358d1f21
        {
            return View();
        }

<<<<<<< HEAD
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
=======
        [HttpPost]
        public ActionResult CreateNewRole(MvcExamTaskMitRao.Models.Role NewRole)
        {
            var _db = new RaoMitEntities();
            _db.Roles.Add(NewRole);
            _db.SaveChanges();
            return RedirectToAction("GetManageRoles");
        }

        [HttpGet]
        public ActionResult UpdateMenu(int id)
        {
            var _db = new RaoMitEntities();
            var MenuToUpdate = _db.Menus.FirstOrDefault(menu => menu.menuId == id);
            return View(MenuToUpdate);
        }

        [HttpPost]
        public ActionResult UpdateMenu(Menu UpdatedMenu)
        {
            var _db = new RaoMitEntities();
            var MenuToUpdate = _db.Menus.FirstOrDefault(menu => menu.menuId == UpdatedMenu.menuId);
            MenuToUpdate.menuType = UpdatedMenu.menuType;
            _db.SaveChanges();
            return RedirectToAction("GetManageMenus");
        }

        [HttpGet]
        public ActionResult UpdateUser(int id)
        {
            var _db = new RaoMitEntities();
            var UseToUpdate = _db.Users.FirstOrDefault(user => user.userId == id);
            return View(UseToUpdate);
        }

        [HttpPost]
        public ActionResult UpdateUser(User UpdatedUser)
        {
            var _db = new RaoMitEntities();
            var email = Session["email"].ToString();
            var password = Session["password"].ToString(); 
            if (email == UpdatedUser.email || password == UpdatedUser.password)
            {
                Session.Clear();
                HttpContext.Session["email"] = UpdatedUser.email;
            }
            _db.Users.AddOrUpdate(UpdatedUser);
            _db.SaveChanges();
            return RedirectToAction("GetManageUsers");
        }

        [HttpPost]
        public ActionResult UpdateUserRoles(List<MvcExamTaskMitRao.Models.CustomModels.UpdateRole> UpdateRoles)
        {
            var _db = new RaoMitEntities();
            var CurrentUserMail = Session["email"].ToString();
            var CurrentUser = _db.Users.FirstOrDefault(u => u.email == CurrentUserMail);
            CurrentUser.type = "admin";
            _db.SaveChanges();
            var RoleUpdateUserId = UpdateRoles[0].userId;
            var RolesToDelete = _db.RolesUsers.Where(ru => ru.userId == RoleUpdateUserId).ToList();
            _db.RolesUsers.RemoveRange(RolesToDelete);
            _db.SaveChanges();
            foreach(var Role in UpdateRoles)
            {
                if(Role.roleId == 1)
                {
                    CurrentUser.type = "admin";
                }
                _db.RolesUsers.Add(new RolesUser
                {
                    userId = Role.userId,
                    roleId = Role.roleId,
                });
                _db.SaveChanges();
            }
            return RedirectToAction("GetManageUsers");
        }

        [HttpGet]
        public ActionResult UpdateUserRolesDeleteRoles(int id)
        {
            var _db = new RaoMitEntities();
            var RolesToDelete = _db.RolesUsers.Where(ru => ru.userId == id).ToList();
            var CurrentUserMail = Session["email"].ToString();
            var CurrentUser = _db.Users.FirstOrDefault(u => u.email == CurrentUserMail);
            CurrentUser.type = "null";
            _db.SaveChanges();
            if (RolesToDelete.Count > 0)
            {
                _db.RolesUsers.RemoveRange(RolesToDelete);
                _db.SaveChanges();
                return RedirectToAction("GetManageRoles");
            }
                return RedirectToAction("GetManageRoles");
        }

        [HttpPost]
        public ActionResult UpdateRolesAccess(List<MvcExamTaskMitRao.Models.CustomModels.UpdateRoleAccess> UpdatedRoleAccess)
        {
            var _db = new RaoMitEntities();
            var RoleUpdateId = UpdatedRoleAccess[0].roleId;
            var RolesToDelete = _db.RolesMenus.Where(rm => rm.roleId == RoleUpdateId).ToList();
            foreach(var DeleteRole in RolesToDelete)
            {
                _db.RolesMenus.Remove(DeleteRole);
                _db.SaveChanges();
            }
            foreach (var RoleMenu in UpdatedRoleAccess)
            {
                _db.RolesMenus.Add(new RolesMenu
                {
                    menuId = RoleMenu.menuId,
                    roleId = RoleMenu.roleId
                });
                _db.SaveChanges();
            }
            return RedirectToAction("GetManageRoles");
        }

        [HttpGet]
        public ActionResult UpdateRolesAccessDeleteAccess(int id)
        {
            var _db = new RaoMitEntities();
            var RolesToDelete = _db.RolesMenus.Where(rm => rm.roleId == id).ToList();
            if(RolesToDelete.Count > 0)
            {
                _db.RolesMenus.RemoveRange(RolesToDelete);
                _db.SaveChanges();
                return RedirectToAction("GetManageRoles");
            }
            return RedirectToAction("GetManageRoles");

        }

        [HttpGet]
        public ActionResult UpdateRole(int id)
        {
            var _db = new RaoMitEntities();
            var RoleToUpdate = _db.Roles.FirstOrDefault(role => role.roleId == id);
            return View(RoleToUpdate);
        }

        [HttpPost]
        public ActionResult UpdateRole(MvcExamTaskMitRao.Models.Role UpdatedRole)
        {
            var _db = new RaoMitEntities();
            _db.Roles.AddOrUpdate(UpdatedRole);
            _db.SaveChanges();
            return RedirectToAction("GetManageRoles");
        }

        [HttpGet]
        public ActionResult DeleteMenu(int id)
        {
            var _db = new RaoMitEntities();
            _db.Menus.Remove(_db.Menus.FirstOrDefault(menu => menu.menuId == id));
            _db.SaveChanges();
            return RedirectToAction("GetManageMenus");
        }

        [HttpGet]
        public ActionResult DeleteUser(int id) {
            var _db = new RaoMitEntities();
            _db.Users.Remove(_db.Users.FirstOrDefault(user => user.userId == id));
            _db.SaveChanges();
            return RedirectToAction("GetManageUsers");
        }

        [HttpGet]
        public ActionResult DeleteRole(int id)
        {
            var _db = new RaoMitEntities();
            _db.Roles.Remove(_db.Roles.FirstOrDefault(role => role.roleId == id));
            _db.SaveChanges();
            return RedirectToAction("GetManageRoles");
        }



        //public ActionResult ProductMenu() {
        //    var _db = new ExamEntities();
        //    var emailforuser = Session["email"].ToString();
        //    var currentuser = _db.Users.FirstOrDefault(u => u.Email == emailforuser);
        //    var products = _db.ProductMenuItems.Where(p => p.ProductMenuId == 1).ToList();
        //    return View(products);
        //}

        //[HttpGet]
        //public ActionResult CreateProductMenu()
        //{
        //    return View();
        //}

        //[HttpGet]
        //public ActionResult EditProductMenuItem(int id)
        //{
        //    var _db = new ExamEntities();
        //    var emailforuser = Session["email"].ToString();
        //    var currentuser = _db.Users.FirstOrDefault(u => u.Email == emailforuser);
        //    var producttoedit = _db.ProductMenuItems.Where(p => p.id == id).FirstOrDefault();
        //    return View(producttoedit);
        //}

        //[HttpPost]
        //public ActionResult UpdateProductItem(ProductMenuItem productMenuItem)
        //{
        //    var _db = new ExamEntities();
        //    var producttoupdateid = productMenuItem.id;
        //    var producttoupdate = _db.ProductMenuItems.FirstOrDefault(p => p.id == producttoupdateid);
        //    producttoupdate.itemname = productMenuItem.itemname;
        //    producttoupdate.itemdesc = productMenuItem.itemdesc;
        //    _db.SaveChanges();
        //    return new RedirectResult("ProductMenu");
        //}

        //[HttpGet]
        //public ActionResult DeleteProductMenuItem(int id)
        //{
        //    var _db = new ExamEntities();
        //    var producttodelete = _db.ProductMenuItems.FirstOrDefault(p => p.id == id);
        //    //var producttoupdate = _db.ProductMenuItems.FirstOrDefault(p => p.id == producttoupdateid);
        //    _db.ProductMenuItems.Remove(producttodelete);
        //    _db.SaveChanges();
        //    return new RedirectResult("~/Admin/ProductMenu");
        //}

        //[HttpPost]
        //public ActionResult CreateProductMenu(ProductMenuItem menuitem)
        //{
        //    var _db = new ExamEntities();
        //    _db.ProductMenuItems.Add(menuitem);
        //    menuitem.ProductMenuId = 1;
        //    _db.SaveChanges();
        //    return new RedirectResult("ProductMenu");
        //}

        //public ActionResult FoodMenu() {

        //    var _db = new ExamEntities();
        //    var emailforuser = Session["email"].ToString();
        //    var currentuser = _db.Users.FirstOrDefault(u => u.Email == emailforuser);
        //    var products = _db.ProductMenuItems.Where(p => p.ProductMenuId == 2).ToList();
        //    return View(products);
        //}

        //[HttpGet]
        //public ActionResult CreateFoodMenu()
        //{
        //    return View();
        //}

        //[HttpGet]
        //public ActionResult EditFoodMenuItem(int id)
        //{
        //    var _db = new ExamEntities();
        //    var emailforuser = Session["email"].ToString();
        //    var currentuser = _db.Users.FirstOrDefault(u => u.Email == emailforuser);
        //    var producttoedit = _db.ProductMenuItems.Where(p => p.id == id).FirstOrDefault();
        //    return View(producttoedit);
        //}

        //[HttpPost]
        //public ActionResult UpdateFoodItem(ProductMenuItem productMenuItem)
        //{
        //    var _db = new ExamEntities();
        //    var producttoupdateid = productMenuItem.id;
        //    var producttoupdate = _db.ProductMenuItems.FirstOrDefault(p => p.id == producttoupdateid);
        //    producttoupdate.itemname = productMenuItem.itemname;
        //    producttoupdate.itemdesc = productMenuItem.itemdesc;
        //    _db.SaveChanges();
        //    return new RedirectResult("~/Admin/FoodMenu");
        //}

        //[HttpGet]
        //public ActionResult DeleteFoodMenuItem(int id)
        //{
        //    var _db = new ExamEntities();
        //    var producttodelete = _db.ProductMenuItems.FirstOrDefault(p => p.id == id);
        //    //var producttoupdate = _db.ProductMenuItems.FirstOrDefault(p => p.id == producttoupdateid);
        //    _db.ProductMenuItems.Remove(producttodelete);
        //    _db.SaveChanges();
        //    return new RedirectResult("~/Admin/FoodMenu");
        //}

        //[HttpPost]
        //public ActionResult CreateFoodMenu(ProductMenuItem menuitem)
        //{
        //    var _db = new ExamEntities();
        //    _db.ProductMenuItems.Add(menuitem);
        //    menuitem.ProductMenuId = 2;
        //    _db.SaveChanges();
        //    return new RedirectResult("~/Admin/FoodMenu");
        //}

        //public ActionResult OrderMenu() {
        //    var _db = new ExamEntities();
        //    var emailforuser = Session["email"].ToString();
        //    var currentuser = _db.Users.FirstOrDefault(u => u.Email == emailforuser);
        //    var products = _db.ProductMenuItems.Where(p => p.ProductMenuId == 3).ToList();
        //    return View(products);
        //}

        //[HttpGet]
        //public ActionResult CreateOrderMenu()
        //{
        //    return View();
        //}

        //[HttpGet]
        //public ActionResult EditOrderMenuItem(int id)
        //{
        //    var _db = new ExamEntities();
        //    var emailforuser = Session["email"].ToString();
        //    var currentuser = _db.Users.FirstOrDefault(u => u.Email == emailforuser);
        //    var producttoedit = _db.ProductMenuItems.Where(p => p.id == id).FirstOrDefault();
        //    return View(producttoedit);
        //}

        //[HttpPost]
        //public ActionResult UpdateOrderItem(ProductMenuItem productMenuItem)
        //{
        //    var _db = new ExamEntities();
        //    var producttoupdateid = productMenuItem.id;
        //    var producttoupdate = _db.ProductMenuItems.FirstOrDefault(p => p.id == producttoupdateid);
        //    producttoupdate.itemname = productMenuItem.itemname;
        //    producttoupdate.itemdesc = productMenuItem.itemdesc;
        //    _db.SaveChanges();
        //    return new RedirectResult("~/Admin/OrderMenu");
        //}

        //[HttpGet]
        //public ActionResult DeleteOrderMenuItem(int id)
        //{
        //    var _db = new ExamEntities();
        //    var producttodelete = _db.ProductMenuItems.FirstOrDefault(p => p.id == id);
        //    //var producttoupdate = _db.ProductMenuItems.FirstOrDefault(p => p.id == producttoupdateid);
        //    _db.ProductMenuItems.Remove(producttodelete);
        //    _db.SaveChanges();
        //    return new RedirectResult("~/Admin/FoodMenu");
        //}

        //[HttpPost]
        //public ActionResult CreateOrderMenu(ProductMenuItem menuitem)
        //{
        //    var _db = new ExamEntities();
        //    _db.ProductMenuItems.Add(menuitem);
        //    menuitem.ProductMenuId = 3;
        //    _db.SaveChanges();
        //    return new RedirectResult("~/Admin/OrderMenu");
        //}
        //public ActionResult StockMenu() {
        //    var _db = new ExamEntities();
        //    var emailforuser = Session["email"].ToString();
        //    var currentuser = _db.Users.FirstOrDefault(u => u.Email == emailforuser);
        //    var products = _db.ProductMenuItems.Where(p => p.ProductMenuId == 4).ToList();
        //    return View(products);
        //}

        //[HttpGet]
        //public ActionResult CreateStockMenu()
        //{
        //    return View();
        //}

        //[HttpGet]
        //public ActionResult EditStockMenuItem(int id)
        //{
        //    var _db = new ExamEntities();
        //    var emailforuser = Session["email"].ToString();
        //    var currentuser = _db.Users.FirstOrDefault(u => u.Email == emailforuser);
        //    var producttoedit = _db.ProductMenuItems.Where(p => p.id == id).FirstOrDefault();
        //    return View(producttoedit);
        //}

        //[HttpPost]
        //public ActionResult UpdateStockItem(ProductMenuItem productMenuItem)
        //{
        //    var _db = new ExamEntities();
        //    var producttoupdateid = productMenuItem.id;
        //    var producttoupdate = _db.ProductMenuItems.FirstOrDefault(p => p.id == producttoupdateid);
        //    producttoupdate.itemname = productMenuItem.itemname;
        //    producttoupdate.itemdesc = productMenuItem.itemdesc;
        //    _db.SaveChanges();
        //    return new RedirectResult("~/Admin/StockMenu");
        //}

        //[HttpGet]
        //public ActionResult DeleteStockMenuItem(int id)
        //{
        //    var _db = new ExamEntities();
        //    var producttodelete = _db.ProductMenuItems.FirstOrDefault(p => p.id == id);
        //    //var producttoupdate = _db.ProductMenuItems.FirstOrDefault(p => p.id == producttoupdateid);
        //    _db.ProductMenuItems.Remove(producttodelete);
        //    _db.SaveChanges();
        //    return new RedirectResult("~/Admin/StockMenu");
        //}

        //[HttpPost]
        //public ActionResult CreateStockMenu(ProductMenuItem menuitem)
        //{
        //    var _db = new ExamEntities();
        //    _db.ProductMenuItems.Add(menuitem);
        //    menuitem.ProductMenuId = 4;
        //    _db.SaveChanges();
        //    return new RedirectResult("~/Admin/StockMenu");
        //}
        //public ActionResult Users() {
        //    var _db = new ExamEntities();
        //    var GetAllUsers = _db.Users.ToList();
        //    return View(GetAllUsers);
        //}
>>>>>>> 9fd577dc6259ea9bd5308c32a72a08f9358d1f21
    }
}