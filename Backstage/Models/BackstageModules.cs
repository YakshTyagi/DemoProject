using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class BackstageModules
    {
        public BackstageModules()
        {
            UserRoleMapping = new HashSet<UserRoleMapping>();
        }

        public int ModuleId { get; set; }
        public string ModuleName { get; set; }
        public string ModuleCode { get; set; }
        public bool IsAdminOnly { get; set; }

        public virtual ICollection<UserRoleMapping> UserRoleMapping { get; set; }
    }
}
