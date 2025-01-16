using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBEntities
{
    [Table("Mst_User")]
    public class Mst_User
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public int Client_Id { get; set; }

        public int Designation_Id { get; set; }

        public bool? Is_Active { get; set; }

        public int? Created_By { get; set; }

        public DateTime? Created_Date { get; set; }

        public int? Modified_By { get; set; }

        public DateTime? Modified_Date { get; set; }

        //public DateTime ValidFrom { get; set; }

        //public DateTime ValidTo { get; set; }

        public int? Department_Id { get; set; }

        public int? Client_location_Id { get; set; }

        //Navigation Properties
        public Mst_Designation Mst_Designation { get; set; }

        public Mst_Department Mst_Department { get; set; }
        public Mst_Client Mst_Client { get; set; }

        public Mst_Client_Locations Mst_Client_Locations { get; set; }
    }
}
