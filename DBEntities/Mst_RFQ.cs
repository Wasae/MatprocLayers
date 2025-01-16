using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBEntities
{
    [Table("Mst_RFQ")]
    public class Mst_RFQ
    {
        [Key]
        public int Id { get; set; }

        public int? Delivery_Location_Id { get; set; }

        public bool? Is_Active { get; set; }

        public int? Created_By { get; set; }

        public DateTime? Created_Date { get; set; }

        public int? Modified_By { get; set; }

        public DateTime? Modified_Date { get; set; }

        //public DateTime ValidFrom { get; set; }

        //public DateTime ValidTo { get; set; }

        public string Pr_No { get; set; }
        //Navigation Properties
        public Mst_Client_Locations Mst_Client_Locations { get; set; }
        public ICollection<Trn_RFQ_Details> Trn_RFQ_Details { get; set; } = new List<Trn_RFQ_Details>();
        public ICollection<Trn_RFQ_Quotations> Trn_RFQ_Quotations { get; set; } = new List<Trn_RFQ_Quotations>();
    }
}
