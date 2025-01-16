using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBEntities
{
    [Table("Mst_Client")]
    public class Mst_Client
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int? Client_Type_Id { get; set; }

        public bool? Is_Active { get; set; }

        public int? Created_By { get; set; }

        public DateTime? Created_Date { get; set; }

        public int? Modified_By { get; set; }

        public DateTime? Modified_Date { get; set; }

        //public DateTime ValidFrom { get; set; }

        //public DateTime ValidTo { get; set; }

        //Navigation Properties
        public Mst_Client_Type Mst_Client_Type { get; set; }
        public ICollection<Mst_Client_Locations> Mst_Client_Locations { get; set; } = new List<Mst_Client_Locations>();
        public ICollection<Trn_Client_Mappings> BuyerClientMappings { get; set; } = new List<Trn_Client_Mappings>();
        public ICollection<Trn_Client_Mappings> SellerClientMappings { get; set; } = new List<Trn_Client_Mappings>();
        public ICollection<Mst_Designation> Designations { get; set; } = new List<Mst_Designation>();
        public ICollection<Mst_User> Mst_User { get; set; } = new List<Mst_User>();
        public ICollection<Mst_Category> Mst_Categories { get; set; } = new List<Mst_Category>();
        public ICollection<Mst_Material_Type> Mst_Material_Types{ get; set; } = new List<Mst_Material_Type>();
        public ICollection<Mst_Products> Mst_Products { get; set; } = new List<Mst_Products>();
        public ICollection<Mst_Pr_Details> Mst_Pr_Details { get; set; } = new List<Mst_Pr_Details>();
        public ICollection<Mst_Payment_Term> Mst_Payment_Terms { get; set; } = new List<Mst_Payment_Term>();
    }
}
