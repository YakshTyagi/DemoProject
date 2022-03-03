using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class OfficeLocations
    {
        public OfficeLocations()
        {
            Users = new HashSet<Users>();
        }

        public int OfficeId { get; set; }
        public string OfficeLocation { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
