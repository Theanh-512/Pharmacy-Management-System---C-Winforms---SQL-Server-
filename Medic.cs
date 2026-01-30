namespace LongChauPharmacy
{
    using PharmacyDB.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Medic")]
    public partial class Medic
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string mid { get; set; }

        [Required]
        [StringLength(200)]
        public string mname { get; set; }

        [StringLength(50)]
        public string unit { get; set; }

        [StringLength(50)]
        public string mnumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime? mDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? eDate { get; set; }

        public int stock { get; set; }

        public decimal salePrice { get; set; }

        public virtual ICollection<InfoMedic> InfoMedics { get; set; }
    }
}
