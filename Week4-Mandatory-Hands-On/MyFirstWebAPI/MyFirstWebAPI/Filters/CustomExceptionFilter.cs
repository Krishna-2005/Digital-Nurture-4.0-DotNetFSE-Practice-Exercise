using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.IO;

namespace MyFirstWebAPI.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            string log = $"Exception: {context.Exception.Message}\n{context.Exception.StackTrace}";
            File.WriteAllText("error_log.txt", log);

            context.Result = new ObjectResult("Something went wrong") { StatusCode = 500 };
        }
    }
}
