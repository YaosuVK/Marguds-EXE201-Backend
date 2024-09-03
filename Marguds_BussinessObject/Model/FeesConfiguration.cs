using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marguds_BussinessObject.Model
{
    public class FeesConfiguration
    {
        [Key]
        public Guid FeeConfigID { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PaymentFeePercentage { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal FixedFeePercentage { get; set;}
    }
}
