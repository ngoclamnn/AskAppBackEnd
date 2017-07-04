namespace AskAppBackEnd.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserFriend : EntityBase
    {
        public Guid? UserId { get; set; }

        public Guid? FriendId { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime LastEditDate { get; set; }

        public virtual User User { get; set; }
    }
}
