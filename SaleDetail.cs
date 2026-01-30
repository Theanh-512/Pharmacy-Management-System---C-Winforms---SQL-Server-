namespace LongChauPharmacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SaleDetail
    {
        [Key]
        public int DetailID { get; set; }

        public int SaleID { get; set; }

        [Required]
        [StringLength(50)]
        public string mid { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? Total { get; set; }

        public virtual Sale Sale { get; set; }
    }
}
