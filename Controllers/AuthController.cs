using MvcExamTaskMitRao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MvcExamTaskMitRao.CustomFilters;
using System.Data.Entity.Validation;

namespace MvcExamTaskMitRao.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        [HttpGet]
        public ActionResult Login()
        {
            var alreadyloggedinuser = Session["email"];
            if (alreadyloggedinuser != null)
            {
                return new RedirectResult("~/Auth/AccessDenied");
            }
            return View();
        }

        public ActionResult AccessDenied()
        {
            return View();
        }

        [HttpPost]
        public ActionResult login(string Email, string Password)
        {

<<<<<<< HEAD
            using (var _dbcontext = new ExamEntities())
            {
                var check = _dbcontext.Users.FirstOrDefault(user => user.Email == Email && user.Password == Password);

                if (check != null)
                {
                    Session["email"] = Email;
                    FormsAuthentication.SetAuthCookie(Email, false);
                    //return redirect("/home/index");
                    return RedirectToAction("index", "home");
=======
            using (var _dbcontext = new RaoMitEntities())
            {
                var User = _dbcontext.Users.FirstOrDefault(user => user.email == Email && user.password == Password);

                if (User != null)
                {
                    Session["email"] = Email;
                    Session["password"] = Password;
                    FormsAuthentication.SetAuthCookie(Email, false);
                    var IsUserAdmin = false;

                    foreach(var Role in User.RolesUsers)
                    {
                        if(Role.roleId == 1)
                        {
                            IsUserAdmin = true;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }

                    if (IsUserAdmin)
                    {
                        return RedirectToAction("Index", "Admin");
                    }
                    //return redirect("/home/index");
                    return RedirectToAction("Index", "NonAdminUsers");
>>>>>>> 9fd577dc6259ea9bd5308c32a72a08f9358d1f21
                }
                else
                {
                    ViewBag.error = "**email or password is incorrect.";
                    ViewBag.email = Email;
                    ViewBag.password = Password;
                    return View();
                }
            }
        }


        [HttpGet]
        public ActionResult Logout()
        {
            Session.Clear();
            FormsAuthentication.SignOut();
            return Redirect("~/Auth/Login");
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Register(User user)
        {
<<<<<<< HEAD
            using (ExamEntities _dbContext = new ExamEntities())
            {
                var check = _dbContext.Users.FirstOrDefault(User => User.Email == user.Email);
=======
            using (RaoMitEntities _dbContext = new RaoMitEntities())
            {
                var check = _dbContext.Users.FirstOrDefault(User => User.email == user.email);
>>>>>>> 9fd577dc6259ea9bd5308c32a72a08f9358d1f21
                if (check == null)
                {
                    try
                    {
<<<<<<< HEAD
                        user.Type = "customer";
                        _dbContext.Users.Add(user);
                        
                        _dbContext.SaveChanges();
                        _dbContext.RolesUsers.Add(new RolesUser { roleId = 1, userId = user.UserId });

                        _dbContext.SaveChanges();
                        Session["email"] = user.Email;
=======
                        user.type = "customer";
                        _dbContext.Users.Add(user);
                        
                        _dbContext.SaveChanges();
                        _dbContext.RolesUsers.Add(new RolesUser { roleId = 3, userId = user.userId });

                        _dbContext.SaveChanges();
>>>>>>> 9fd577dc6259ea9bd5308c32a72a08f9358d1f21
                        return Redirect("~/Auth/Login");
                    }
                    catch (DbEntityValidationException dbEx)
                    {
                        foreach (var validationerror in dbEx.EntityValidationErrors)
                        {
                            foreach (var error in validationerror.ValidationErrors)
                            {
                                Console.WriteLine(error);
                            }
                        }
                        return View();
                    }
                }
                else
                {
                    ViewBag.error = "Entered email already exixts, LOL!!";
                    return View(user);
                }
            }
        }

        //public static string GetMD5(string str)
        //{
        //    MD5 md5 = new MD5CryptoServiceProvider();
        //    byte[] fromData = Encoding.UTF8.GetBytes(str);
        //    byte[] targetData = md5.ComputeHash(fromData);
        //    string byte2String = null;
        //    for (int i = 0; i < targetData.Length; i++)
        //    {
        //        byte2String += targetData[i].ToString("x2");
        //    }
        //    return byte2String;
        //}
    }
}