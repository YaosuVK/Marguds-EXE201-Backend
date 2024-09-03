using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marguds_BussinessObject.Model
{
    public class Fees
    {
        [Key]
        public Guid FeesID { get; set; }
        public Guid OrderID { get; set; }
        [ForeignKey("OrderID ")]
        public Order? Order { get; set; }

        public double? PaymentFee { get; set; }
        public double FixedFee { get; set; }
        public double TotalFee { get; set; }
    }
}
