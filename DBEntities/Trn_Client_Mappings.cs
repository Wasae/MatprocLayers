using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBEntities
{
    [Table("Trn_Client_Mappings")]
    public class Trn_Client_Mappings
    {
        [Key]
        public int Id { get; set; }

        public int? Buyer_Client_Id { get; set; }

        public int? Seller_Client_Id { get; set; }

        public bool? Is_Active { get; set; }

        public int? Created_By { get; set; }

        public DateTime? Created_Date { get; set; }

        public int? Modified_By { get; set; }

        public DateTime? Modified_Date { get; set; }

        //public DateTime ValidFrom { get; set; }

        //public DateTime ValidTo { get; set; }

        //Navigation Properties
        public Mst_Client BuyerClient { get; set; }
        public Mst_Client SellerClient { get; set; }
    }
}
