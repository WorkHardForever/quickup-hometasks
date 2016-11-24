using System;
using System.Collections.Generic;

namespace LoggerAndFilters.Models.GenericResultTime
{
    public class ResultTime<T>
    {
        public DateTime ServerTime { get; set; }
        public List<T> Result { get; set; }
    }
}
