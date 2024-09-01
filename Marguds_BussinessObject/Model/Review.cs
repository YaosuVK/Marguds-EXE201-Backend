using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marguds_BussinessObject.Model
{
    public class Review
    {
        [Key]
        public Guid ReviewID { get; set; }
        //
        public Guid ProductID { get; set; }
        [ForeignKey("ProductID")]
        public Product Product { get; set; }
        //
        public Guid AccountID { get; set; }
        [ForeignKey("AccountID")]
        public Account Account { get; set; }

        public DateTime CreateAt { get; set; } = DateTime.Now;

        public DateTime UpdateAt { get; set; }

        public string Content { get; set; }

    }
}
