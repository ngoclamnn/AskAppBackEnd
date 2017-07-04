namespace AskAppBackEnd.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserPreference : EntityBase
    {
        public Guid UserId { get; set; }

        public int? SearchRadius { get; set; }

        [StringLength(50)]
        public string MeasurementUnit { get; set; }

        public bool? AnonymousAnswer { get; set; }

        public bool? AllowAddFriend { get; set; }

        public bool? RegisterNotification { get; set; }

        public bool? FriendRequestNotification { get; set; }

        public bool? QuestionAnsweredNotification { get; set; }

        public bool? FollowQuestionAnsweredNotification { get; set; }

        public DateTime LastEditDate { get; set; }

        public DateTime CreationDate { get; set; }

        public virtual User User { get; set; }
    }
}
