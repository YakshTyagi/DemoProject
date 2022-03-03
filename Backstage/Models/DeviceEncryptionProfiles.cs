using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class DeviceEncryptionProfiles
    {
        public DeviceEncryptionProfiles()
        {
            ServiceEncryptionProfiles = new HashSet<ServiceEncryptionProfiles>();
        }

        public int ProfileId { get; set; }
        public string ProfileName { get; set; }
        public string TranscodeProfileName { get; set; }
        public string DeviceClass { get; set; }
        public string Name { get; set; }
        public bool IsEncrypted { get; set; }
        public string PackagingType { get; set; }
        public bool Enabled { get; set; }

        public virtual ICollection<ServiceEncryptionProfiles> ServiceEncryptionProfiles { get; set; }
    }
}
