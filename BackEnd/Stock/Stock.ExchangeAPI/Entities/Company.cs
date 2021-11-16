using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Stock.ExchangeAPI.Entities
{
    [Table("Company")]
    public class Company
    {


        [Key]

        [Column(TypeName = "int")]
        public int CompanyId { get; set; }
        [StringLength(20)]
        [Required] //set as not null
        public string CompanyName { get; set; }
        public int Turnover { get; set; }

        public string CEO { get; set; }
        public string ListedStockExch { get; set; }

        




    }
}
