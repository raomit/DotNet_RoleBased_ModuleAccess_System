using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcExamTaskMitRao.CustomFilters
{
    public class RedirectAuthUserFilter : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(filterContext.HttpContext.Session["email"])))
            {
                filterContext.Result = new RedirectResult("~/Home/index");
                return;
            }
            base.OnActionExecuting(filterContext);
        }
    }
}