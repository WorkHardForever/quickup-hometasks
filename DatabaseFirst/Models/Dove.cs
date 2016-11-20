using System;
using System.Collections.Generic;

namespace DatabaseFirst
{
    public partial class Dove
    {
        public int DoveId { get; set; }
        public int BirdId { get; set; }
        public string Name { get; set; }

        public virtual Bird Bird { get; set; }
    }
}
