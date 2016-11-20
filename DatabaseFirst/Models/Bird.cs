using System;
using System.Collections.Generic;

namespace DatabaseFirst
{
    public partial class Bird
    {
        public Bird()
        {
            Dove = new HashSet<Dove>();
        }

        public int BirdId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Dove> Dove { get; set; }
    }
}
