namespace LongChauPharmacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sale
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sale()
        {
            SaleDetails = new HashSet<SaleDetail>();
        }

        public int SaleID { get; set; }

        public DateTime? SaleDate { get; set; }

        public int UserID { get; set; }

        public int? CustomerID { get; set; }

        public decimal? TotalAmount { get; set; }

        public virtual Customer Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleDetail> SaleDetails { get; set; }

        public virtual User User { get; set; }
    }
}
