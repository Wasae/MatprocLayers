using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBEntities
{
    [Table("Trn_RFQ_Quotations")]
    public class Trn_RFQ_Quotations
    {
        [Key]
        public int Id { get; set; }

        public int RFQ_ID { get; set; }

        public int RFQ_Detail_Id { get; set; }

        public int Payment_Term_Id { get; set; }

        public int Inco_Term_Id { get; set; }

        public decimal Unit_Price { get; set; }

        public string Remarks { get; set; }

        public bool? Is_Active { get; set; }

        public int? Created_By { get; set; }

        public DateTime? Created_Date { get; set; }

        public int? Modified_By { get; set; }

        public DateTime? Modified_Date { get; set; }

        //public DateTime ValidFrom { get; set; }

        //public DateTime ValidTo { get; set; }

        //Navigation Properties

        public Mst_RFQ Mst_RFQ{ get; set; }
        public Trn_RFQ_Details Trn_RFQ_Details { get; set; }
        public Mst_Payment_Term Mst_Payment_Term { get; set; }
        public Mst_INCO_Term Mst_INCO_Term { get; set; }
    }
}
