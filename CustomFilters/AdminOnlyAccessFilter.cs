using MvcExamTaskMitRao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcExamTaskMitRao.CustomFilters
{
    public class AdminOnlyAccessFilter : ActionFilterAttribute, IAuthorizationFilter
    {
        void IAuthorizationFilter.OnAuthorization(AuthorizationContext filterContext)
        {
            if (string.IsNullOrEmpty(Convert.ToString(filterContext.HttpContext.Session["email"])))
            {
                filterContext.Result = new HttpUnauthorizedResult();
                return;
            }
            else
            {
                using(var _db = new RaoMitEntities())
                {
                    var UserEmail = filterContext.HttpContext.Session["email"].ToString();
                    var User = _db.Users.FirstOrDefault(user => user.email == UserEmail);
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

                    if(IsUserAdmin)
                    {
                        return;
                    }
                    else
                    {
                        filterContext.Result = new RedirectResult("~/Auth/AccessDenied");
                    }
                }
            }
        }
    }
}