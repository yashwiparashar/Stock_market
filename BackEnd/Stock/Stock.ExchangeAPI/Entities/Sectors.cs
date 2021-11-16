using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stock.ExchangeAPI.Entities
{
    [Table("Sectors")]
    public class Sectors
    {

        [Key]

        [Column(TypeName = "int")]
        public int SectorId { get; set; }
        [StringLength(20)]
        [Required] //set as not null
        public string SectorName { get; set; }




    }
}
