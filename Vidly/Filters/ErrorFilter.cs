using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Filters
{
    public class ErrorFilter : Attribute, IExceptionFilter
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public void OnException(ExceptionContext filterContext)
        {
            var ex = filterContext.Exception;
            db.Error.Add(new Error { Exception = ex.Message, Name = ex.Source, Stacktrace = ex.StackTrace, Time = DateTime.Now });
            db.SaveChanges();
        }
    }
}