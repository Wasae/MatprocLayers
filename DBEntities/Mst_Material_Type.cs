using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBEntities
{
    [Table("Mst_Material_Type")]
    public class Mst_Material_Type
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int? Client_Id { get; set; }

        public bool? Is_Active { get; set; }

        public int? Created_By { get; set; }

        public DateTime? Created_Date { get; set; }

        public int? Modified_By { get; set; }

        public DateTime? Modified_Date { get; set; }

        //public DateTime ValidFrom { get; set; }

        //public DateTime ValidTo { get; set; }

        //Navigation Properties
        public Mst_Client Mst_Client { get; set; }
        public ICollection<Mst_Products> Mst_Products { get; set; } = new List<Mst_Products>();
    }
}
