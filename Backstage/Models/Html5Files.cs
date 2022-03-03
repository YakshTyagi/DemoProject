using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class Html5Files
    {
        public long FileId { get; set; }
        public byte[] FileData { get; set; }

        public virtual Html5FileDetails File { get; set; }
    }
}
