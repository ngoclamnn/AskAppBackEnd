namespace DiscountCrazyAdmin.Data.Entities
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Promotion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Promotion()
        {
            CodeUsedHistories = new HashSet<CodeUsedHistory>();
            PromotionCodes = new HashSet<PromotionCode>();
        }

        public int id { get; set; }

        public int store_id { get; set; }

        [Required]
        [StringLength(250)]
        public string name { get; set; }

        [Column(TypeName = "ntext")]
        public string description { get; set; }

        [StringLength(500)]
        public string image { get; set; }

        public DateTime start_date { get; set; }

        public DateTime end_date { get; set; }

        public DateTime created { get; set; }

        [Required]
        [StringLength(50)]
        public string created_by { get; set; }

        public DateTime modified { get; set; }

        [Required]
        [StringLength(50)]
        public string modified_by { get; set; }
        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodeUsedHistory> CodeUsedHistories { get; set; }
        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PromotionCode> PromotionCodes { get; set; }
        [JsonIgnore]
        public virtual Store Store { get; set; }
    }
}
