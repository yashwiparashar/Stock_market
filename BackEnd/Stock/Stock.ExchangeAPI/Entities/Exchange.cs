using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stock.ExchangeAPI.Entities
{
    [Table("Exchange")]
    public class Exchange
    {

        [Key]
        
        [Column(TypeName = "int")]
        public int Id { get; set; }
        [StringLength(20)]
        [Required] //set as not null
        public string StockName { get; set; }
        public string ContactAddress { get; set; }
        ///[ForeignKey("Company")]
        //public int CompanyId { get; set; }
       // public Company Company { get; set; }

    }
}
