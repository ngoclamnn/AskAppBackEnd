namespace AskAppBackEnd.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Questions = new HashSet<Question>();
            UserAnswers = new HashSet<UserAnswer>();
            UserFriends = new HashSet<UserFriend>();
            UserLocations = new HashSet<UserLocation>();
            UserNotifications = new HashSet<UserNotification>();
            UserPollingAnswers = new HashSet<UserPollingAnswer>();
            UserPreferences = new HashSet<UserPreference>();
            UserResponses = new HashSet<UserResponse>();
        }

        public Guid Id { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        [StringLength(200)]
        public string Password { get; set; }

        [StringLength(200)]
        public string Firstname { get; set; }

        [StringLength(200)]
        public string Lastname { get; set; }

        [StringLength(200)]
        public string FacebookAccount { get; set; }

        public DateTime? DOB { get; set; }

        [StringLength(50)]
        public string Gender { get; set; }

        [StringLength(200)]
        public string Nationality { get; set; }

        [StringLength(2000)]
        public string Interests { get; set; }

        public bool IsVisible { get; set; }

        public bool IsNotified { get; set; }

        public bool? DisplayUserProfile { get; set; }

        [StringLength(250)]
        public string AboutMe { get; set; }

        public string ProfilePicture { get; set; }

        [StringLength(200)]
        public string DeviceId { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime LastEditDate { get; set; }

        public DateTime CreationDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Question> Questions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserAnswer> UserAnswers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserFriend> UserFriends { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserLocation> UserLocations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserNotification> UserNotifications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserPollingAnswer> UserPollingAnswers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserPreference> UserPreferences { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserResponse> UserResponses { get; set; }
    }
}
