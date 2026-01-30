// @author NguyenHoTheAnh - 2380614489 - 23DTHE5
using LongChauPharmacy;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PharmacyDB.Models
{
    [Table("InfoMedic")]
    public class InfoMedic
    {
        [Key]
        public int InfoId { get; set; }

        [ForeignKey("Medic")]
        public int MedicId { get; set; }

        public string ChiDinh { get; set; }
        public string ChongChiDinh { get; set; }
        public string HinhAnh { get; set; }

        public virtual Medic Medic { get; set; }
    }
}
