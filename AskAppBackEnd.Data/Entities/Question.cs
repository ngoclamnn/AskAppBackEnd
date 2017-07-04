namespace AskAppBackEnd.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Question : EntityBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Question()
        {
            AnswerOptions = new HashSet<AnswerOption>();
            QuestionMedias = new HashSet<QuestionMedia>();
            UserAnswers = new HashSet<UserAnswer>();
            UserResponses = new HashSet<UserResponse>();
            UserPollingAnswers = new HashSet<UserPollingAnswer>();
        }

        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        [StringLength(500)]
        public string AskedLocation { get; set; }

        [StringLength(255)]
        public string AskedGroup { get; set; }

        [StringLength(50)]
        public string QuestionType { get; set; }

        public string QuestionText { get; set; }

        public int? TotalResponse { get; set; }

        public int? TotalAnswer { get; set; }

        public bool? PrivateQuestion { get; set; }

        public DateTime LastEditDate { get; set; }

        public DateTime CreationDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AnswerOption> AnswerOptions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuestionMedia> QuestionMedias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserAnswer> UserAnswers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserResponse> UserResponses { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserPollingAnswer> UserPollingAnswers { get; set; }
    }
}
