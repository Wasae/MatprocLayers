using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBEntities
{
    [Table("Mst_Products")]
    public class Mst_Products
    {
        [Key]
        public int Id { get; set; }

        public string Material_Code { get; set; }

        public string Description { get; set; }

        public int? Category_Id { get; set; }

        public int? Material_Type_Id { get; set; }

        public int? UOM_Id { get; set; }

        public string Pic { get; set; }

        public string Make { get; set; }

        public string Model_Name { get; set; }

        public string Drawing { get; set; }

        public int Client_Id { get; set; }

        public bool? Is_Active { get; set; }

        public int? Created_By { get; set; }

        public DateTime? Created_Date { get; set; }

        public int? Modified_By { get; set; }

        public DateTime? Modified_Date { get; set; }

        //public DateTime ValidFrom { get; set; }

        //public DateTime ValidTo { get; set; }

        //Navigation Properties
        public Mst_Category Mst_Category { get; set; }
        public Mst_Material_Type Mst_Material_Type { get; set; }
        public Mst_UOM Mst_UOM { get; set; }
        public Mst_Client Mst_Client { get; set; }
        public ICollection<Trn_Product_Mappings> BuyerProducts { get; set; } = new List<Trn_Product_Mappings>();
        public ICollection<Trn_Product_Mappings> SellerProducts { get; set; } = new List<Trn_Product_Mappings>();
        public ICollection<Trn_RFQ_Details> Trn_RFQ_Details { get; set; } = new List<Trn_RFQ_Details>();
    }
}
