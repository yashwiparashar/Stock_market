using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stock.ExchangeAPI.Entities
{
    [Table("Ipo")]
    public class Ipo
    {

        [Key]

        [Column(TypeName = "int")]
        public int Id { get; set; }
        [StringLength(20)]
        [Required] //set as not null
        public string IpoCompanyName { get; set; }
        [Required]
        public int Price { get; set; }


        [Required] //set as not null
        public string StockExchange { get; set; }
        [Required]
        public int TotalShares { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime DateAdded { get; set; }




    }
}
