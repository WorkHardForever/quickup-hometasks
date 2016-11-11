using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspWithEf
{
    public class MyService
    {
        public string GetTime() => System.DateTime.Now.ToString("hh:mm:ss");
    }
}
