    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marguds_BussinessObject.Model
{
    public class Report
    {
        [Key]
        public Guid ReportID { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public string ReportText { get; set; }
        public string ResponseText { get; set; }
        [ForeignKey("OrderID")]
        public Guid OrderID { get; set; }

        public Order? Order { get; set; } = null!;
        public Guid AccountID { get; set; }
        [ForeignKey("AccountID")]
        public Account Account { get; set; }

        public Guid ProductID { get; set; }
        [ForeignKey("ProductID ")]
        public Product Products { get; set; }

        public string? Image { get; set; }
    }
}
