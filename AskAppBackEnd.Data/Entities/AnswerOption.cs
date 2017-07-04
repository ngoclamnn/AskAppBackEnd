namespace AskAppBackEnd.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AnswerOption : EntityBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AnswerOption()
        {
            UserPollingAnswers = new HashSet<UserPollingAnswer>();
        }

        public Guid QuestionId { get; set; }

        public string OptionText { get; set; }

        [StringLength(1000)]
        public string OptionImage { get; set; }

        public int? DisplayOrder { get; set; }

        public DateTime LastEditDate { get; set; }

        public DateTime CreationDate { get; set; }

        public virtual Question Question { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserPollingAnswer> UserPollingAnswers { get; set; }
    }
}
