using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBEntities
{
    [Table("Trn_RFQ_Details")]
    public class Trn_RFQ_Details
    {
        [Key]
        public int Id { get; set; }

        public int? RFQ_ID { get; set; }

        public int? Product_Id { get; set; }

        public decimal Quanity { get; set; }

        public bool? Is_Active { get; set; }

        public int? Created_By { get; set; }

        public DateTime? Created_Date { get; set; }

        public int? Modified_By { get; set; }

        public DateTime? Modified_Date { get; set; }

        //public DateTime ValidFrom { get; set; }

        //public DateTime ValidTo { get; set; }

        public string Line_Item { get; set; }

        //Navigation Properties

        public Mst_RFQ Mst_RFQ { get; set; }
        public Mst_Products Mst_Products { get; set; }
        public ICollection<Trn_RFQ_Quotations> Trn_RFQ_Quotations { get; set; } = new List<Trn_RFQ_Quotations>();
    }
}
