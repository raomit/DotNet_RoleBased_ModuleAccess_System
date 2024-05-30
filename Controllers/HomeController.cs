using MvcExamTaskMitRao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcExamTaskMitRao.Controllers
{
    public class HomeController : Controller
    {
        //public static readonly RaoMitEntities _db;

        //static HomeController()
        //{
        //    HomeController._db = new RaoMitEntities();
        //}

        //[Authorize]
        //public ActionResult Index()
        //{
        //    var UserEmail = HttpContext.Session["email"];
        //    var CurrentUser = _db.Users.FirstOrDefault(u => u.Email == UserEmail);
        //    var rolesForUser = CurrentUser.RolesUsers;
        //    var allStockItems = _db.ProductMenuItems.Where(p => p.id == 1).ToList();

        //    var isAdmin = false;
        //    foreach(var role in rolesForUser)
        //    {
        //        if(role.roleId == 4)
        //        {
        //            isAdmin = true;
        //            return new RedirectResult("~/Admin/index");
        //        }
        //    }
        //    List<String> ProductMenus = new List<String>();
        //    List<ProductMenuItem> productMenuItems = new List<ProductMenuItem>();

        //    foreach (var role in rolesForUser)
        //    {
        //        foreach (var productmenu in role.Role.ProductMenus)
        //        {
        //            foreach(var item in productmenu.ProductMenuItems)
        //            {
        //                productMenuItems.Add(item);
        //            }
        //            ProductMenus.Add(productmenu.menuName.ToString());
        //        }
        //    }
        //    var FinalArray = (CurrentUser, ProductMenus, productMenuItems, allStockItems);
        //    return View(FinalArray);
        //}

        ////public ActionResult AdminDashboard()
        ////{

        ////}
        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}