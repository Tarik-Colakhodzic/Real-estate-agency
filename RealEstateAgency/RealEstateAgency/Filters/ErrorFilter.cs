using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Net;

namespace RealEstateAgency.Filters
{
    public class ErrorFilter : ExceptionFilterAttribute
    {
        private ILoggerFactory _loggerFactory;

        public ErrorFilter(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
        }

        public override void OnException(ExceptionContext context)
        {
            _loggerFactory.CreateLogger(string.Empty).Log(LogLevel.Error, context.Exception, null);

            if (context.Exception is UserException)
            {
                context.ModelState.AddModelError("ERROR", context.Exception.Message);
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
            else
            {
                context.ModelState.AddModelError("ERROR", "Internal server error");
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            }

            var list = context.ModelState.Where(x => x.Value.Errors.Count > 0).ToDictionary(x => x.Key, y => y.Value.Errors.Select(z => z.ErrorMessage));

            context.Result = new JsonResult(list);
        }
    }
}