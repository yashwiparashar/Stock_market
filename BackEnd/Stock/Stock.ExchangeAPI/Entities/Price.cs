using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Stock.ExchangeAPI.Entities
{
    [Table("Price")]
    public class Price
    {

        [Key]

        [Column(TypeName = "int")]
        public int PriceId { get; set; }

        [Required] //set as not null
        public double Pricestock { get; set; }
        
        public string CompanyCode { get; set; }

        public string StockExchange { get; set; }


        [Column(TypeName = "datetime2")]
        public DateTime DateAdded { get; set; }
    }
}
