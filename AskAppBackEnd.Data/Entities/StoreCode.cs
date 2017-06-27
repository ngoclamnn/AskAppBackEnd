using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
namespace DiscountCrazyAdmin.Data.Entities
{


    public partial class StoreCode
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? StoreId { get; set; }

        public int? CodeId { get; set; }
        [JsonIgnore]
        public virtual Code Code { get; set; }
        [JsonIgnore]
        public virtual Store Store { get; set; }
    }
}
