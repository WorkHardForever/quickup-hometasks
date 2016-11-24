using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace LoggerAndFilters.cs.Filters
{
    public class CustomResultFilterAttribute : Attribute, IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext context)
        {

        }

        public void OnResultExecuting(ResultExecutingContext context)
        {

        }
    }
}
