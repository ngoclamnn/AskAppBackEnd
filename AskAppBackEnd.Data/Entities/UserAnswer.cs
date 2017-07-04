namespace AskAppBackEnd.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserAnswer : EntityBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserAnswer()
        {
            UserResponses = new HashSet<UserResponse>();
        }
        public Guid QuestionId { get; set; }

        public Guid? UserAnswerId { get; set; }

        public Guid UserId { get; set; }

        [StringLength(2000)]
        public string AnswerText { get; set; }

        [StringLength(1000)]
        public string AnswerImage { get; set; }

        public int? TotalResponse { get; set; }

        public int? TotalComment { get; set; }

        public DateTime? CreationDate { get; set; }

        public DateTime? LastEditDate { get; set; }

        public virtual Question Question { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserResponse> UserResponses { get; set; }
    }
}
