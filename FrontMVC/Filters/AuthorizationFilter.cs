using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontMVC.Filters
{
    public class AuthorizationFilter : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {

        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            string rol = string.Empty;

            rol = context.HttpContext.Session.GetString("Rol");

            if (string.IsNullOrEmpty(rol) && (!rol.Equals("UserRol") || !rol.Equals("AdminRol")))
            {
                context.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(new { controller = "Login", action = "Login" })
                );
            }
        }
    }
}
