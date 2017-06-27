namespace DiscountCrazyAdmin.Data.Entities
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BusinessCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BusinessCategory()
        {
            Stores = new HashSet<Store>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string category_name { get; set; }

        [Required]
        [StringLength(20)]
        public string category_code { get; set; }

        public string category_description { get; set; }

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
        public virtual ICollection<Store> Stores { get; set; }
    }
}
