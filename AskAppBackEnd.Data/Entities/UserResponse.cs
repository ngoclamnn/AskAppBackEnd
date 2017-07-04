namespace AskAppBackEnd.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserResponses")]
    public partial class UserResponse : EntityBase
    {
        public Guid QuestionId { get; set; }

        public Guid? UserAnswerId { get; set; }

        public Guid UserId { get; set; }

        [StringLength(50)]
        public string ResponseType { get; set; }

        public DateTime? CreationDate { get; set; }

        public DateTime? LastEditDate { get; set; }

        public virtual Question Question { get; set; }

        public virtual UserAnswer UserAnswer { get; set; }

        public virtual User User { get; set; }
    }
}
