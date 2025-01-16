using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBEntities
{
    [Table("Mst_Client_Locations")]
    public class Mst_Client_Locations
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string Address3 { get; set; }

        public int? Country_Id { get; set; }

        public int? State_Id { get; set; }

        public int? City_Id { get; set; }

        public int Client_Id { get; set; }

        public bool? Is_Active { get; set; }

        public int? Created_By { get; set; }

        public DateTime? Created_Date { get; set; }

        public int? Modified_By { get; set; }

        public DateTime? Modified_Date { get; set; }

        //public DateTime ValidFrom { get; set; }

        //public DateTime ValidTo { get; set; }

        //Navigation Properties
        public Mst_Client Mst_Client { get; set; }
        public Mst_Country Mst_Country { get; set; }

        public Mst_State Mst_State { get; set; }

        public Mst_City Mst_City { get; set; }
        public ICollection<Mst_User> Mst_User { get; set; } = new List<Mst_User>();
        public ICollection<Mst_RFQ> Mst_RFQs { get; set; } = new List<Mst_RFQ>();
    }
}
