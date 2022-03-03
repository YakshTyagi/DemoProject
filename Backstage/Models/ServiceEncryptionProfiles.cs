using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class ServiceEncryptionProfiles
    {
        public long Id { get; set; }
        public int ServiceId { get; set; }
        public int ProfileId { get; set; }
        public string EncodeProfileName { get; set; }
        public string EncodeProfileUri { get; set; }

        public virtual DeviceEncryptionProfiles Profile { get; set; }
        public virtual Services Service { get; set; }
    }
}
