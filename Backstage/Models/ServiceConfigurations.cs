using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class ServiceConfigurations
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int MajVersion { get; set; }
        public int MinVersion { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsRemoteRecordAllowed { get; set; }
        public bool IsFreeChannel { get; set; }
        public bool IsHdchannel { get; set; }
        public bool IsOttchannel { get; set; }
        public bool IsCatchUpChannel { get; set; }
        public bool IsEncrypted { get; set; }
        public int DisplayOrder { get; set; }
        public int NumberOfAudio { get; set; }
        public int? DeltaIpId { get; set; }
        public string Provider { get; set; }
        public string UdpmulticastIp { get; set; }
        public int? PlatformId { get; set; }
        public bool IsCloudDvr { get; set; }
        public int? CloudDvrRetentionDuration { get; set; }
        public bool CloudDvrDrmRequired { get; set; }
        public bool UniqueDvrRecordingCopy { get; set; }
        public string CloudDvrCdnPrefix { get; set; }
        public int? AvailablePlatformCloudDvr { get; set; }
        public bool RestartTvAllowed { get; set; }
        public bool IsCableTvChannel { get; set; }
        public int? HlsIndexDuration { get; set; }
        public int? DurationToKeep { get; set; }
        public string BroadcasterFtadashUrl { get; set; }
        public string BroadcasterFtahlsUrl { get; set; }

        public virtual OttPlatforms AvailablePlatformCloudDvrNavigation { get; set; }
        public virtual ElementalDeltaIps DeltaIp { get; set; }
        public virtual OttPlatforms Platform { get; set; }
        public virtual Services Service { get; set; }
    }
}
