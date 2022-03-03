using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class MetadataContentTypes
    {
        public MetadataContentTypes()
        {
            SubPolicyContentCrossref = new HashSet<SubPolicyContentCrossref>();
        }

        public int Id { get; set; }
        public string ContentType { get; set; }
        public string ContentCode { get; set; }

        public virtual ICollection<SubPolicyContentCrossref> SubPolicyContentCrossref { get; set; }
    }
}
