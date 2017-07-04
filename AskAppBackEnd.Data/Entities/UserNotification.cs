namespace AskAppBackEnd.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserNotification : EntityBase
    {
        public Guid UserId { get; set; }

        public Guid ToUserId { get; set; }

        [Required]
        [StringLength(50)]
        public string EntityType { get; set; }

        public Guid EntityId { get; set; }

        [StringLength(500)]
        public string Content { get; set; }

        public bool IsRead { get; set; }

        public DateTime LastEditDate { get; set; }

        public DateTime CreationDate { get; set; }

        public virtual User User { get; set; }
    }
}
