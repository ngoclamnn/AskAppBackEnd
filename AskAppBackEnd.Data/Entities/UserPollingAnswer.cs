namespace AskAppBackEnd.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserPollingAnswer : EntityBase
    {
        public Guid UserId { get; set; }

        public Guid QuestionId { get; set; }

        public Guid AnswerOptionId { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime LastEditedDate { get; set; }

        public virtual AnswerOption AnswerOption { get; set; }

        public virtual Question Question { get; set; }

        public virtual User User { get; set; }
    }
}
