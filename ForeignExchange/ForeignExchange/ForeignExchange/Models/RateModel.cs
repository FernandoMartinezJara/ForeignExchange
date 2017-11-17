using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeignExchange.Models
{
   public class RateModel
    {
        public int RateId { get; set; }
        public string Code { get; set; }
        public double TaxRate { get; set; }
        public string Name { get; set; }
    }
}
