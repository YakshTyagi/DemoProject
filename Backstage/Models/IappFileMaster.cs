using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class IappFileMaster
    {
        public IappFileMaster()
        {
            IappFileDetails = new HashSet<IappFileDetails>();
        }

        public long MasterFileId { get; set; }
        public long AppId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Type { get; set; }

        public virtual Iapp App { get; set; }
        public virtual ICollection<IappFileDetails> IappFileDetails { get; set; }
    }
}
