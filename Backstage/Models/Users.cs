using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class Users
    {
        public Users()
        {
            AssetAdditionalDetailsCreatedByNavigation = new HashSet<AssetAdditionalDetails>();
            AssetAdditionalDetailsModifiedByNavigation = new HashSet<AssetAdditionalDetails>();
            IappFileDetails = new HashSet<IappFileDetails>();
            Ischedule = new HashSet<Ischedule>();
            ServiceAddtionalDetailsApprovalByNavigation = new HashSet<ServiceAddtionalDetails>();
            ServiceAddtionalDetailsCreatedByNavigation = new HashSet<ServiceAddtionalDetails>();
            ServiceAddtionalDetailsModifiedByNavigation = new HashSet<ServiceAddtionalDetails>();
            SubscriptionDetailsApprovalByNavigation = new HashSet<SubscriptionDetails>();
            SubscriptionDetailsCreatedByNavigation = new HashSet<SubscriptionDetails>();
            SubscriptionDetailsModifiedByNavigation = new HashSet<SubscriptionDetails>();
            UserRoleMapping = new HashSet<UserRoleMapping>();
        }

        public long UserId { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public int OfficeLocationId { get; set; }
        public int DepartmentId { get; set; }
        public bool IsLocked { get; set; }
        public bool IsApproved { get; set; }
        public bool IsAdmin { get; set; }

        public virtual Departments Department { get; set; }
        public virtual OfficeLocations OfficeLocation { get; set; }
        public virtual ICollection<AssetAdditionalDetails> AssetAdditionalDetailsCreatedByNavigation { get; set; }
        public virtual ICollection<AssetAdditionalDetails> AssetAdditionalDetailsModifiedByNavigation { get; set; }
        public virtual ICollection<IappFileDetails> IappFileDetails { get; set; }
        public virtual ICollection<Ischedule> Ischedule { get; set; }
        public virtual ICollection<ServiceAddtionalDetails> ServiceAddtionalDetailsApprovalByNavigation { get; set; }
        public virtual ICollection<ServiceAddtionalDetails> ServiceAddtionalDetailsCreatedByNavigation { get; set; }
        public virtual ICollection<ServiceAddtionalDetails> ServiceAddtionalDetailsModifiedByNavigation { get; set; }
        public virtual ICollection<SubscriptionDetails> SubscriptionDetailsApprovalByNavigation { get; set; }
        public virtual ICollection<SubscriptionDetails> SubscriptionDetailsCreatedByNavigation { get; set; }
        public virtual ICollection<SubscriptionDetails> SubscriptionDetailsModifiedByNavigation { get; set; }
        public virtual ICollection<UserRoleMapping> UserRoleMapping { get; set; }
    }
}
