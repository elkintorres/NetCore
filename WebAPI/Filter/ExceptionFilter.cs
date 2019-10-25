using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace WebAPI.Filter
{
    public class ExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            if (context.Exception is UnauthorizedAccessException)
            {
                context.HttpContext.Response.StatusCode = 401;
            }
            else
            {
                context.HttpContext.Response.StatusCode = 500;
            }


            base.OnException(context);
        }
    }
}
