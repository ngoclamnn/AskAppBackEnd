namespace AskAppBackEnd.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserLocation : EntityBase
    {
        public Guid? UserId { get; set; }

        public decimal? Longitude { get; set; }

        public decimal? Latitude { get; set; }

        public DateTime? CreationDate { get; set; }

        public DateTime? LastEditDate { get; set; }

        public virtual User User { get; set; }
    }
}
