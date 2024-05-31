using MvcExamTaskMitRao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MvcExamTaskMitRao.Controllers
{
    [Authorize(Roles ="customer, cook, cashier")]
    public class NonAdminUsersController : Controller
    {
        public ActionResult GetOrders() {
            var _db = new ExamEntities();
            var UserEmail = HttpContext.Session["email"];
            var CurrentUser = _db.Users.FirstOrDefault(u => u.Email == UserEmail);
            var rolesForUser = CurrentUser.RolesUsers;
            var allStockItems = _db.ProductMenuItems.Where(p => p.ProductMenuId == 3).ToList();

            var isAdmin = false;
            foreach (var role in rolesForUser)
            {
                if (role.roleId == 4)
                {
                    isAdmin = true;
                    return new RedirectResult("~/Admin/index");
                }
            }
            List<String> ProductMenus = new List<String>();
            List<ProductMenuItem> productMenuItems = new List<ProductMenuItem>();

            foreach (var role in rolesForUser)
            {
                foreach (var productmenu in role.Role.ProductMenus)
                {
                    foreach (var item in productmenu.ProductMenuItems)
                    {
                        productMenuItems.Add(item);
                    }
                    ProductMenus.Add(productmenu.menuName.ToString());
                }
            }
            var FinalArray = (CurrentUser, ProductMenus, productMenuItems, allStockItems);
            return View(FinalArray);
        }



        public ActionResult GetStocks() {
            var _db = new ExamEntities();
            var UserEmail = HttpContext.Session["email"];
            var CurrentUser = _db.Users.FirstOrDefault(u => u.Email == UserEmail);
            var rolesForUser = CurrentUser.RolesUsers;
            var allStockItems = _db.ProductMenuItems.Where(p => p.ProductMenuId == 4).ToList();

            var isAdmin = false;
            foreach (var role in rolesForUser)
            {
                if (role.roleId == 4)
                {
                    isAdmin = true;
                    return new RedirectResult("~/Admin/index");
                }
            }
            List<String> ProductMenus = new List<String>();
            List<ProductMenuItem> productMenuItems = new List<ProductMenuItem>();

            foreach (var role in rolesForUser)
            {
                foreach (var productmenu in role.Role.ProductMenus)
                {
                    foreach (var item in productmenu.ProductMenuItems)
                    {
                        productMenuItems.Add(item);
                    }
                    ProductMenus.Add(productmenu.menuName.ToString());
                }
            }
            var FinalArray = (CurrentUser, ProductMenus, productMenuItems, allStockItems);
            return View(FinalArray);}


        public ActionResult GetFoods() {
            var _db = new ExamEntities();
            var UserEmail = HttpContext.Session["email"];
            var CurrentUser = _db.Users.FirstOrDefault(u => u.Email == UserEmail);
            var rolesForUser = CurrentUser.RolesUsers;
            var allStockItems = _db.ProductMenuItems.Where(p => p.ProductMenuId == 2).ToList();

            var isAdmin = false;
            foreach (var role in rolesForUser)
            {
                if (role.roleId == 4)
                {
                    isAdmin = true;
                    return new RedirectResult("~/Admin/index");
                }
            }
            List<String> ProductMenus = new List<String>();
            List<ProductMenuItem> productMenuItems = new List<ProductMenuItem>();

            foreach (var role in rolesForUser)
            {
                foreach (var productmenu in role.Role.ProductMenus)
                {
                    foreach (var item in productmenu.ProductMenuItems)
                    {
                        productMenuItems.Add(item);
                    }
                    ProductMenus.Add(productmenu.menuName.ToString());
                }
            }
            var FinalArray = (CurrentUser, ProductMenus, productMenuItems, allStockItems);
            return View(FinalArray);
        }
        
    }
}