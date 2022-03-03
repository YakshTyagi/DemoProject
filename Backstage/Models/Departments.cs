using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class Departments
    {
        public Departments()
        {
            Users = new HashSet<Users>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
