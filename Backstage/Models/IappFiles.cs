using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class IappFiles
    {
        public long FileId { get; set; }
        public byte[] FileData { get; set; }

        public virtual IappFileDetails File { get; set; }
    }
}
