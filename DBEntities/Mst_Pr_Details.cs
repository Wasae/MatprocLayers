using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBEntities
{
    [Table("Mst_Pr_Details")]
    public class Mst_Pr_Details
    {
        [Key]
        public int ID { get; set; }

        public string Pr_No { get; set; }

        public string Line_Item { get; set; }

        public DateTime ERP_Date { get; set; }

        public TimeSpan? ERP_Time { get; set; }

        public string ERP_User_Name { get; set; }

        public string ERP_Department { get; set; }

        public string ERP_Material_Code { get; set; }

        public string ERP_Material_Desc { get; set; }

        public decimal ERP_Material_Quanitity { get; set; }

        public int? Created_By { get; set; }

        public DateTime? Created_Date { get; set; }

        public int? Modified_By { get; set; }

        public DateTime? Modified_Date { get; set; }

        public bool? Is_Active { get; set; }

        public int? Client_Id { get; set; }

        public string ERP_UOM { get; set; }

        //Navigation Properties
        public Mst_Client Mst_Client { get; set; }
    }
}
