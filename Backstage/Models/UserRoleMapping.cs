using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class UserRoleMapping
    {
        public long Id { get; set; }
        public long Userid { get; set; }
        public int Moduleid { get; set; }

        public virtual BackstageModules Module { get; set; }
        public virtual Users User { get; set; }
    }
}
