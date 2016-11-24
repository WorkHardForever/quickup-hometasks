using LoggerAndFilters.Models.GenericResultTime;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Linq;

namespace LoggerAndFilters.CustomFilters.ResultFilter
{
    public class ResponseResultTimeAttribute : Attribute, IResultFilter
    {
        private object[] _result;

        public ResponseResultTimeAttribute(params object[] result)
        {
            _result = result;
        }

        public void OnResultExecuted(ResultExecutedContext context)
        {
            var resultTime = new ResultTime<object>()
            {
                ServerTime = DateTime.Now,
                Result = _result.ToList()
            };

            ResultTimeHelper.SaveResultTimeInDb(resultTime);

            new ObjectResult(resultTime);
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {

        }
    }
}
