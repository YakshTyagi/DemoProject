using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class ServiceLanguages
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int LanguageId { get; set; }

        public virtual Languages Language { get; set; }
        public virtual Services Service { get; set; }
    }
}
