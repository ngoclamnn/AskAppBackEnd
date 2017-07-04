namespace AskAppBackEnd.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class QuestionMedia : EntityBase
    {
        public Guid QuestionId { get; set; }

        [Required]
        [StringLength(255)]
        public string MediaContent { get; set; }

        [Required]
        [StringLength(50)]
        public string MediaType { get; set; }

        public DateTime CreationDation { get; set; }

        public DateTime LastEditDate { get; set; }

        public virtual Question Question { get; set; }
    }
}
